/*
*┌────────────────────────────────────────────────┐
*│　描   述：Volunteer                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 18:05:18                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
   internal class Volunteer:LeiFeng
    {
        public Volunteer():base(typeof(Volunteer).FullName) { }
    }
}
