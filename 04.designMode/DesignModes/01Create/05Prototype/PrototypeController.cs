/*
*┌────────────────────────────────────────────────┐
*│　描   述：PrototypeController                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 14:43:39                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._05Prototype
{
    /// <summary>
    /// 原型模式，用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象
    /// 原型模式其实就是从一个对象再创建另外一个可定制的对象而且不需要知道任何创建的细节。
    /// 在 c# 中可以实现 `ICloneable` 接口和 `MemberwiseClone` 方法来方便的实现原型模式
    /// </summary>
    [ApiController]
    [Route("api/Prototype/[action]")]
    public class PrototypeController : ControllerBase
    {
        /// <summary>
        /// 浅复制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string PrototypeShallow()
        {
            var resume = new SimpleResume();
            resume.SetPersonalInfo("小明", "xiaoming@abc.com");
            resume.SetWorkExperience("19999-2020", "xxxCompany");
            resume.Display();

            var resume1 = (SimpleResume)resume.Clone();
            resume1.SetPersonalInfo("小李", "xiaoLi@abc.com");
            resume1.SetWorkExperience("1995-2020", "bbbCompany");
            resume1.Display();

            var resume2 = (SimpleResume)resume.Clone();
            resume2.SetPersonalInfo("小张", "xiaoZhang@abc.com");
            resume2.Display();

            resume.Display(); 
            return "Ok"; 
        }

        /// <summary>
        /// 深拷贝：深拷贝 对象引用类型的值 会new 一个新对象存储跟原对象的值不会有关联
        /// 浅拷贝：深拷贝 对象引用类型的值 会引用原对象的地址，修改新对象的值，原对象的值也会随着改变
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string PrototypeDeep()
        {
            var complexResume = new ComplexResume();
            complexResume.SetPersonalInfo("xiaoming", "XM@abc.com");
            complexResume.SetWorkExperience("1975-1999", "cccCompany");
            complexResume.Display();

            //深拷贝
            var complexResume1 = (ComplexResume)complexResume.Clone();
            complexResume1.SetPersonalInfo("xiaoZhang", "XZ@abc.com");
            complexResume1.SetWorkExperience("1976-1977", "dddCompany");
            complexResume1.Display();

            var complexResume2 = (ComplexResume)complexResume.Clone();
            complexResume2.SetPersonalInfo("小溪", "XX@abc.com");
            complexResume2.Display();

            //浅拷贝，引用类型值变更，原对象的值也会随着变更
            var complexResume3 = (ComplexResume)complexResume.ShallowCopy();
            complexResume3.SetPersonalInfo("小白","XB@abc.com");
            complexResume3.SetWorkExperience("1966-1977", "eeeCompany");
            complexResume3.Display(); 

            complexResume.Display(); 
            return "Ok"; 
        }
    }
}
