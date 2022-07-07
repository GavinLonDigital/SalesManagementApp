namespace SalesManagementApp.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
    }
}
