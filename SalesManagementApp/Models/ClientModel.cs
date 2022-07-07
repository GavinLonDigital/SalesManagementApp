namespace SalesManagementApp.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int RetailOutletId { get; set; }
        public string RetailOutletName { get; set; }
        public string RetailOutletLocation { get; set; }
    }
}
