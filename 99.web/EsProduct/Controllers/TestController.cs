using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsProduct.Controllers
{
    [ApiController]
    [Route("api/test/[action]")]
    public class TestController:Controller
    {

        [HttpGet]
        public  string GetTest()
        {
            return  "Ok";
        }
    }
}
