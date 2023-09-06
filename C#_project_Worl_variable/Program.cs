//1. List all of our current pet information
//2. Display all dogs with a specified characteristic

//Enter menu item selection or type "Exit" to exit the program

string? menu = "";

Console.WriteLine("1. List all of our current pet information");
Console.WriteLine("2. Display all dogs with specified characteristic");
Console.WriteLine("0. Exite");

menu = Console.ReadLine();

Console.WriteLine(menu);

while (menu != null)
{
   switch (menu)
   {
    case "1":
    Console.WriteLine("case 1");
    break;

    case "2":
    Console.WriteLine("case 2");
    break;

    default:
    Console.WriteLine("Digite uma opção valida");
    break;
   }
    break;
}

