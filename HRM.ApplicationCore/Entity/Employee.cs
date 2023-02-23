using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class Employee
    {
        //Id
        public int Id { get; set; }
        //FirstName & LastName
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        //EmailId
        [Required]
        [Column(TypeName = "varchar(70)")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        //DOB
        public DateTime DOB { get; set; }
        //SSN
        public string SSN { get; set; }
        //CurrentAddress
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string CurrentAddress { get; set; }
        //Phone
        [Required]
        [Column(TypeName = "varchar(10)")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        //HireDate
        public DateTime HireDate { get; set; }
        //EmployeeRoleId
        public int EmployeeRoleId { get; set; }
        //EmployeeTypeId
        public int EmployeeTypeId { get; set; }
        //EndDate
        public DateTime EndDate { get; set; }
        //EmployeeStatusId
        public int EmployeeStatusId { get; set; }
        //ManagerId
        public int? ManagerId { get; set; }

        //navigational property
        public EmployeeRole EmployeeRole { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Employee Manager { get; set; }
    }
}
