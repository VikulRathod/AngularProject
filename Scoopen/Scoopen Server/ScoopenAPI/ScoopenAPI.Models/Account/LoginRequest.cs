using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScoopenAPI.Models.Account
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}