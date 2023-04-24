int first = 2;
string second = "4";

// int result = first + second; erro não aceita int + string

string result = first + second;


Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"FLoat: {myFloat}");

int firstInt = 5;
int secondInt = 7;
string message = firstInt.ToString() + secondInt.ToString();
Console.WriteLine(message);

string firstString = "5";
string secondeString = "7"; 
int sum = int.Parse(firstString) + int.Parse(secondeString);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int resultConvert = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(resultConvert);

int value = (int)1.5m;
Console.WriteLine(value);

int cValue2 = Convert.ToInt32(1.5m);
Console.WriteLine(cValue2);



// Erro 
// Console.WriteLine(int.Parse(name));

string valueString = "102";
int resultInt = 0;

if (int.TryParse(valueString, out resultInt))
{
    Console.WriteLine($"Measurement: {resultInt}");
}
else
{
    Console.WriteLine("Unable to report the measure");
}

string valueString1 = "0102";
int resultInt1 = 0;

if (int.TryParse(valueString1, out resultInt1))
{
    Console.WriteLine($"Measurement: {resultInt1}"); 
    Console.WriteLine($"Somando: {resultInt1 + resultInt1}");
    
}
else
{
    Console.WriteLine("Unable to report the measure");
    
}

Console.WriteLine($"Measurement (w/ offset): {50 + resultInt}");




string[] values = {"12.3", "45", "ABC", "11", "DEF"};
float sumItem;
float somar = 0 ;
string sumString = "";

foreach (var item in values)
{
   
//if (int.TryParse(valueString1, out resultInt1))
    if (Single.TryParse(item, out  sumItem))
    {
        Console.WriteLine($"este e o item {item} este e o sum {sumItem}");
        somar = sumItem + somar;
    }
    else
    {
        sumString = sumString + item;
    }
}


Console.WriteLine(somar);
Console.WriteLine(sumString);

//Solução apresentada

decimal total = 0m;
string messageString = "";

foreach (var a in values)
{
    decimal number;
    if (decimal.TryParse(a, out number))
    {
        total += number;
    } else
    {
        messageString += a;
    }
}

Console.WriteLine($"Message: {messageString}");
Console.WriteLine($"Total: {total}");