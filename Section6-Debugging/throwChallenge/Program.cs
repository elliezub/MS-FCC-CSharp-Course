// string[][] userEnteredValues = new string[][]
// {
//             new string[] { "1", "2", "3"},
//             new string[] { "1", "two", "3"},
//             new string[] { "0", "1", "2"}
// };

// string overallStatusMessage = "";

// overallStatusMessage = Workflow1(userEnteredValues);

// if (overallStatusMessage == "operating procedure complete")
// {
//     Console.WriteLine("'Workflow1' completed successfully.");
// }
// else
// {
//     Console.WriteLine("An error occurred during 'Workflow1'.");
//     Console.WriteLine(overallStatusMessage);
// }

// static string Workflow1(string[][] userEnteredValues)
// {
//     string operationStatusMessage = "good";
//     string processStatusMessage = "";

//     foreach (string[] userEntries in userEnteredValues)
//     {
//         processStatusMessage = Process1(userEntries);

//         if (processStatusMessage == "process complete")
//         {
//             Console.WriteLine("'Process1' completed successfully.");
//             Console.WriteLine();
//         }
//         else
//         {
//             Console.WriteLine("'Process1' encountered an issue, process aborted.");
//             Console.WriteLine(processStatusMessage);
//             Console.WriteLine();
//             operationStatusMessage = processStatusMessage;
//         }
//     }

//     if (operationStatusMessage == "good")
//     {
//         operationStatusMessage = "operating procedure complete";
//     }

//     return operationStatusMessage;
// }

// static string Process1(String[] userEntries)
// {
//     string processStatus = "clean";
//     string returnMessage = "";
//     int valueEntered;

//     foreach (string userValue in userEntries)
//     {
//         bool integerFormat = int.TryParse(userValue, out valueEntered);

//         if (integerFormat == true)
//         {
//             if (valueEntered != 0)
//             {
//                 checked
//                 {
//                     int calculatedValue = 4 / valueEntered;
//                 }
//             }
//             else
//             {
//                 returnMessage = "Invalid data. User input values must be non-zero values.";
//                 processStatus = "error";
//             }
//         }
//         else
//         {
//             returnMessage = "Invalid data. User input values must be valid integers.";
//             processStatus = "error";
//         }
//     }

//     if (processStatus == "clean")
//     {
//         returnMessage = "process complete";
//     }

//     return returnMessage;
// }

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

// string overallStatusMessage = "";

// overallStatusMessage = Workflow1(userEnteredValues);

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    // string operationStatusMessage = "good";
    // string processStatusMessage = "";

    foreach (string[] userEntries in userEnteredValues)
    {
        // processStatusMessage = Process1(userEntries);

        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }

    // return operationStatusMessage;
}

static void Process1(String[] userEntries)
{
    // string processStatus = "clean";
    // string returnMessage = "";
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }

        // return returnMessage;
    }
}