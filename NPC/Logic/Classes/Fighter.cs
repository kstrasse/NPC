using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPC.Logic;
using NPC.Models;

namespace NPC.Logic.Classes
{
    public class Fighter : ICharacterClass
    {
        public BabType babType { get; set; }

        public int bab { get; set; }
        public ICharacter character { get; set; }
        public List<string> classSkills { get; set; }
        public List<statType> prioritizedStats { get; set; }


        public int classLevels { get; set; }

        public Fighter(int classLevels)
        {
            this.prioritizedStats = new List<statType>() { statType.Strength, statType.Constitution, statType.Dexterity };
            this.classLevels = classLevels;
            this.babType = BabType.Full;
            this.classSkills = new List<string>() { "Athletics" };
        }


    }
}
