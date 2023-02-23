using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApplicationCore.Entity
{
    public class UserRole
    {
        //Id
        public int Id { get; set; }
        //UserId
        public int UserId { get; set; }
        //RoleId
        public int RoleId { get; set; }

        //navigational property
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
