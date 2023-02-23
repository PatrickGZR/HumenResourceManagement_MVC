using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class Role
    {
        //Id,
        public int Id { get; set; }
        //Name
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        //description
        [Column(TypeName ="varchar(70)")]
        public string Description { get; set; }
    }
}
