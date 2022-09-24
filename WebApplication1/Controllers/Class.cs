using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers;
using WebApplication1.models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        customerContext db = new customerContext();
        public IEnumerable<tb1> get()
        {
            return db.tb1s;
        }
        //[HttpPost]
        //public IActionResult post(tb1 customer)
        //{
            //    db.tb1s.Add(customer);
            //    db.SaveChanges();
            //    return Ok(new { ststus = "your record is added suceessfully" });
            //}
        }
    }
//}