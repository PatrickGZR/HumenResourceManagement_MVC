using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class Feedback
    {
        //Id, InterviewId, Description, ABBR
        public int Id { get; set; }
        //InterviewId
        public int InterviewId { get; set; }
        //Description
        [Required]
        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }
        //ABBR
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ABBR { get; set; }

        //navigational properties
        public Interview Interview { get; set; }

    }
}
