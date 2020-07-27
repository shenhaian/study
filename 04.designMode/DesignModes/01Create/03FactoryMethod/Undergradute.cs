/*
*┌────────────────────────────────────────────────┐
*│　描   述：Undergradute                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 18:04:23                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
    internal class Undergradute : LeiFeng
    {
        public Undergradute():base(typeof(Undergradute).FullName) { }
    }
}
