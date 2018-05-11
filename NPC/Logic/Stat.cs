using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPC.Logic
{
    public interface IStat
    {
        int total { get; set; }
        double modifier { get; }
        statType type { get; set; }
        int randomizeStat(Random r);
    }

    public enum statType
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }


    public class Stat : IStat
    {
        public List<statType> all = Enum.GetValues(typeof(statType)).Cast<statType>().ToList();
        public statType type { get; set; }
        public int total { get; set; }
        public double modifier
        {
            get
            { return (total - 10 > 0 ? Math.Floor(((double)total - 10) / 2) : Math.Ceiling(((double)total - 10) / 2)); }
        }


        public Stat()
        {

        }



        public int randomizeStat(Random r)
        {
            int total = r.Next(10, 16);
            return total;
        }

        public List<int> randomizeStats(Random r, int length)
        {
            List<int> statList = new List<int>();
            for (int i = 0; i < length; i++)
            {
                statList.Add(r.Next(8, 16));
            }

            return statList;
        }

        public List<IStat> AssignStats(List<int> stats, List<statType> all, List<statType> priorities)
        {
            List<IStat> output = new List<IStat>();
            stats.Sort();
            stats.Reverse();
            while (priorities.Count() > 0)
            {
                IStat newStat = new Stat
                {
                    total = stats[0],
                    type = priorities[0]
                };
                output.Add(newStat);
                all.RemoveAt(all.FindIndex(s => s.Equals(priorities[0])));
                stats.RemoveAt(0);
                priorities.RemoveAt(0);
            }

            while (all.Count > 0)
            {
                IStat newStat = new Stat
                {
                    total = stats[0],
                    type = all[0]
                };
                output.Add(newStat);
                all.RemoveAt(0);
                stats.RemoveAt(0);
            }

            return output;
        }
    }
}
