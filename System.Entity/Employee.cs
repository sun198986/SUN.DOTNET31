using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace System.Entity
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
