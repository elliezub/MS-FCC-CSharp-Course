// conditions: 
// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt 
// the user for one of three role names: Administrator, Manager, or User.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the value entered matches one of the three role options.
// Your solution should use the Trim() method on the input value to ignore leading and training 
// space characters.
// Your solution should use the ToLower() method on the input value to ignore case.
// If the value entered isn't a match for one of the role options, your code must use a 
// Console.WriteLine() statement to prompt the user for a valid entry.
// Below (after) the iteration code block: Your solution must use a Console.WriteLine() 
// statement to inform the user that their input value has been accepted.

// Expected output:

// Enter your role name (Administrator, Manager, or User)
// Admin
// The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
//    Administrator
// Your input value (Administrator) has been accepted.

Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
string? roleInput = "";

do
{
    roleInput = Console.ReadLine();
    if (roleInput == null) continue;

    string trimLowerInput = roleInput.Trim().ToLower();

    if (trimLowerInput == "administrator" || trimLowerInput == "manager" || trimLowerInput == "user")
    {
        break;
    }
    else 
    {
        Console.WriteLine($"The role name that you entered, ({roleInput}) is not valid. Enter your role name (Administrator, Manager, or User):");
    }
} while (true);

Console.WriteLine($"Your input value \"{roleInput}\" has been accepted.");
