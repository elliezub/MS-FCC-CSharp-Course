// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement 
// to prompt the user for an integer value between 5 and 10.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the input is a valid representation of an integer.
// If the integer value isn't between 5 and 10, your code must use a 
// Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
// Below (after) the iteration code block: your solution must use a 
// Console.WriteLine() statement to inform the user that their input value has been accepted.

// expected output:
// Enter an integer value between 5 and 10
// two
// Sorry, you entered an invalid number, please try again
// 2
// You entered 2. Please enter a number between 5 and 10.
// 7
// Your input value (7) has been accepted.

// example of taking user input:
// string val;
// Console.Write("Enter Integer: ");
// val = Console.ReadLine();
// int a = Convert.ToInt32(val);
// Console.WriteLine("Your input: {0}", a);

Console.WriteLine("Enter a integer value between 5 and 10:");
string val = "";
int number = 0;

do
{
    val = Console.ReadLine();

    if (int.TryParse(val, out number))
    {
        if (number > 5 && number < 10)
            Console.WriteLine($"Your value ({number}) has been accepted.");
        else
            Console.WriteLine("Please enter a new number between 5 and 10");
    }
    else
        Console.WriteLine("Thats not a valid number, try again.");
} while (number <= 5 || number >= 10);

