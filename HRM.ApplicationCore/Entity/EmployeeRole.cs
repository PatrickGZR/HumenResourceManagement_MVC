using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class EmployeeRole
    {
        //Id
        public int Id { get; set; }
        //Title
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Title { get; set; }
        //Description
        [Column(TypeName = "varchar(30)")]
        public string Description { get; set; }
        //IsActive
        public bool IsActive { get; set; }
    }
}
