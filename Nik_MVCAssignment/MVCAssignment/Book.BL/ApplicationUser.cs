﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BL
{
    public class ApplicationUser : IdentityUser

    {
        public string FullName { get; set; }
    }
}
