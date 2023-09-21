using System;

// ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";
string suggestedDonation = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
decimal decimalDonation = 0.00m;

// array used to store runtime data
string[,] ourAnimals = new string[maxPets, 7];

// sample data ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 45 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            suggestedDonation = "85.00";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "gus";
            suggestedDonation = "49.99";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "snow";
            suggestedDonation = "40.00";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "lion";
            suggestedDonation = "";

            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            suggestedDonation = "";
            break;

    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;

    if (!decimal.TryParse(suggestedDonation, out decimalDonation))
    {
        decimalDonation = 45.00m; // if suggestedDonation NOT a number, default to 45.00
    }
    ourAnimals[i, 6] = $"Suggested Donation: {decimalDonation:C2}";
}

// top-level menu options
do
{
    // NOTE: the Console.Clear method is throwing an exception in debug sessions
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // switch-case to process the selected menu option
    switch (menuSelection)
    {
        case "1":
            // list all pet info
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j].ToString());
                    }
                }
            }

            Console.WriteLine("\r\nPress the Enter key to continue");
            readResult = Console.ReadLine();

            break;

        case "2":
        //define dogchar string, which will hold multiple charaterisitics !
        //create a while loop that checks if dogchars is empty !
        //while its empty you need this: !
        // Console.WriteLine($"\nEnter dog characteristics to search for separated by commas"); !
        // readResult = Console.ReadLine(); !
        // to read the input !
        // if the read result is not null then !
        // dogchars is equal to the read result but lowercase version !
        // then console writeline for empty line!
        // end if and while!

        //declare dogInput string  set it equal to dogchars split by comma !

        //for loop to trim each item in the array !

        // sort dog input array !

        //define icon array !
        //string[] icons = {" |", " /", "--", " \\", " *"}; !

        // set matched a dog to false !
        // define dog desc string !

        //start a large for loop that goes thru our animals array, with maxPets as length condition !
        // within the for loop there is an if statement that checks if the i-th row and second (index 1) column contains "dog"!
        // within the if statement we need to set dogdesc to our animals i-th row and 5th column (index 4) + "\n" + our animals i-th row 6th column (index 5)!
        // define bool currentMatch equals false

        // start a foreach that goes through each word in input array!
        // within the foreach make an if statement that checks if word is not null and word trimmed is not empty string!
        // within the if statement create a for loop with j instead of i since we are already inside a for loop that uses i 
        // this for loop starts at index 2 and j is greater than -1 , j--
        // #5 update "searching" message to show countdown by creating a foreach! 
        // string icon in icons!
        // within the foreach loop !
        // Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {term.Trim()} {icon} {j.ToString()}");
        // Thread.Sleep(100);!
        // end foreach!
        // Console.Write($"\r{new String(' ', Console.BufferWidth)}");!
        //end j for loop!

        // start if statement that iterates submitted characteristic terms and search description for each term!
        // if the dog desc contains " " + word.Trim() + " "
        // then 
        // Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {term.Trim()}");

        // matchesCurrentDog = true;!
        // matchesAnyDog = true;!
        //end if statement!
        //end larger if statement!
        // end foreach loop!

        //check if matches current dog is true
        // then Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
        // end if!
        // end larger if!
        // end for loop with max pets restriction!

        //lastly if matches any dog is not true
        // write none of our dogs are a match for + dog chars
        // end if

        string dogCharacteristics = "";

        while (dogCharacteristics is "")
        {
            Console.WriteLine($"\nEnter dog characteristics to search for separated by commas");
            readResult = Console.ReadLine();

            if (readResult is not null)
            {
                dogCharacteristics = readResult.ToLower();
                Console.WriteLine();
            }
        }

        string[] dogInputArray = dogCharacteristics.Split(",");

        for (int i = 0; i < dogInputArray.Length; i++)
        {
            dogInputArray[i] = dogInputArray[i].Trim();
        }

        Array.Sort(dogInputArray);

        string[] icons = {" |", " /", "--", " \\", " *"}; // define icon array used for loading animation

        bool matchADog = false;
        string dogDescription = "";

        for (int i = 0; i < maxPets; i++)
        {
            if (ourAnimals[i, 1].Contains("dog"))
            {
                dogDescription = ourAnimals[i, 4] + "\n" + ourAnimals[i, 5];
                bool currentMatch = false;

                foreach (string word in dogInputArray)
                {
                    if (word is not null && word.Trim() is not "")
                    {
                        for (int j = 2; j > -1; j--)
                        {
                            foreach (string icon in icons)
                            {
                                Console.Write($"\rsearching our dog {ourAnimals[i, 3]} for {word.Trim()} {icon} {j.ToString()}");
                                Thread.Sleep(100);
                            }
                            Console.Write($"\r{new String(' ', Console.BufferWidth)}");
                        }

                        if (dogDescription.Contains(" " + word.Trim() + " "))
                        {
                            Console.WriteLine($"\rOur dog {ourAnimals[i, 3]} matches your search for {word.Trim()}");
                            currentMatch = true;
                            matchADog = true;
                        }
                    }
                }

                if (currentMatch)
                {
                    Console.WriteLine($"\r{ourAnimals[i, 3]} ({ourAnimals[i, 0]})\n{dogDescription}\n");
                }
            }
        }

        if (!matchADog)
        {
            Console.Write($"None of our dogs are a match for: {dogCharacteristics}");
        }


        Console.WriteLine("\n\rPress the Enter key to continue");
        readResult = Console.ReadLine();

        break;

    default:
        break;

    }

} while (menuSelection != "exit");
