using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaughtyNiceSorter
{
    public class NaughtySpartan : Spartan
    {
        public NaughtySpartan(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }
        public override void DecidePresents()
        {
            Present = $"{rnd.Next(1,4)} pieces of coal";
        }
    }
}