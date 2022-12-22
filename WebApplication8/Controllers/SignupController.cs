using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        SignupContext db;
        public SignupController(SignupContext _db)
        {
            db = _db; 
        }
        [HttpGet]
        
        public IEnumerable<Signup> get()
        {
            return db.Signups;
        }
        [HttpPost]
        public IActionResult Create(Signup signup)
        {
            if (signup.Username == "Admin" && signup.Password == "Admin12345678")
            {
                signup.Role = "Admin";
            }
            else
            {
                signup.Role = "User"; 
            }
                db.Signups.Add(signup);
                db.SaveChanges();
                return Ok("Kaam ho gya malik ");
            
        }
    }
}
