Console.WriteLine("bem Vindo");
string? name = Console.ReadLine();
Console.WriteLine(name);

string?[] arr = {"a", "b", "c"};


for (int i = 0; i < 3; i++)
{
    arr[i] = Console.ReadLine();
  
}

for (int i = 0; i < 3; i++)
{
    
    Console.WriteLine(arr[i]);
}



Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");