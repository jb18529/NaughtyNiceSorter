using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace NaughtyNiceSorter
{

    public class NiceSpartan1
    {
        // These are properties that look like public data but they're actually public methods
        // which access some private data hidden behind the scenes. So you can decide not to make setter
        // public so its read only, can only get the name. You can also customize the code so the get can return
        // a little computation. i.e. public string Name { get; private set;}
        public string Name { get; set; }
        public string Location { get; set; }
        public string Present { get; set; }

        public NiceSpartan1(string name, string location, string present )
        {
            this.Name = name;
            this.Location = location;
            this.Present = present;
            
        }

        // <modifiers> is private or public <return-type> <method-name> <parameter-list>
        // override creates a new version of a ToString() method that exists for every object
        public override string ToString() // string is the return type
        {
            return $"Name: {Name}, Location: {Location} is getting {Present}";
        }
    }
}
