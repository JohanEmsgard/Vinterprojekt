using System;
using System.Collections.Generic;
using Raylib_cs;


Console.WriteLine("Hello and Welcome the world of Pokemon, a place where both humans and mythical creatures can come togethor. This is the Tunod region. One of the many places in the pokemon world.");
Console.ReadLine();


string gender = "";

while (gender != "Boy" && gender != "Girl" && gender != "boy" && gender != "girl")
{
    Console.WriteLine("Are you a boy or a girl?");
    gender = Console.ReadLine();
}



Console.WriteLine("Let's Begin with your name, what is it?");
string name = Console.ReadLine();    

string[] names = {"Jason", "Chase"};
Random generator2 = new Random();


if (name == "")
{
    int i = generator2.Next(names.Length);
    name = names[i];
}

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

int hpC = 100;
int hpT = 100;
int hpP = 100;

string[] attackC = { "Scratch", "Leer", "Ember" };
// Random generator = new Random();
string[] attackP = {"Pound", "Growl", "Bubble"};

string[]attackT = {"Tackle", "Growl", "Obsorb"};

Console.ReadLine();

while(hpC > 0 && hpT > 0 && hpP > 0)
{

if (starter == "Turtwig")
{
    int t = generator.Next(attackT.Length);
    Console.WriteLine($"Turtwig used {attackT[0]}");
    hpC -= 10;
    Console.ReadLine();
    

    int c = generator.Next(attackC.Length);
    Console.WriteLine($"Enemy Chimchar used {attackC[0]}");
    hpT -= 10;
    Console.ReadLine();
    
}

else if (starter == "Chimchar")
{
    int c = generator.Next(attackC.Length);
    Console.WriteLine($"Chimchar used {attackC[0]}");
    hpP -= 10;
    Console.ReadLine();
    

    int p = generator.Next(attackP.Length);
    Console.WriteLine($"Enemy Piplup used {attackC[0]}");
    hpC -= 10;
    Console.ReadLine();
    

}

else if (starter == "Piplup")
{
    int p = generator.Next(attackP.Length);
    Console.WriteLine($"Piplup used {attackC[0]}");
    hpT -= 10;
    Console.ReadLine();
    
    int t = generator.Next(attackT.Length);
    Console.WriteLine($"Enemy Turtwig used {attackT[0]}");
    hpP -=10;
    Console.ReadLine(); 
    
}

}

if (hpC >= 0)
{
    Console.WriteLine("Chimchar fainted");
    Console.ReadLine();
    Console.WriteLine("Piplup Wins");
    Console.ReadLine(); 
}

else if (hpP >= 0)
{
    Console.WriteLine("Piplup fainted");
    Console.ReadLine();
    Console.WriteLine("Turtwig Wins");
    Console.ReadLine();
}

else if (hpT >= 0)
{
    Console.WriteLine("Turtwig fainted");
    Console.ReadLine();
    Console.WriteLine("Chimchar Wins");
    Console.ReadLine();
}


Console.ReadLine();

