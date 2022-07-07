using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class OrganisationService : IOrganisationService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;

        public OrganisationService(SalesManagementDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }
        public async Task<List<OrganisationModel>> GetHierarchy()
        {
            try
            {
                return await this.salesManagementDbContext.Employees.ConvertToHierarchy(salesManagementDbContext);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
