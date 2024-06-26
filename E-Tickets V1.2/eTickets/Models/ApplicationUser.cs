﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Kullanıcı Adı")]
        public string FullName { get; set; }
    }
}
