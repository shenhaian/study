/*
*┌────────────────────────────────────────────────┐
*│　描   述：Singleton                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 15:18:39                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._06Singleton
{
    /// <summary>
    /// 双重判空枷锁，（饱汉模式）懒汉式，用的时候才去实例化
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object SyncLock = new object();

        private Singleton()
        { 
        
        }

        /// <summary>
        /// 双重判空加锁，确保对象唯一性
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            if (_instance == null)
            { 
                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            } 
            return _instance;
        }
    }
}
