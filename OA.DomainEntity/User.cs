using System;
using System.Collections.Generic;
using System.Text;

namespace OA.DomainEntity
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual UserProfile userProfile { get; set; }
    }
}
