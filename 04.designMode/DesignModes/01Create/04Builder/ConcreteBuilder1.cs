/*
*┌────────────────────────────────────────────────┐
*│　描   述：ConcreteBuilder1                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:19:51                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignModes._01Create._04Builder
{
    internal class ConcreteBuilder1 : Builder
    {
        private readonly Product product = new Product();
        public override void BuilderA() => product.Add("Part1X");


        public override void BuilderB() => product.Add("Part1Y");

        public override Product GetResult() => product;
    }
}
