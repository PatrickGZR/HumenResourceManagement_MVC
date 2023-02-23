using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Model.Request
{
    public class CandidateRequestModel
    {
        public int Id { get; set; }
        //FirstName
        [Required(ErrorMessage ="First Name is required")]
        public string FirstName { get; set; }
        //LastName
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        //Mobile
        [Required(ErrorMessage = "Phone is required")]
        public string Mobile { get; set; }
        //EmailId
        [Required(ErrorMessage = "EmailId is required")]
        public string EmailId { get; set; }

    }
}
