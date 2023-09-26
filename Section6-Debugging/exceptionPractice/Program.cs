string[] names = {"Dog", "Cat", "Elephant"};
Object[] obj = (Object[]names);

Object obj = (Object)13;
obj[2] = obj; // ArrayTypeMismatchException occurs

int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); //DivideByZeroException occurs

int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs

int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];
values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

object obj = "This is a string";
int num = (int)obj; //InvalidCastException occurs

int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;
string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());//NullReferenceException occurs

decimal x = 400;
byte i;
i = (byte)x; // OverflowException occurs
Console.WriteLine(i);