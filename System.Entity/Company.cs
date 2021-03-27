using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace System.Entity
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
