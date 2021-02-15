using ScoopenAPI.Models.MyModels;
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
        public string UserName {get;set;}
        public IHttpActionResult Login(LoginRequest request)
        {
            // bll -> dal -> sp 
            return Ok(true);
        }
    }
}
