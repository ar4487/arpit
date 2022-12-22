using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Controllers
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
        [Authorize]
        public IEnumerable<Register> get()
        {
            return db.Registers;
        }
        [HttpPost]
        [Authorize]
        public IActionResult post(Register register)
        {
            var isRegistration = db.Registers.Any(x => x.Username == register.Username);

            if (isRegistration)
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
        [HttpPut]
        public IActionResult Update(int id, Register register)
        {
            var UpdateData = db.Registers.FirstOrDefault(x => x.Id == id);
            var isupdate = db.Registers.Any(x => x.Id == id);
                if (isupdate)
            {
                UpdateData.Username = register.Username;
                UpdateData.Password = register.Password;
                db.Registers.Update(UpdateData);
                    db.SaveChanges();
                return Ok("Update Sucessfully");
            }
            return Ok("data not exist");
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            var delete = db.Registers.FirstOrDefault(x => x.Id == id);
            var Isdelete = db.Registers.Any(x => x.Id == id);
            if (Isdelete)
            {
                db.Registers.Remove(delete);
                db.SaveChanges();
                return Ok("Delete ho gya");
            }
            return Ok("Data not exist");
        }
    }
}
