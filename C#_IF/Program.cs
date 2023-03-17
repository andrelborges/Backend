Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if((roll1 == roll2) && (roll1 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >=16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

//Adicionando novas regras ao jogo
/*
if (total >= 15) 
{
Console.WriteLine("You win!");
}
else
{
    Console.WriteLine ("Sorry, you lose.");
}
*/


//Primeira versão do código 
/*
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
       Console.WriteLine("You rolled doubles! +2 bonus to total!");
       total +=2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total =+6;
}
if (total >= 15) 
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
} */

//string.Contains() verifica se uma cadeia de caracteriias contem em outra

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
bool result1 = message.Contains("fox jumps over");
bool result2 = message.Contains("fox jumps over lazy");
Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result2);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

//Desafio

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);

if(daysUntilExpiration <= 10)
{
    if( daysUntilExpiration > 5)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1) )
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
        discountPercentage = 10;
    }
    else if (daysUntilExpiration == 1) 
    {
        Console.WriteLine("Your subscription expires within a day!Renew now and save 20%!"); 
        discountPercentage = 20;
    }
    else
    {
        Console.WriteLine("Your subscription has expired.");
    }
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

/*
if(daysUntilExpiration <= 10)
{
    if( daysUntilExpiration > 5)
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1) )
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.Renew now and save 10%!");
    }
    else if (daysUntilExpiration == 1) 
    {
        Console.WriteLine("Your subscription expires within a day!Renew now and save 20%!");  
    }
    else
    {
        Console.WriteLine("Your subscription has expired.");
    }
}
*/

//Solução apresentada pela Microsoft
/* Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
*/
