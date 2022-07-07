using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IAppointmentService
    {
        Task<List<AppointmentModel>> GetAppointments();
        Task AddAppointment(AppointmentModel appointmentModel);
        Task UpdateAppointment(AppointmentModel appointmentModel);
        Task DeleteAppointment(int id);
    }
}
