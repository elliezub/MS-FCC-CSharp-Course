// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);


// Methods that add blank spaces for formatting purposes 
// (PadLeft(), PadRight())
// Methods that compare two strings or facilitate comparison 
// (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
// Methods that help you determine what's inside of a string, or even retrieve just a part of the string 
// (Contains(), StartsWith(), EndsWith(), Substring())
// Methods that change the content of the string by replacing, inserting, or removing parts 
// (Replace(), Insert(), Remove())
// Methods that turn a string into an array of strings or characters 
// (Split(), ToCharArray())

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));

//overloaded method
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));
//output:
// ----Pad this
// Pad this----

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

// output:
// 1234567890123456789012345678901234567890
// 769C  Mr. Stephen Ortega       $5,000.00