using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Data;
using SalesManagementApp.Entities;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;

        public EmployeeManagementService(SalesManagementDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }

        public async Task<Employee> AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                Employee employeeToAdd =  employeeModel.Convert();

                var result = await this.salesManagementDbContext.Employees
                                .AddAsync(employeeToAdd);

                await this.salesManagementDbContext.SaveChangesAsync();

                return result.Entity;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployee(int id)
        {
            try
            {
                var employee = await this.salesManagementDbContext.Employees.FindAsync(id);
                if(employee!=null)
                {
                    this.salesManagementDbContext.Employees.Remove(employee);
                    await this.salesManagementDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            try
            {
                return await this.salesManagementDbContext.Employees.Convert();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EmployeeJobTitle>> GetJobTitles()
        {
            try
            {
                return await this.salesManagementDbContext.EmployeeJobTitles.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ReportToModel>> GetReportToEmployees()
        {
            try
            {
                var employees = await (from e in this.salesManagementDbContext.Employees
                                       join j in this.salesManagementDbContext.EmployeeJobTitles
                                       on e.EmployeeJobTitleId equals j.EmployeeJobTitleId
                                       where j.Name.ToUpper() == "TL" || j.Name.ToUpper() == "SM"

                                       select new ReportToModel
                                       {
                                           ReportToEmpId = e.Id,
                                           ReportToName = e.FirstName + " " 
                                                            + e.LastName.Substring(0,1).ToUpper() + "."
                                       }).ToListAsync();
                
                employees.Add(new ReportToModel { ReportToEmpId = null, ReportToName = "<None>" });
            
                return employees.OrderBy(o => o.ReportToEmpId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateEmployee(EmployeeModel employeeModel)
        {
            try
            {
                var employeeToUpdate = await this.salesManagementDbContext.Employees.FindAsync(employeeModel.Id);

                if(employeeToUpdate != null)
                {
                    employeeToUpdate.FirstName = employeeModel.FirstName;
                    employeeToUpdate.LastName = employeeModel.LastName;
                    employeeToUpdate.ReportToEmpId = employeeModel.ReportToEmpId;
                    employeeToUpdate.DateOfBirth = employeeModel.DateOfBirth;
                    employeeToUpdate.ImagePath = employeeModel.ImagePath;
                    employeeToUpdate.Gender = employeeModel.Gender;
                    employeeToUpdate.Email = employeeModel.Email;
                    employeeToUpdate.EmployeeJobTitleId = employeeModel.EmployeeJobTitleId;

                    await this.salesManagementDbContext.SaveChangesAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
