using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class User
    {
        //Id
        public int Id { get; set; }
        //Username
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string UserName { get; set; }
        //EmailId
        [Required]
        [Column(TypeName = "varchar(30)")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        //password
        [Required]
        [Column(TypeName = "varchar(60)")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
