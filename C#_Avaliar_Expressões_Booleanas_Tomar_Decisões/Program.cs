Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
//Console.WriteLine(myValue == "a");

//string value1 = " a";
// string value2 = "A ";

//Utilizar 2 métodos na mesma variavel Trim() remover espaços
//ToLower() para deixar em minuscula
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

//Mesma logica nas duas linhas 
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

//operados condicional ? :

int saleAmount = 1001;

int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount {discount}");


Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
//Invertendo a ordem
Console.WriteLine($"Discount: {(saleAmount < 1000 ? 50 : 100)} segunda versão");

//Desafio

//Lançar uma moeda para exibir cara ("heads") ou coroa ("tails")
// 3 linhas de codigo
//lendo documentação 
Random coin = new Random();
string [] coi = {"heads" , "tails"};
int index = coin.Next(coi.Length);
Console.WriteLine(coi[index]);

//Vendo modulo anterior
Random coins = new Random();
int roll = coins.Next(1, 3);
Console.WriteLine(roll > 1 ? "heads" : "tails");

Random coinD = new Random();
int flip = coinD.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

Random coinCurto = new Random();
Console.WriteLine((coinCurto.Next(0, 2) == 0) ? "heads" : "tails");

//Desafio

string permission = "Admin|Manager";
int level = 55;

//Admin level maior que 55 
//Welcome, Super Admin user.
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
//Admin menor ou igual 55
//Welcome, Admin user.

//Gerente maior 20
//Contact an Admin for access.

//Gerente level menor 20
//You do not have sufficient privileges.

//Não e administrador nem gerente
//You do not have sufficient privileges.

bool flag = true;
int value = 0;
if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}

Console.WriteLine("Outside of code block: " + value);

namespace MyNewApp.Business
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
        }
    }
}

