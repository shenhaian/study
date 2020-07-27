/*
*┌────────────────────────────────────────────────┐
*│　描   述：LeiFengFactory                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/22 18:02:39                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._03FactoryMethod
{
   internal interface ILeiFengFactory
    {
        LeiFeng CreateLeiFeng();
    }

    internal class UndergraduteLeiFeng : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergradute();
        }
    }

    internal class AolunteerLeiFeng : ILeiFengFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }

}
