// Conditions: 
// Your solution must declare an integer variable named periodLocation that can be used 
// to hold the location of the period character within a string.

// Your solution must include an outer foreach or for loop that can be used to process 
// each string element in the array. The string variable that you'll process inside the 
// loops should be named myString.

// In the outer loop, your solution must use the IndexOf() method of the String class to 
// get the location of the first period character in the myString variable. The method call 
// should be similar to: myString.IndexOf("."). If there's no period character in the string, 
// a value of -1 will be returned.

// Your solution must include an inner do-while or while loop that can be used to process the 
// myString variable.

// In the inner loop, your solution must extract and display (write to the console) each 
// sentence that is contained in each of the strings that are processed.

// In the inner loop, your solution must not display the period character.

// In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods 
// to process the string information.

/* expected output:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices */

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;
string splitString = "";
string finalSentence = "";

for (int i = 0; i < myStrings.Length; i++)    // foreach or for loop
{
    splitString = myStrings[i];
    periodLocation = splitString.IndexOf(".");
    // index of method, of string class to get period myString.IndexOf(".");

    while (periodLocation != -1) 
    {
        finalSentence = splitString.Remove(periodLocation);
        splitString = splitString.Substring(periodLocation + 1);
        splitString = splitString.TrimStart();
        periodLocation = splitString.IndexOf(".");
        Console.WriteLine(finalSentence);
        // process myString variable
        // must extract and display each sentence that is contained in each string
        // do not display period
        // must use Remove() Substring() and TrimStart()
    }

    finalSentence = splitString.Trim();
    Console.WriteLine(finalSentence);
}

