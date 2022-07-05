﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using TicketsApp.Models.Domain;

namespace TicketsApp.Models.Identity
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public virtual ShoppingCart UserCart { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
