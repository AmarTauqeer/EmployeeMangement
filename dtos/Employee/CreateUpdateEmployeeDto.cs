using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.dtos.Employee
{
    public class CreateUpdateEmployeeDto
    {
        public string EmployeeName { get; set; } = string.Empty;
        public string Email { get; set; } = "test@gmail.com";
        public string Phone { get; set; } = "+4368864133067";
        public string Address { get; set; } = "address";
        public string PostalCode { get; set; } = "6020";
        public string City { get; set; } = "Innsbruck";
        public string Country { get; set; } = "Austria";
        public int DepartmentId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime DOB { get; set; }

    }
}