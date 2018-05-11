using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPC.Logic.Classes;

namespace NPC.Models
{
    public class FifthEdCharacter : Character
    {
        public int ProficiencyBonus
        {
            get
            {
                return (int)(level < 4 ? (level % 4) + 1 : Math.Ceiling((double)level / 4) + 1);
            }

        }



        public FifthEdCharacter(int level)
            :base()
        {
            this.level = level;
        }
    }
}
