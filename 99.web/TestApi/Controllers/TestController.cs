using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    /// <summary>
    /// 测试接口
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// Get方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]  
        public string  Get()
        {
            return "Ok";
        }

        /// <summary>
        /// Value 方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Value()
        {
            return "Value";
        }
    }
}