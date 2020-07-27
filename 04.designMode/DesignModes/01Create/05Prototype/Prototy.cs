/*
*┌────────────────────────────────────────────────┐
*│　描   述：Prototy                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 14:16:59                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._01Create._05Prototype
{
   internal abstract class Prototy
    {
        public int Id { get; set; }

        public string Name { get; set; }

        protected Prototy(int id, string name)
        {
            Id = id;
            Name = name;
        } 
        public abstract Prototy Clone();
    }

    internal class ConcretePrototy1 : Prototy
    {
        public ConcretePrototy1(int id, string name) : base(id, name) { }

        public override Prototy Clone()
        {
            return (Prototy)MemberwiseClone();
        }
    }

}
