using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Model.Request
{
    public class FeedbackRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "InterviewId is required")]
        public int InterviewId { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ABBR is required")]
        public string ABBR { get; set; }

    }
}