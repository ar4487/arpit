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
    public class ProductController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        [HttpGet]
        public IEnumerable<Pro> get()
        {
            return db.Pros;
        }
        [HttpPost]
        public IActionResult post(Pro customer)
        {
            db.Pros.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
    }
}
