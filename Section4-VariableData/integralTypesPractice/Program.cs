// Console.WriteLine("Signed integral types:");
// Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3]; 
string shortenedString = "Hello World!";

// Value types can hold smaller values and are stored in the stack. 
// Reference types can hold large values, and a new instance of a reference type is created using the new operator. 
// Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
// Reference types include arrays, strings, and classes.

// When in doubt, stick with the basics
// While you've looked at several considerations, as you're getting started, 
// for simplicity's sake you should prefer a subset of basic data types, including:

// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value