/*
*┌────────────────────────────────────────────────┐
*│　描   述：Singleton3                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 15:19:27                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._06Singleton
{
    /// <summary>
    /// 使用Lazy 实现单列，到用的时候再去实例化
    /// </summary>
    public class Singleton3
    {
        private static readonly Lazy<Singleton3> Instance = new Lazy<Singleton3>(()=>new Singleton3());

        private Singleton3() { }

        public static Singleton3 GetInstance() => Instance.Value;
    }
}
