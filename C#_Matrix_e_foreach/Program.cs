/* 
string [] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F00";
Console.WriteLine($"Reassinf First: {fraudulentOrderIDs[0]}");

*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F00";
Console.WriteLine($"Reassinf First: {fraudulentOrderIDs[0]}");


Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//foreach

string [] names = {"Bob", "Conrad", "Grant"};

foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = {200, 450, 700, 175, 250};

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
   
}
 Console.WriteLine($"We have {sum} itemms in inventory.");
   
//Desafio

//metodo  String.StartsWith()

string nameExemplo = "Bob";
if (nameExemplo.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B' "+ nameExemplo );
}
string[]  exmploNomes = {"Andre", "Amanda", "Bruno", "Jõao", "Andrei"};
foreach (string exNome in exmploNomes) 
{
    if(exNome.StartsWith("A"))
    {
        Console.WriteLine("Começa com a "  + exNome);

    }
    
}

//DESAFIO 


string[] pedidosIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string fraudeIDs in pedidosIDs)
{
    if (fraudeIDs.StartsWith("B")) 
    {
        Console.WriteLine(fraudeIDs);
    }
}