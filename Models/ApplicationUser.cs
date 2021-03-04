using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using a.Models;

namespace a.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Client Client { get; set; }
    }
}
