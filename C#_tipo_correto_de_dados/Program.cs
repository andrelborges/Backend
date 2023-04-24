//Tipo de dado integral EX. int

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Floating point types:");
Console.WriteLine($"float : {float.MinValue} to {float.MinValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MinValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MinValue} (with 28-29 digits of precision)");

//int[] data;
//data = new int[3];

int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

var hora = new DateTime();
Console.WriteLine(hora);

DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;
DateTime date3 = DateTime.Today;

Console.WriteLine(date1);
Console.WriteLine(date2);
Console.WriteLine(date3);


