// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// output:
// World Hello!
// Hello Hello Hello!

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// output:
// Price: $123.45 (Save $50.00)

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// output:
// Measurement: 123,456.79 units

//more precision
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// output:
// Measurement: 123,456.7891 units

//percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// output:
// Tax rate: 36.79%

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// Console.WriteLine(yourDiscount);

// output:
// You saved $7.56 off the regular $67.55 price.

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);