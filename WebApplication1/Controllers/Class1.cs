using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.model1;

namespace WebApplication1.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class EcommerceController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        public IEnumerable<Tbl1> get()
        {
            return db.Tbl1s;
        }

    }
}
    

