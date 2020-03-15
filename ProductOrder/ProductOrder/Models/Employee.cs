using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrder.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(25)]
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string HomePhone { get; set; }
        [MaxLength(4)]
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }

        public int? ReportsTo { get; set; }
        [ForeignKey("ReportsTo")]
        public Employee EmployeeReportsTo { get; set; }

        [MaxLength(255)]
        public string PhotoPath { get; set; }

        public EmployeeTerritory EmployeeTerritory { get; set; }
        public Order Order { get; set; }
    }
}
