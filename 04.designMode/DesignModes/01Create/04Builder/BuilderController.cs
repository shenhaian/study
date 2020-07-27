/*
*┌────────────────────────────────────────────────┐
*│　描   述：BuilderController           
*    建造者模式: 建造者模式隐藏了复杂对象的创建过程，它把复杂对象的创建过程加以抽象，通过子类继承或者重载的方式，动态的创建具有复合属性的对象。
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:27:17                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._04Builder
{
    [ApiController]
    [Route("api/Builder/[action]")]
    public class BuilderController : ControllerBase
    {
        [HttpGet]
        public string BuilderTest()
        {
            //实例化建筑对象
            Builder builder1 = new ConcreteBuilder1(),builder2=new ConcreteBuilder2();
            //实例化一个组装者
            Director director = new Director();
            //组装者组装建筑对象1
            director.Construct(builder1);
            //组装者组装建筑对象2
            director.Construct(builder2);

            //获取组装结果
            builder1.GetResult().Show();
            builder2.GetResult().Show();

            return "Ok";
        }
    }
}
