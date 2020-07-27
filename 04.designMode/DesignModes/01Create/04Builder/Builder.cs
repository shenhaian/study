/*
*┌────────────────────────────────────────────────┐
*│　描   述：Builder                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:14:51                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._04Builder
{
   internal abstract class Builder
    {
        public abstract void BuilderA();
        public abstract void BuilderB();

        public abstract Product GetResult();
    }
}
