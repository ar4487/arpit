using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        RegisterContext db;
        public RegisterController(RegisterContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Register> get()
        {
            return db.Registers;
        }
        [HttpPost]
        public IActionResult post(Register register)
        {
            var isRegistration = db.Registers.Any(x => x.Username == register.Username );

            if (isRegistration == true)
            {
                return Ok("Already Registered!");
            }
            else
            {
                db.Registers.Add(register);
                db.SaveChanges();
                return Ok("successfully registered");
            }
        }
    }
}
