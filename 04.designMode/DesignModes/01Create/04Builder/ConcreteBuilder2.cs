/*
*┌────────────────────────────────────────────────┐
*│　描   述：ConcreteBuilder2                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:20:16                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._04Builder
{
    internal class ConcreteBuilder2 : Builder
    {
        private readonly Product product = new Product();
        public override void BuilderA()=> product.Add("Part2A");

        public override void BuilderB() => product.Add("Part2B");
         
        public override Product GetResult() => product;
        
    }
}
