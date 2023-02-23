using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//InterviewStatus table(scheduled, rescheduled, cancelled, finished)
namespace HRM.ApplicationCore.Entity
{
    public class InterviewStatus
    {
        //Id, Title, IsActive
        public int Id { get; set; }
        //Title
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Title { get; set; }
        //IsActive
        public bool IsActive { get; set; }
    }
}
