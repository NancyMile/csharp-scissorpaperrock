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

    Winner(machineChoice,yourChoice);
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

void Winner(char machineChoice, char yourChoice)
{
    if (machineChoice == yourChoice)
    {
        Console.WriteLine("Tie!");
        return;
    }

    switch (yourChoice)
    {
        case 'r':
        case 'R':
            if(machineChoice == 'p')
                Console.WriteLine("Paper beats rock. Machine Won");
            else if(machineChoice == 's')
                Console.WriteLine("Rock beats scissors. You won");
            break;
        case 's':
        case 'S':
            if(machineChoice == 'p')
                Console.WriteLine("Scissors beats paper. You Won");
            else if(machineChoice == 'r')
                Console.WriteLine("Rock beats scissors. Machine won");
            break;
        case 'p':
        case 'P':
            if(machineChoice == 's')
                Console.WriteLine("Scissors beats paper. Machine Won");
            else if(machineChoice == 'r')
                Console.WriteLine("Paper beats rock. You won");
            break;
        default:
            break;
    }
}