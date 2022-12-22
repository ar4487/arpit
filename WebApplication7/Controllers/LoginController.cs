using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        RegisterContext db;
        private IConfiguration config;
        public LoginController(RegisterContext _db, IConfiguration _Config)
        {
            db = _db;
            config = _Config;
        }
        [HttpPost]
        public IActionResult post(Register register)
        {
            var IsLogin = db.Registers.FirstOrDefault(x => x.Username == register.Username && x.Password.Equals(register.Password));
            if (IsLogin!=null)
            {
                return Ok( new JwtRespository(config).GenerateToken(
                  IsLogin.Id.ToString(),
                    IsLogin.Username

                   )
                   );
            }
            return Ok("NIKAl PHELI FURSAT MAE NIKL");
        } 
            
    }
}
