namespace SalesManagementApp.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Subject { get; set; }
        public string? Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Description { get; set; }
        public bool IsAllDay { get; set; }
        public string? RecurrenceRule { get; set; }
        public string? RecurrenceException { get; set; }
        public Nullable<int> RecurrenceId { get; set; }
    }
}
