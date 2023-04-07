/*

for (int i = 0; i< 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}

Console.WriteLine("\n");

//Variavel Local
for (int i = 0; i < 10; i +=3)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

*/

string[] names = {"Alex", "Eddie", "David", "Michael"};

for (int i = names.Length -1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("\n");

for (int i = 0 ; i < 4; i++)
{
    Console.WriteLine(names[i] + i);
    if (names[i] == "David") names[i] = "Sammy";
}

Console.WriteLine("\n");

foreach (var name in names)
{
    Console.WriteLine(name);
    
}

//FIzzBuzz

for (int i = 1; i <= 20; i++)
{
    //Console.WriteLine(i);
    if( i % 3 == 0 && i % 5 == 0 )
        {
            Console.WriteLine($"{i} - FizzBuzz");
        }
    else if (i % 3 == 0) 
        {
            Console.WriteLine($"{i} - Fizz");
        }
    else if (i % 5 == 0)
        {
            Console.WriteLine($"{i} - Buzz");
        } else 
        {
            Console.WriteLine(i);
        }
}