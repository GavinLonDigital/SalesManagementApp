using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IOrderService
    {
        Task CreateOrder(OrderModel orderModel);
    }
}
