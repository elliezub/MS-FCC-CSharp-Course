string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string letters = "";
decimal sum = 0;
decimal result = 0;

for (int i = 0; i < values.Length; i ++)
{
    if (decimal.TryParse(values[i], out result))
        sum += result;
    else 
        letters += values[i];
}   

Console.WriteLine($"Message: {letters}");
Console.WriteLine($"Total: {sum}");
