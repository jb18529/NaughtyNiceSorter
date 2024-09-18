using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaughtyNiceSorter
{
    public class NiceSpartan : Spartan
    {
        //private static Random rnd = new Random();
        private static List<string> presents = new List<string>
        {
            "Fortitude",
            "Charity",
            "Hope",
            "Faith"
        };
        // public string? means property can return string or null
        // These are properties that look like public data but they're actually public methods
        // which access some private data hidden behind the scenes. So you can decide not to make setter
        // public so its read only, can only get the name. You can also customize the code so the get can return
        // a little computation. i.e. public string Name { get; private set;}
        // public string Name {get; set;}
        // public string Location {get; set;}
        // public string Present {get; set;}

        //this is basically a constructor of the class
        public NiceSpartan(string name, string location)
        {
            this.Name = name;
            // can now say Name = name;
            this.Location = location;
        }
        // void means it doesn't return anything
        // A function is a type of subroutine that returns something
        // A procedure is a type of subroutine that doesn't return anything
        public override void DecidePresents() 
        {
            Present = $"{presents[rnd.Next(0,4)]}";
        }
        // ToString() is a method and we are overriding the parent version (default) and exist for every object in C#, so it's inherited
        // public override string ToString()
        // {
        //     return $"Name: {Name}, Location: {Location} is getting {Present}"; 
        //     // $ is like f string in python, is a string interpolator allowing you to call variables in string using {}

        
        // }
    }
}