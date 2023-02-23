using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Model.Request
{
    public class SubmissionRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "CandidateId is required")]
        public int CandidateId { get; set; }
        [Required(ErrorMessage = "JobRequirementId is required")]
        public int JobRequirementId { get; set; }
        [Required(ErrorMessage = "AppliedOn is required")]
        public DateTime AppliedOn { get; set; }
    }
}
