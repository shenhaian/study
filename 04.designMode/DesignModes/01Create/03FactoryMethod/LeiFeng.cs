/*
*┌────────────────────────────────────────────────┐
*│　描   述：LeiFen                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 17:59:42                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
   internal class LeiFeng
    {
        private string Type { get; set; }
        public LeiFeng(string type)
        {
            Type = type;
        }

        public void Sweep()
        {
            Console.WriteLine($"触发对象：{Type},扫地");
        }

        public void Wash()
        {
            Console.WriteLine($"触发对象：{Type},洗衣");
        }

        public void BuyRice()
        {
            Console.WriteLine($"触发对象：{Type},买米");
        }
    }
}
