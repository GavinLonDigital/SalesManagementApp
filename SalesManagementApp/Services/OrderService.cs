using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Data;
using SalesManagementApp.Entities;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class OrderService : IOrderService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public OrderService(SalesManagementDbContext salesManagementDbContext,
                            AuthenticationStateProvider authenticationStateProvider)
        {
            this.salesManagementDbContext = salesManagementDbContext;
            this.authenticationStateProvider = authenticationStateProvider;
        }
        public async Task CreateOrder(OrderModel orderModel)
        {
            //The three tasks being performed in this method run in a transaction
            //if an error occurs during the processing of any task that runs within the transaction
            //no changes will be made to the database - all tasks will fail together - i.e. all or nothing
            using (var dbContextTransaction = await this.salesManagementDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    var employee = await GetLoggedOnEmployee();

                    Order order = new Order
                    {
                        OrderDateTime = DateTime.Now,
                        ClientId = orderModel.ClientId,
                        EmployeeId = employee.Id,
                        Price = orderModel.OrderItems.Sum(o => o.Price),
                        Qty = orderModel.OrderItems.Sum(o => o.Qty)
                    };

                    var addedOrder = await this.salesManagementDbContext.Orders.AddAsync(order);
                    await this.salesManagementDbContext.SaveChangesAsync();
                    int orderId = addedOrder.Entity.Id;

                    var orderItemsToAdd = ReturnOrderItemsWithOrderId(orderId, orderModel.OrderItems);
                    this.salesManagementDbContext.AddRange(orderItemsToAdd);

                    await this.salesManagementDbContext.SaveChangesAsync();

                    await UpdateSalesOrderReportsTable(orderId, order);

                    await dbContextTransaction.CommitAsync();

                }

                catch (Exception)
                {
                    await dbContextTransaction.DisposeAsync();
                    throw;
                }
            }

        }

        private List<OrderItem> ReturnOrderItemsWithOrderId(int orderId, List<OrderItem> orderItems)
        {
            return (from oi in orderItems
                    select new OrderItem
                    {
                        OrderId = orderId,
                        Price = oi.Price,
                        Qty = oi.Qty,
                        ProductId = oi.ProductId
                    }).ToList();
        }
        private async Task UpdateSalesOrderReportsTable(int orderId, Order order)
        {
            try
            {
                List<SalesOrderReport> srItems = await (from oi in this.salesManagementDbContext.OrderItems
                                                       where oi.OrderId == orderId
                                                       select new SalesOrderReport
                                                       {
                                                           OrderId = orderId,
                                                           OrderDateTime = order.OrderDateTime,
                                                           OrderPrice = order.Price,
                                                           OrderQty = order.Qty,
                                                           OrderItemId = oi.Id,
                                                           OrderItemPrice = oi.Price,
                                                           OrderItemQty = oi.Qty,
                                                           EmployeeId = order.EmployeeId,
                                                           EmployeeFirstName = salesManagementDbContext.Employees.FirstOrDefault(e => e.Id == order.EmployeeId).FirstName,
                                                           EmployeeLastName = salesManagementDbContext.Employees.FirstOrDefault(e => e.Id == order.EmployeeId).LastName,
                                                           ProductId = oi.ProductId,
                                                           ProductName = salesManagementDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).Name,
                                                           ProductCategoryId = salesManagementDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).CategoryId,
                                                           ProductCategoryName = salesManagementDbContext.ProductCategories.FirstOrDefault(c => c.Id == salesManagementDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).CategoryId).Name,
                                                           ClientId = order.ClientId,
                                                           ClientFirstName = salesManagementDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).FirstName,
                                                           ClientLastName = salesManagementDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).LastName,
                                                           RetailOutletId = salesManagementDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).RetailOutletId,
                                                           RetailOutletLocation = salesManagementDbContext.RetailOutlets.FirstOrDefault(r => r.Id == salesManagementDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).RetailOutletId).Location
                                                       }).ToListAsync();

                this.salesManagementDbContext.AddRange(srItems);
                await this.salesManagementDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task<Employee> GetLoggedOnEmployee()
        {
            var authState = await this.authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            return await user.GetEmployeeObject(this.salesManagementDbContext);
        }
    }
}
