// In the code that you start with, there are two unavailable methods referenced:

// ShouldPlay: This method should retrieve user input and determine 
// if the user wants to play again WinOrLose: This method should determine 
// if the player has won or lost

// There are also two uninitialized variables:

// target: The random target number between 1 and 5 roll: The result of a 
// random six-sided die roll

// Your challenge is to create the ShouldPlay and WinOrLose methods, and 
// create methods that set target and roll to random values in the correct range. 
// When all the methods are complete, the game should run successfully.
int roll;
int target;

Random random = new Random();
string? readResult;

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        target = random.Next(1, 6);
        roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");
        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    readResult = Console.ReadLine();

    if (readResult is "Y" || readResult is "y")
        return true;
    else
        return false;
}

string WinOrLose()
{
    if (roll > target)
        return "You win!";
    else 
        return "You lose!";
}
