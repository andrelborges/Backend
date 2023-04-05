/*bool flag = true;
int value = 0;

if (flag)
 {
    value = 10;
    Console.WriteLine("Inside of code block: " + value );
 }

 Console.WriteLine("Outside of code block: " + value);
*/

/*
using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }

 
}

*/

bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}

bool flag1 = true;
if (flag1)
    Console.WriteLine(flag1);

bool flag3 = true;
if (flag3) Console.WriteLine(flag3);

string name = "steve";
if (name =="bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

string name1 = "steve";

if (name1 == "bob")
    Console.WriteLine("Found Bob");
else if (name1 == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

bool found = false;
int total = 0;
int[] numbers = {4, 8, 15, 16, 23, 42 };
foreach (int number in numbers)
{
    
    total += number;
    if (number == 42)
    {
        found = true;
    }

}
if (found)
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");

/*
    Solução apresentada

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

string firstName = "Andre";
string lastName = "Borges";

if (firstName == "Andre" && lastName == "Borges")
{
    Console.WriteLine(value: "Hello Professor");
}
else if (firstName == "Andre")
{
    Console.WriteLine(value: "Nice to meet another Andre");
}

else if (lastName == "Borges")
{
    Console.WriteLine(value: "Are you related?");
}
else
{
    Console.WriteLine(value: "Hello other person");
}

if (firstName == "Andre" && lastName == "Borges")
{
    Console.WriteLine(value: "Hello Professor1");
}
if (firstName == "Andre")
{
    Console.WriteLine(value: "Nice to meet another Andre");
}

if (lastName == "Borges")
{
    Console.WriteLine(value: "Are you related?");
}
else
{
    Console.WriteLine(value: "Hello other person");
}

if (firstName == "andre" || lastName == "Borges")
{
    Console.WriteLine("Teste do ||");
}

