/*
*┌────────────────────────────────────────────────┐
*│　描   述：Director                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 11:17:17                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._04Builder
{
   internal class Director
    {
        public void Construct (Builder builder)
        {
            builder.BuilderA();
            builder.BuilderB();
        }
    }
}
