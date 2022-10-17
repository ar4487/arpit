using customerlogin.Models;
using customerlogin.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace customerlogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        
        logindbContext db;
        public loginController(logindbContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public IActionResult login(loginview loginview)
        {
            var islogin =db.TblLogins.Any(x => x.Username == loginview.Username && x.Password == loginview.Password);
            return Ok(new{islogin = true, message =islogin?"Sucessfully login":"Either username or passwor wrong"});
        }
    }
}
