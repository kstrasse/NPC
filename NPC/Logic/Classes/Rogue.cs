using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPC.Models;

namespace NPC.Logic.Classes
{

    public class Rogue : FifthEdCharacterClass, ICharacterClass
    {
        public BabType babType { get; set; }
        public ICharacter character { get; set; }
        public List<string> classSkills { get; set; }
        public List<statType> prioritizedStats { get; set; }


        public override int classLevel { get; set; }

        public Rogue(int classLevels)
        {
            this.prioritizedStats = new List<statType>() { statType.Dexterity, statType.Constitution, statType.Intelligence };
            this.classLevel = classLevels;
            this.babType = BabType.Full;
            this.classSkills = new List<string>() { "Acrobatics" };
        }
    }
}
