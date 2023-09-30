using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock, Paper, Scissors");
Console.WriteLine("Welcome");

while(true)
{
    var selectedChoice = SelectedChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You have Selected {yourChoice} ");

    var machineChoice = MachineChoice();

    Console.WriteLine($"Machine has chosen {machineChoice}");
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


char MachineChoice()
{
    char[] options = new char[] {'r','p','s'};

    Random random = new Random();
    int randomIndex = random.Next(0,options.Length);

    return options[randomIndex];
}