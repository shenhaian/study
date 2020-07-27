/*
*┌────────────────────────────────────────────────┐
*│　描   述：SingletonController                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 16:10:39                        
*└────────────────────────────────────────────────┘
*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeihanLi.Extensions;

namespace DesignModes._01Create._06Singleton
{
    /// <summary>
    /// 单列模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
    /// 基本实现方式是将构造方法私有化，让实例的过程控制在类的内部去完成并对外部提供一个访问实例的方式。
    /// </summary>
    [ApiController]
    [Route("api/Singleton/[action]")]
    public class SingletonController : ControllerBase
    {
        /// <summary>
        /// Singleton:懒汉式，用的时候再去实例化
        /// 双重判空加锁机制，确保只有一个实例
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string SingletonT()
        {
            Console.WriteLine("Singleton~~~~~~~~~~~~~~~");
            Enumerable.Range(1, 5).Select(r => Task.Run(() =>
            {
                Console.WriteLine($"{Singleton.GetInstance().GetHashCode()}");
            })).WhenAll().Wait(); 
            return "Ok";
        }

        /// <summary>
        /// Singleton1:饿汉式单列，怕饿死，类加载就实例化
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Singleton1T()
        {
            Console.WriteLine("Singleton1~~~~~~~~~~");
            Enumerable.Range(1, 5).Select(r => Task.Run(() =>
            {
                Console.WriteLine($"{Singleton1.GetInstance().GetHashCode()}");
            })).WhenAll().Wait();
            return "Ok";
        }

        /// <summary>
        /// ConcurrentDictionary<int,Singleton2> 并发集合实现锁机制
        /// 也是属于懒汉模式，到用的时候再去实例化
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Singleton2T()
        {
            Console.WriteLine("Singleton2~~~~~~~~~~~~~");
            Enumerable.Range(1, 5).Select(r => Task.Run(() =>
            {
                Console.WriteLine($"{Singleton2.GetInstance().GetHashCode()}");
            })).WhenAll().Wait();
            return "Ok"; 
        }

        /// <summary>
        /// Lazy<Singleton3> 懒加载函数实现单列
        /// 也是属于懒汉模式，到用的时候再去实例化
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Singleton3T()
        {
            Console.WriteLine("Singleton3~~~~~~~~~~~~~~");
            Enumerable.Range(1, 5).Select(r => Task.Run(() =>
            {
                Console.WriteLine($"{Singleton3.GetInstance().GetHashCode()}");
            })); 
            return "Ok";
        }
    }
}
