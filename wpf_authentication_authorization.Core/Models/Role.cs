using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_authentication_authorization.Core.Models
{
    public class Role : DomainObject
    {
        public Role()
        {
            Users = new List<User>();
        }

        public string RoleName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public int? UserId { get; set; }
        public List<User>? Users { get; set; }
    }
}