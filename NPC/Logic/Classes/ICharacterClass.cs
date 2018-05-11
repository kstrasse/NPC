using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPC.Logic;

namespace NPC.Logic.Classes
{
    public enum ClassTypes
    {
        Fighter,
        Rogue
    }

    public enum BabType
    {
        Full,
        TwoThirds,
        OneThird
    }

    public interface ICharacterClass
    {
        BabType babType { get; set; }
        List<string> classSkills { get; set; }
        List<statType> prioritizedStats { get; set; }
    }
}
