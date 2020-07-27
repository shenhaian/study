/*
*┌────────────────────────────────────────────────┐
*│　描   述：Player                                                    
*│　作   者：sha                                              
*│　版   本：1.0                                              
*│　创建时间：2020/7/23 18:09:02                        
*└────────────────────────────────────────────────┘
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignModes._02Structure._01Adapter
{
   internal abstract class Player
    {
        public abstract void Attact();

        public abstract void Defend();
    }

    internal class Forwards : Player
    {
        public override void Attact()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }

    internal class Guards : Player
    {
        public override void Attact()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }

    internal class ForeignGuards
    { 
        
    }

    internal class Translator : Player
    {
        public override void Attact()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
