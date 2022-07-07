using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IOrganisationService
    {
        Task<List<OrganisationModel>> GetHierarchy();
    }
}
