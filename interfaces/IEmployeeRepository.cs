using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMangement.dtos.Employee;
using EmployeeMangement.models;

namespace EmployeeMangement.interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        Task<Employee> CreateAsync(Employee employee);
        Task<Employee?> UpdateAsync(int id, CreateUpdateEmployeeDto createUpdateEmployeeDto);
        Task<Employee?> DeleteAsync(int id);
        
    }
}