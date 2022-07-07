using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();

    }
}
