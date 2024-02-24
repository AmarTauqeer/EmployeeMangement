using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMangement.dtos.Employee;
using EmployeeMangement.interfaces;
using EmployeeMangement.models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangement.repository
{
    public class EmployeeRepository(EmployeeContextDB employeeContextDB) : IEmployeeRepository
    {
        private readonly EmployeeContextDB _employeeContextDB = employeeContextDB;

        public async Task<Employee> CreateAsync(Employee employee)
        {

            await _employeeContextDB.Employees.AddAsync(employee);
            await _employeeContextDB.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee?> DeleteAsync(int id)
        {
            var employee = await _employeeContextDB.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (employee == null)
            {
                return null;
            }
            _employeeContextDB.Remove(employee);
            await _employeeContextDB.SaveChangesAsync();
            return employee;
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _employeeContextDB.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _employeeContextDB.Employees.FindAsync(id);
        }

        public async Task<Employee?> UpdateAsync(int id, CreateUpdateEmployeeDto createUpdateEmployeeDto)
        {
            var employee = await _employeeContextDB.Employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if (employee == null)
            {
                return null;
            }
            employee.EmployeeId = id;
            employee.EmployeeName = createUpdateEmployeeDto.EmployeeName;
            employee.DepartmentId=createUpdateEmployeeDto.DepartmentId;
            employee.Email = createUpdateEmployeeDto.Email;
            employee.Phone = createUpdateEmployeeDto.Phone;
            employee.Address = createUpdateEmployeeDto.Address;
            employee.City = createUpdateEmployeeDto.City;
            employee.Country = createUpdateEmployeeDto.Country;
            employee.PostalCode = createUpdateEmployeeDto.PostalCode;
            employee.CreateAt=createUpdateEmployeeDto.CreateAt;
            employee.DOB=createUpdateEmployeeDto.DOB;

            await _employeeContextDB.SaveChangesAsync();
            return employee;
        }
    }
}