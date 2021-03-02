using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScoopenAPI.Controllers
{
    public class LoginController : ApiController
    {

        public string username { get; set; }
        public string password { get; set; } 

        public bool Login()
        {
            return true;
        }

    }
}
