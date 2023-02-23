using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Id, Title, IsActive
namespace HRM.ApplicationCore.Entity
{
    public class InterviewType
    {
        //Id
        public int Id { get; set; }
        //Title
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Title { get; set; }
        //IsActive
        public bool IsActive { get; set; }
    }
}
