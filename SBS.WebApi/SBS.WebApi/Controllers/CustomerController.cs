using SBS.BAL;
using SBS.BAL.Interface;
using SBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SBS.WebApi.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly IUserManager _userManager;

        public CustomerController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public IHttpActionResult PostCreateUser([FromBody] Customer model)
        {
            return Ok(_userManager.CreateCustomer(model));
        }

        public IHttpActionResult PostAuthenticateUser(Customer model)
        {
            return Ok(_userManager.AuthenticateCustomer(model));
        }
    }
}
