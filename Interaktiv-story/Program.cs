using System;

Console.Title = "Dungeon with only two paths.";

Console.WriteLine("You enter the Dungeon and are met with two choices, Left or Right, Where do you go?");

string Go = Console.ReadLine();
Go = Go.ToLower();



if (Go == "right")
{
    Console.WriteLine("You walk towards the Right Hallway.");

    Console.WriteLine($"It's a dead end with a decaying ominous altar in the center created by the Umbra Witches, there is some text. Read or Ignore?");

    string Do = Console.ReadLine();
    Do = Do.ToLower();

    if (Do == "read")
    {
        System.Console.WriteLine("You try reading the text, it is unintelligible. You lack the INT to comprehend. With nothing else to do you recall back. ");
        Console.ReadLine();

    }

    if (Do == "ignore")
    {
        System.Console.WriteLine("You decide to ignore the text and continue looking around, after finding nothing else of interest you decide to recall back. ");
        Console.ReadLine();



    }
    if (Do == "destroy")
    {
        System.Console.WriteLine("You destroy the Altar created by the Umbra church, the only thing left is a mysterious orb that was on the altar, take it? Yes or No.");

        string Did = Console.ReadLine();
        Did = Did.ToLower();

        if (Did == "yes")
        {
            System.Console.WriteLine("After picking it up you hear a voice in your head saying, 'Your class has been forcefully changed to Lumen Sage.' Then you are sent back.");
            Console.ReadLine();

        }


        else if (Did == "no")
        {
            System.Console.WriteLine("You find nothing else of interest and recall back.");
            Console.ReadLine();

        }


    }


}
















else if (Go == "left")
{
    Console.WriteLine("You walk towards the Left Hallway.");
    System.Console.WriteLine("It's a spacious room filled with flammable books stacked up to the ceiling, there is a rough path through the books in the middle, Enter or Leave?");

    string Walk = Console.ReadLine();
    Walk = Walk.ToLower();

    if (Walk == "enter")
    {
        System.Console.WriteLine("You mosey past the seemingly hundreds of books stacked up in tall towers, eventually reaching an open area with a poorly built chest. Open?");

        string Open = Console.ReadLine();

        if (Open == "open")
        {
            System.Console.WriteLine("It's a Mimic, you get eaten and die.");
            Console.ReadLine();
        }

        if (Open == "destroy")
        {
            System.Console.WriteLine("You destroy the chest making guts go everywhere, It was a Mimic! Lucky you decided to destroy it instead of opening it. You pick up the Mimic guts and recall back.");
            Console.ReadLine();



        }

        
        
    

    }
    

    if (Walk == "leave")
    {
        System.Console.WriteLine("You decide it's not worth the trouble and decide to leave, recalling back.");
        Console.ReadLine();


    }
    else if (Walk == "burn them")
    {
        System.Console.WriteLine("You decide to set fire to the books, instantly creating an inferno in the room burning you to death. Stupid.");
        Console.ReadLine();
    }









}




Console.ReadLine();





