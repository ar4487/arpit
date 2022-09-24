using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.model2;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace WebApplication2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        public IEnumerable<Tbl_1> get()
        {
            return db.Tbl_1s;
        }

    }
}