string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}", first, second);
Console.WriteLine(result);
/* teste com texto maior na primeira variavel
Necessario recarregar o Format para atualizar o valor
first = "This is a great";
result = string.Format("{0} {1}", first, second);
Console.WriteLine(result);
*/
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{1} {0}!", second, first);
Console.WriteLine("{0} {0} {0}!", first, second);

Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price1 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price.", (price1 - salePrice), price1);
Console.WriteLine(yourDiscount);
yourDiscount += $"A discount of {(price1 - salePrice)/price1:P2}!";
Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($" Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");

string first1 = "Hello";
string second1 = "World";
string result1 = string.Format("{0} {1}!", first1, second1);
Console.WriteLine(result1);
char pad = '.';
Console.WriteLine(result1.PadLeft(15));
Console.WriteLine(result1.PadLeft(25, pad));

string paymentID = "769C";
string payeeName = "MR. Stephen Ortega";
string paymentAmount = "$0.00";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

Console.WriteLine("\n\n");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

//Your Code

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.");


Console.WriteLine("Here's a quick comparison:\n");

string comparionMessage = "";

comparionMessage = currentProduct.PadRight(20);
comparionMessage += String.Format("{0:P}" , currentReturn).PadRight(10);
comparionMessage += String.Format("{0:C}" , currentProfit).PadRight(20);

comparionMessage += "\n";
comparionMessage += newProduct.PadRight(20);
comparionMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparionMessage += String.Format("{0:C}", newProfit).PadRight(20);


Console.WriteLine(comparionMessage);
/*
{customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares} shares at a return of {currentReturn}.

Our new product, {newProduct} offers a return of {newReturn}.  Given your current volume, your potential profit would be {newProfit}.

Here's a quick comparison:

{currentProduct}         {currentReturn}   {currentProfit}      
{newProduct}    {newReturn}   {newProdit}  
*/
Console.WriteLine("12345678901234567890");
Console.WriteLine("C110".PadLeft(6,'0'));
Console.WriteLine("12345678901234567890");
Console.WriteLine("C110".PadLeft(8,'0'));
Console.WriteLine("12345678901234567890");
Console.WriteLine("C110".PadLeft(16,'0'));
Console.WriteLine("12345678901234567890");
Console.WriteLine("C110".PadLeft(20,'0'));
Console.WriteLine("12345678901234567890");
Console.WriteLine("ABCD1234".PadLeft(20,'0'));
Console.WriteLine("12345678901234567890");
Console.WriteLine("ABCDEFGHIJ1234567890".PadLeft(20,'0'));