/*
*┌────────────────────────────────────────────────┐
*│　描   述：Singleton1                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 15:18:52                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._06Singleton
{
    /// <summary>
    /// 饿汉模式,担心饿死，类加载就给实例化好
    /// </summary>
    public class Singleton1
    {
        /// <summary>
        /// 静态初始化，由 CLR 去创建
        /// </summary>
        private static readonly Singleton1 _instance = new Singleton1();

        private Singleton1() { }

        public static Singleton1 GetInstance() => _instance;
    }
}
