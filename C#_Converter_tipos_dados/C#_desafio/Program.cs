string[] values = { "12.w3", "45", "ABC", "11", "DEF" };


decimal total = 0m;
string message = "";


foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        Console.WriteLine($"Message: {value}");

        Console.WriteLine($"Message: {number}");
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

/*
int a = 123;
Console.WriteLine(a);

float b = 1.23f;
Console.WriteLine(b);

double c = 2.32;
Console.WriteLine(c);

int[] number = {1,2,3,4};

for(int i= 0 ; i < number.Length; i++)
{
    Console.WriteLine(number[i]);
}


double[] floatNumber = {1.23, 4.123, 2.41};

for(int ifloat= 0 ; ifloat < floatNumber.Length; ifloat++)
{
    Console.WriteLine(floatNumber[ifloat]);
}

double teste = 1.234;

Console.WriteLine(teste);

*/
//Desafio 2

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;


int result1 = Convert.ToInt32((decimal)value1/value2);


// Your code here to set result1
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal) value3;

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


float result3 = value3 / value1;
// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");