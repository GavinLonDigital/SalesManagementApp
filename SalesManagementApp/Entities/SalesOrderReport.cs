namespace SalesManagementApp.Entities
{
    public class SalesOrderReport
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderQty { get; set; }
        public int OrderItemId { get; set; }
        public int OrderItemQty { get; set; }
        public decimal OrderItemPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public int RetailOutletId { get; set; }
        public string RetailOutletLocation { get; set; }

    }
}
