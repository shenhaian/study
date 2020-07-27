/*
*┌────────────────────────────────────────────────┐
*│　描   述：FactoryMethodController      
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 18:09:49                        
*└────────────────────────────────────────────────┘
*/
using Autofac;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
    /// <summary>
    /// 工厂方法模式： 定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到子类。
    ///  工厂方法模式实现时，客户端需要决定实例化哪一个工厂来实现客户端的操作
    /// </summary>
    [ApiController]
    [Route("api/FactoryMethod/[action]")]
    public class FactoryMethodController : ControllerBase
    {
        /// <summary>
        /// 工厂方法模式
        /// </summary>
        /// <param name="methodName">方法名称：BuyRice||Wash||Sweep</param>
        /// <returns></returns>
        [HttpGet]
        public string FactoryMethod(string methodName)
        {
            ILeiFengFactory factory = new UndergraduteLeiFeng();
            var leifeng=factory.CreateLeiFeng();
            switch (methodName)
            {
                case "BuyRice":
                    leifeng.BuyRice();
                    break;
                case "Wash":
                    leifeng.Wash();
                    break;
                case "Sweep":
                    leifeng.Sweep();
                    break;
            }

            factory = new AolunteerLeiFeng();
            leifeng = factory.CreateLeiFeng();
            switch (methodName)
            {
                case "BuyRice":
                    leifeng.BuyRice();
                    break;
                case "Wash":
                    leifeng.Wash();
                    break;
                case "Sweep":
                    leifeng.Sweep();
                    break;
            } 
            return "Ok"; 
        }

        /// <summary>
        /// 工厂方法+依赖注入
        /// </summary>
        /// <param name="type">1= UndergraduteLeiFeng other=AolunteerLeiFeng</param>
        /// <param name="methodName">BuyRice||Wash||Sweep</param>
        /// <returns></returns>
        [HttpGet]
        public string FactoryMethodDependencyInjection(int type,string methodName)
        {
            var builder = new ContainerBuilder();
            if (type == 1)
            {
                builder.RegisterType<UndergraduteLeiFeng>().As<ILeiFengFactory>();
            }
            else
            {
                builder.RegisterType<AolunteerLeiFeng>().As<ILeiFengFactory>();
            }
            var container = builder.Build();
            var factory = container.Resolve<ILeiFengFactory>();
            var leifeng = factory.CreateLeiFeng();
            switch (methodName)
            {
                case "BuyRice":
                    leifeng.BuyRice();
                    break;
                case "Wash":
                    leifeng.Wash();
                    break;
                case "Sweep":
                    leifeng.Sweep();
                    break;
            }
            return "Ok";
        }

        /// <summary>
        /// 工厂方法+发射
        /// </summary>
        /// <param name="factoryName">UndergraduteLeiFeng||AolunteerLeiFeng</param>
        /// <param name="methodName">BuyRice||Wash||Sweep</param>
        /// <returns></returns>
        [HttpGet]
        public string FactoryMethodReflection(string factoryName,string methodName)
        {
            var factory = DbFactory.CreateFactory(factoryName);
            var leifeng = factory.CreateLeiFeng();
            switch (methodName)
            {
                case "BuyRice":
                    leifeng.BuyRice();
                    break;
                case "Wash":
                    leifeng.Wash();
                    break;
                case "Sweep":
                    leifeng.Sweep();
                    break;
            }
            return "Ok";
        }
    }
}
