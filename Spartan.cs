namespace NaughtyNiceSorter
{
    // abstract class is one that can't be instantiated and is mean't to define a sort of
    // template for child/derived classes that requires methods to be defined in the child class
    public abstract class Spartan
    {
        protected static Random rnd = new Random();

        public string Name { get; set; }
        public string Location { get; set; }
        public string Present { get; set; }
        // abstract 
        public abstract void DecidePresents();
 
        public override string ToString()
        {
            return $"Name: {Name}, Location: {Location} is getting {Present}"; 

        }
    }
}