string pangram = "The quick brown fox jumps over the lazy dog";

string[] wordArray = pangram.Split(" ");
// wordArray = {"The", "quick", "brown", "fox", "jumps", ...}
for (int i = 0; i < wordArray.Length; i++) 
{
    char[] letterArray = wordArray[i].ToCharArray();
    Array.Reverse(letterArray);
    wordArray[i] = string.Join("", letterArray);
}
pangram = string.Join(" ", wordArray);
Console.WriteLine(pangram);


