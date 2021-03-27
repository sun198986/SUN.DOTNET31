using System;
using System.Collections.Generic;
using System.Text;

namespace System.Entity
{
    public class CompanyExtend
    {
        public string CompanyName { get; set; }

        public int EmployeeCount { get; set; }

        public string EmployeeName { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

    }
}
