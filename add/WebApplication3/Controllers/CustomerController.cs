using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        [HttpGet]
        public IEnumerable<Cust> get()
        {
            return db.Custs;
        }
        [HttpPost]
        public IActionResult post(Cust customer)
        {
            db.Custs.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
    }
}
