// Random rand = new Random();
// string[] coinflip = new string[] { "heads", "tails" };
// int result = rand.Next(0, coinflip.Length);

// Console.WriteLine(coinflip[result]);

// with conditional operator:

Random rand = new Random();
int coinflip = rand.Next(0, 1);
Console.WriteLine(coinflip == 0 ? "heads" : "tails");