string permission = "Manager";
int level = 16;

// first solution:
// if ((level > 55) && permission.Contains("Admin"))
//     Console.WriteLine("Welcome, Super Admin user.");
// else if ((level <= 55) && permission.Contains("Admin"))
//     Console.WriteLine("Welcome, Admin user.");
// else if ((level >= 20) && permission.Contains("Manager"))
//     Console.WriteLine("Contact an Admin for access.");
// else 
//     Console.WriteLine("You do not have sufficient privilages.");

// restructured solution:
if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else 
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level >= 20) 
{
    Console.WriteLine("Contact Admin for access");
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


