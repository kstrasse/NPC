using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPC.Logic.Classes
{
    public abstract class FifthEdCharacterClass
    {
       public abstract int classLevel { get; set; }
       protected int Bab { get
            {
                return (classLevel % 4) + 1;
            }
        }
    }
}
