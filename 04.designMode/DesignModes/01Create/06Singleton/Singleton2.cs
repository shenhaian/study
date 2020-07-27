/*
*┌────────────────────────────────────────────────┐
*│　描   述：Singleton2                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 15:19:09                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._06Singleton
{
    /// <summary>
    /// 使用ConcurrentDictionary 并发字典实现锁机制,到用的时候再去实例化
    /// 这种方式类似于双重锁定方式，只是使用了并发集合代替了双重判断和 lock
    /// </summary>
    public class Singleton2
    {
        private static readonly ConcurrentDictionary<int, Singleton2> Instances = new ConcurrentDictionary<int, Singleton2>();

        private Singleton2() { }

        public static Singleton2 GetInstance() => Instances.GetOrAdd(1,k=>new Singleton2());
    }
}
