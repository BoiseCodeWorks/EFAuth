using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthFun.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthFun.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _um;

        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "Hello", "World" };
        }

        [HttpPost]
        public Movie CreateValue([FromBody]Movie m)
        {
            try
            {
                var user = _um.GetUserAsync(HttpContext.User).Result;
                m.UserId = user.Id;
                return m;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ValuesController(UserManager<IdentityUser> um)
        {
            _um = um;
        }




    }
}