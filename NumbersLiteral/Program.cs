// Example file for LinkedIn Learning Course Advanced C#: Language Features by Joe Marini

// TODO: Starting in C# 7, you can use _ as a number separator
int d = 123_456;
float f = 12_34.5f;
var x = 0x_ABCD_EF;
var b = 0b1101_111010010_010;

Console.WriteLine($"{d}");
Console.WriteLine($"{f}");
Console.WriteLine($"{b:X}");
Console.WriteLine($"{x:X}");

