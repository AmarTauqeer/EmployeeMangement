using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMangement.dtos.Employee;

namespace EmployeeMangement.dtos.Department
{
    public class DepartmentDto
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }
        public List<EmployeeDto>? Employees { get; set; }
    }
}