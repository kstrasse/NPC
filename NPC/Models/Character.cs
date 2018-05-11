using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPC.Logic;
using NPC.Logic.Classes;

namespace NPC.Models
{
    public interface ICharacter
    {
        int level { get; set; }
        ICharacterClass characterClass { get; set; }
        IStat Strength { get;  }
        IStat Dexterity { get;  }
        IStat Constitution { get; }
        IStat Intelligence { get; }
        IStat Wisdom { get;}
        IStat Charisma { get;}
        List<IStat> stats { get;}
    }

    public class Character : ICharacter
    {
        public ClassTypes selectedClassType { get; set; }
        public static ClassTypes classes { get; set; }
        Random r = new Random();
        public string name { get; set; }
        public int level { get; set; }
        public ICharacterClass characterClass { get; set; }
        public IStat Strength { get; set; }
        public IStat Dexterity { get; protected set; }
        public IStat Constitution { get; protected set; }
        public IStat Intelligence { get; protected set; }
        public IStat Charisma { get; protected set; }
        public IStat Wisdom { get; protected set; }
        public List<statType> prioritizedStats { get; set; }
        public List<IStat> stats { get; set; }
        private List<int> statNumbers { get; set; }
        private Stat stat { get; set; }
        public BabType Bab { get; set; }

        public Character()
        {
        }

        private IStat getStatTotal(statType type)
        {
            return stats.First(l => l.type.Equals(type));
        }

        public void generate(ClassTypes type, int level = 1)
        {
            switch (type)
            {
                case ClassTypes.Fighter:
                    this.characterClass = new Fighter(level);
                    break;
                case ClassTypes.Rogue:
                    this.characterClass = new Rogue(level);
                    break;
                default:
                    throw new Exception("Cannot find the passed in class");
            }
            this.stat = new Stat();
            this.statNumbers = stat.randomizeStats(r, 6);
            this.stats = stat.AssignStats(this.statNumbers, stat.all, characterClass.prioritizedStats);
            this.Bab = characterClass.babType;

            Strength = getStatTotal(statType.Strength);
            Dexterity = getStatTotal(statType.Dexterity);
            Constitution = getStatTotal(statType.Constitution);
            Intelligence = getStatTotal(statType.Intelligence);
            Wisdom = getStatTotal(statType.Wisdom);
            Charisma = getStatTotal(statType.Charisma);
        }

    }
}
