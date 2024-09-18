using Microsoft.VisualBasic;
using NaughtyNiceSorter;

// Methods, Classes and namespaces are PascalCase
// Variables are camelCase
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Naughty Nice Sorter!");

var santasListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"SantasSpartanList.csv");

var santaList = File.ReadAllLines(santasListLocation).Skip(1);

// you declare the type of the var as: NiceSpartan class
var niceSpartans = new List<NiceSpartan>();

var naughtySpartans = new List<NaughtySpartan>();

var presents = new List<string>
{
    "Fortitude",
    "Charity",
    "Hope",
    "Faith"
};

foreach (var line in santaList) 
{
    // Parsing is for converting from a string to something, use it when you KNOW your input is a string
    // Casting is when you KNOW the cast is supposed to do something reasonable. So like floating-point types to integers
    // Convert is basically arbitrary type to arbitrary type so it uses parsing and converting and allowes you
    // to define your own conversions, so should be used sparingly as it can fail more easily than other more specific methods
    var details = line.Split(',');
    if (bool.Parse(details[2]) && bool.Parse(details[3]) && bool.Parse(details[4]))
    {
        // var rnd = new Random();
        // var present = presents[rnd.Next(0,4)];

        // old way: NiceSpartan niceSpartan = new NiceSpartan(details[0], details[1], present);
        // NiceSpartan niceSpartan = new(details[0], details[1], present);
        // niceSpartans.Add(niceSpartan);

        // ToString() method is called automatcally when object is called
        // Console.WriteLine(niceSpartan); // same as Console.WriteLine(niceSpartan.ToStrng());

        // Refactored Code
        NiceSpartan niceSpartan = new NiceSpartan(details[0], details[1]);
        niceSpartan.DecidePresents();
        niceSpartans.Add(niceSpartan);
    }
    else
    {
        NaughtySpartan naughtySpartan = new NaughtySpartan(details[0], details[1]);
        naughtySpartan.DecidePresents();
        naughtySpartans.Add(naughtySpartan);
    }
}

int niceSpartansCount = niceSpartans.Count();
int naughtySpartansCount = naughtySpartans.Count();
Console.WriteLine($"The number of Nice Spartans is: {niceSpartansCount}\n" +
                    $"The number of Naughty Spartans is {naughtySpartansCount}");

var niceListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"NiceList.csv");
File.WriteAllText(niceListLocation, "Name,Location,Present\n");
foreach(var niceSpartan in niceSpartans)
{
    var details = $"{niceSpartan.Name},{niceSpartan.Location},{niceSpartan.Present}\n";
    File.AppendAllText(niceListLocation, details);
}

var naughtyListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"NaughtyList.csv");
File.WriteAllText(naughtyListLocation, "Name,Location,Present\n");
foreach(var naughtySpartan in naughtySpartans)
{
    var details = $"{naughtySpartan.Name},{naughtySpartan.Location},{naughtySpartan.Present}\n";
    File.AppendAllText(naughtyListLocation, details);
}


// NiceSpartan joel = new NiceSpartan("Joel", "Bridgend", "JMJ");
// Console.WriteLine(joel.ToString());