using System;

Console.Title = "Dungeon with only two floors?";

Console.WriteLine("You enter the Dungeon and are met with two choices, Left or Right, Where do you go?");

 string Go = Console.ReadLine();

Go = Go.ToLower();



if (Go == "right")
{
    Console.WriteLine("You walk towards the Right Hallway.");

    
}


else if (Go == "left")
{
    Console.WriteLine("You walk towards the Left Hallway.");

    
}




Console.ReadLine();





