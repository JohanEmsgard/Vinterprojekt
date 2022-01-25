using System;


Console.WriteLine("Hello and Welcome the world of Pokemon, a place where both humans and mythical creatures can come togethor. This is the Tunod region. One of the many places in the pokemon world.");
Console.ReadLine();


string gender = "";

while (gender != "Boy" && gender != "Girl")
{
    Console.WriteLine("Are you a boy or a girl?");
    gender = Console.ReadLine();
}

Console.WriteLine("Let's Begin with your name, what is it?");
string name = Console.ReadLine();

Console.WriteLine($"Ok so your name is {name}");
Console.ReadLine();

Console.WriteLine("This is my nephew. You guys have known eachother since you were both babies");
Console.WriteLine("Umm what was his name again?");
string rival = Console.ReadLine();

string[] rivals = { "Casey", "Ethan" };
Random generator = new Random();

if (rival == "")
{
    int i = generator.Next(rivals.Length);
    rival = rivals[i];
}


Console.WriteLine($"Ahh I remember now his name was {rival}");
Console.ReadLine();

string starter = "";

while (starter != "Chimchar" && starter != "Turtwig" && starter != "Piplup")
{
    Console.WriteLine("Pick your Starter Pokemon");
    Console.WriteLine("Chimchar");
    Console.WriteLine("Turtwig");
    Console.WriteLine("Piplup");
    starter = Console.ReadLine();
}

if (starter == "Chimchar")



    Console.ReadLine();

