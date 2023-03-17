int firstNumber = 12;
int secondNumber = 7;

Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

//Neste console log o compilador entende que deve concatenar os opeandos.
//Ele deduz devido os operando ser do tipo string e int.
//Convertendo temporariamente int widgetsSold em uma string.

Console.WriteLine(firstName + " sold " + widgetsSold + 7 +" widgets.");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7 )+ " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);

decimal decimalQuotient1 = 7 / 5.0m;
decimal decimalQuotient2 = 7.0m / 5.0m;

Console.WriteLine("Decimal quotient: " + decimalQuotient1);
Console.WriteLine("Decimal quotient: " + decimalQuotient2);


//Apresentaão erro em relação ao tipo de variavel
//int decimalQuotient3 = 7 / 5.0m;
//int decimalQuotient4 = 7.0m / 5;
//int decimalQuotient5 = 7.0m / 5.0m;
//decimal decimalQuotient6 = 7 / 5;

int first = 7;
int second = 5;
decimal quotient3 = first / second;

Console.WriteLine(quotient3);
quotient3 = (decimal)first / (decimal)second;
Console.WriteLine(quotient3);

Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));


int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

//transformando Fahrenheit em Celsius

int fahrenheit1 = 94;
decimal celsius1 = ((decimal)fahrenheit1 - 32) * ((decimal)5/(decimal)9);
Console.WriteLine($"The temperature is {celsius1} Celsius.");
//Solução feita.

//Solução proposta pelo desafio
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

Console.WriteLine(5.0m/10);
