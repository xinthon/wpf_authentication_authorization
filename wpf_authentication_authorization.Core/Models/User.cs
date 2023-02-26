using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_authentication_authorization.Core.Models
{
    public class User : DomainObject
    {
        public User() 
        {
            Roles = new List<Role>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public List<Role>? Roles { get; set; }
    }
}
