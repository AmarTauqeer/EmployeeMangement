using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMangement.dtos.Department;
using EmployeeMangement.models;

namespace EmployeeMangement.interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<Department> CreateAsync(Department department);
        Task<Department?> UpdateAsync(int id, CreateUpdateDepartmentDto createUpdateDepartmentDto);
        Task<Department?> DeleteAsync(int id);
    }
}