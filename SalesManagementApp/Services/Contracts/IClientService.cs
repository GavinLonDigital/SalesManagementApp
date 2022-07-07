using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IClientService
    {
        Task<List<ClientModel>> GetClients();
    }
}
