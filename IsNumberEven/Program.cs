// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input an integer positive number");
UInt64.TryParse(Console.ReadLine(), out ulong ulNumber);
if (ulNumber % 2 == 0)
    Console.WriteLine("The number is even");
else
    Console.WriteLine("The number is odd");
Console.ReadLine();