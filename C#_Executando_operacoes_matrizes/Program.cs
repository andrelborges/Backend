string[] pallets = {"B14", "A11", "B12", "A13"};

/*
Console.WriteLine("Sorted...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

Console.WriteLine("");
Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");
if (pallets[0] != null)
    Console.WriteLine($"Afeter: {pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 .. count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");    
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);

string result = new string(valueArray);
Console.WriteLine(result);
string newResult = String.Join(",", valueArray);
Console.WriteLine(newResult);
string[] items = newResult.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

/* 
string pangram = "The quick brown fox jumps over the lazy dog";
char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);

string resultPangram = new string(pangramArray);
string newResultPangram = String.Join(",", pangramArray);
//Console.WriteLine(pangramArray);
Console.WriteLine(newResultPangram);

//Resultado esperado ehT kciuq nworb xof spmuj revo eht yzal god

*/
/*
string[] itemsPangram = pangram.Split(' ');
Console.WriteLine(itemsPangram);
Array.Reverse(itemsPangram);


foreach (string itemp in itemsPangram)
{
    
    Console.WriteLine(itemp);
}
*/
string pangram = ("The quick brown fox jumps over the lazy dog");

string[] message = pangram.Split(' ');

string[] newMessage = new string[message.Length];

for (int i =0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string resultpangram = String.Join(" ", newMessage);
Console.WriteLine(resultpangram);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] oStream = orderStream.Split(',');
Array.Sort(oStream);
for (int i = 0; i < oStream.Length; i++ )
{
    //Console.WriteLine(oStream[i] );
    // Console.WriteLine(oStream.Length);
    string contar = oStream[i];
  // Console.WriteLine(contar.Length);
   if(contar.Length == 4)
   {
    Console.WriteLine(oStream[i] );
    //Console.WriteLine("Teste");
   } else
   {
    Console.WriteLine(oStream[i] + " - Erro" );
   }
    
}
/* Solução apresentada
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}

*/