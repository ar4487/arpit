using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginContext db;
        private IConfiguration config;
        public LoginController(LoginContext _db,IConfiguration _config )
        {
            db = _db;
            config = _config;
        }
        [HttpPost]
        public IActionResult Authenticate(Login login)
        {
            var islogin = db.Signups.FirstOrDefault(x => x.Username == login.Username && x.Password.Equals(login.Password));
            if (islogin!= null)
            {
                return Ok(new JwtToken(config).GenerateToken(islogin.Role)
                    );
            }
            return Ok("Nikal!");
        }
    }
}
