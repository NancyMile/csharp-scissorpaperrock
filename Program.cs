using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock, Paper, Scissors");

while(true)
{
    Console.WriteLine("Welcome");
    var selectedChoice = SelectedChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You have Selected {yourChoice} ");
}

string SelectedChoice(){
    Console.WriteLine("Please enter P,R,S");
    var selectedChoice = Console.ReadLine();

    if(selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please enter P,R,S");
        selectedChoice = SelectedChoice();
    }

    return selectedChoice;
}

