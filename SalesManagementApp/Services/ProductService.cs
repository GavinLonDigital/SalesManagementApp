using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class ProductService : IProductService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;

        public ProductService(SalesManagementDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }
        public async Task<List<ProductModel>> GetProducts()
        {
            try
            {
                var products = await this.salesManagementDbContext.Products.Convert(salesManagementDbContext);
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
