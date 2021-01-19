using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RD.Models.ViewModels
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
