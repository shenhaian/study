/*
*┌────────────────────────────────────────────────┐
*│　描   述：Target                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 18:14:52                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._02Structure._01Adapter
{
   internal class Target
    {
        public virtual void Request()
        {
            Console.WriteLine($"{typeof(Target).FullName},this Target Request.");
        }
    }

    internal class Adaptee 
    {
        public void SpeciaRequest()
        {
            Console.WriteLine($"{typeof(Adaptee).FullName},this is Specia Request.");
        }
    }

    internal class TargetAdaptee : Target
    {
        private readonly Adaptee _adaptee = new Adaptee();
        public override void Request()
        {
            _adaptee.SpeciaRequest();
        }
    }
}
