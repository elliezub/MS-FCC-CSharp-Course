const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Set the quantity variable to the value by extracting the text from between the <span> and </span> tags.
quantity = "Quantity: ";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openSpanPosition = input.IndexOf(openSpan);
int closeSpanPosition = input.IndexOf(closeSpan);

openSpanPosition += openSpan.Length;
int length = closeSpanPosition - openSpanPosition;
quantity += input.Substring(openSpanPosition, length);
// Set the output variable to the value of input, then remove the <div> and </div> tags.
output = "Output: ";

const string openDiv = "<div>";
const string closeDiv = "</div>";

string codeSnippet = input.Replace(openDiv, "");
codeSnippet = codeSnippet.Replace(closeDiv, "");
codeSnippet = codeSnippet.Replace("&trade;", "&reg;");

output += codeSnippet;

// Replace the HTML character ™ (&trade;) with ® (&reg) in the output variable.

Console.WriteLine(quantity);
Console.WriteLine(output);



// desired output:
// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>
