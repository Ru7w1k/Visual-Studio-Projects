﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthThirdParty.DAL
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}