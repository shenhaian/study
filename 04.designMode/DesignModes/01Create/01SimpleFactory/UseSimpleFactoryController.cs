/*
*┌────────────────────────────────────────────────┐
*│　描   述：UseSimpleFactory                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 16:40:47                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._01SimpleFactory
{
    /// <summary>
    /// 简单工厂模式：由一个工厂对象决定创建出哪一种产品类的实例
    /// </summary>
    [ApiController]
    [Route("api/UseSimpleFactory/[action]")]
    public class UseSimpleFactoryController : ControllerBase
    { 
        [HttpGet]
        public string SimpleFactoryTest(string oper)
        {
            Operation operation = OperationFactory.CreateOperation(oper); 
            return $"返回对象类型：{operation.GetType().FullName}";
        }
    }
}
