using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class ClientService : IClientService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;

        public ClientService(SalesManagementDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }
        public async Task<List<ClientModel>> GetClients()
        {
            try
            {
                return await this.salesManagementDbContext.Clients.Convert(salesManagementDbContext);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
