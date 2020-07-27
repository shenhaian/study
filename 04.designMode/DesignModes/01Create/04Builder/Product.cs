/*
*┌────────────────────────────────────────────────┐
*│　描   述：Product                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:10:41                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._04Builder
{
   internal class Product
    {
        private readonly ICollection<string> _parts = new List<string>();

        public void Add(string part) => _parts.Add(part);

        public void Show()
        {
            Console.WriteLine("\n产品 创建----");
            foreach (string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
