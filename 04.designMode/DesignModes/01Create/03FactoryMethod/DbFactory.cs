/*
*┌────────────────────────────────────────────────┐
*│　描   述：DbFactory                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 10:17:35                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
   internal class DbFactory
    {
        private static readonly string AssemblyName = "DesignModes._01Create._03FactoryMethod";
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ILeiFengFactory CreateFactory(string factoryName)
        {
            var factory =(ILeiFengFactory) typeof(DbFactory).Assembly.CreateInstance($"{AssemblyName}.{factoryName}");
            return factory;
        }
    }
}
