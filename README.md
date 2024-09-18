Short Project as part of C# workshop to create a .NET console application.

Workshop involved implementing OOP principles with classes, abstraction, encapsulation, polymorphism and inheritance.

The application takes an input of SantasSpartanList.csv containing a list of names with their Name, Location, true or false for cleaned room, polite, and practiced programming.

The Program.cs file reads the file storing csv data in a string array, loops through the array picking out the nice people from the naughty people. The nice people are inputted into NiceSpartan class located in the NiceSpartan.cs file which assigns them a random present out of a list of presents while the naughty people are inputted into the NaughtySpartan class which is assigns them a random number of charcoal as their present and is located in the NaughtySpartan.cs files.

An abstract class is defined in Spartan.cs which is the base class for the NiceSpartan and NaughtySpartan classes.

Each of the nice and naughty people are allocated into separate lists containing elements of the NiceSpartan and NaughtySpartan. 
They are finally written and stored in separate csv files which contain the name, location and present for each person.