// Realizar o desafio do Contoso Pets aplicação

string animalID = "";
string specieAnimal = "";
string nameAnimal = "";

int maxAnimal = 8;

string[,] array = new string[maxAnimal,3];

for (int i = 0; i < maxAnimal; i++)
{
    if (i ==0)
    {
        animalID = "1";
        specieAnimal = "dog";
        nameAnimal = "Bela";
    }
    else if (i == 1)
    {
        animalID = "2";
        specieAnimal = "dog";
        nameAnimal = "Spok";
    }
    else if (i == 2) 
    {
        animalID = "3";
        specieAnimal = "cat";
        nameAnimal = "Nino";
    }
    else
    {
        animalID = "";
        specieAnimal = "";
        nameAnimal = "";
    }
    array[i, 0] = "ID #:" + animalID;
    array[i, 1] = "Species: " + specieAnimal;
    array[i, 2] = "Nickname: " + nameAnimal;
    
}

Console.WriteLine(array[0,0]);
Console.WriteLine(array[0,1]);
Console.WriteLine(array[0,2]);

string? menu;
string menuSelection = "";

do
{

Console.Clear();

Console.WriteLine("Para adicionar um Pet digite 1");
Console.WriteLine("Para sair digite exit");

menu = Console.ReadLine();



if (menu != null)
    {
        menuSelection = menu.ToLower();
        // NOTE: We could put a do statement around the menuSelection entry to ensure a valid entry, but we
        //  use a conditional statement below that only processes the valid entry values, so the do statement 
        //  is not required here. 
    }



switch (menu)
{
    case "exit":
    Console.WriteLine("Saindo");
    break;

    default:
    Console.WriteLine("Digite uma opção valida");
    break;
}

} while (menu != "exit");