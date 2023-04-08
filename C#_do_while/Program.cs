Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
   
    
} while (current != 7 ) ;

Console.WriteLine("\n");

current = random.Next(1, 11);

while (current >=3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");

Console.WriteLine("\n\n");


Random randomNumber = new Random();
int currentNew = randomNumber.Next(1, 11);

do

{
    currentNew = randomNumber.Next(1, 11);

    if (currentNew >= 8) continue;

    Console.WriteLine(currentNew);
} while (currentNew != 7);


Console.WriteLine("\n\n\n\n\n");
//Desafio RPG

int vidaHeroi = 10;
int vidaMonstro = 15;

Random atkHeroi = new Random();
Random atkMonstro = new Random();

int hitHeroi = atkHeroi.Next(1, 11);
int hitMonstro = randomNumber.Next(1, 11);
/*
do
{
    //ATK heroi
    hitHeroi = atkHeroi.Next(1, 11);
    vidaMonstro = vidaMonstro - hitHeroi;
    Console.WriteLine($"ATK heroi {hitHeroi} - vida do Monstro {vidaMonstro}");
    //ATK monstro
    if(vidaMonstro >= 0) 
        {
            hitMonstro = randomNumber.Next(1, 11);
            vidaHeroi = vidaHeroi - hitMonstro;
            Console.WriteLine($"ATK Monstro {hitMonstro} - vida do Heroi {vidaHeroi}");
        }
        
    if (vidaHeroi <=0)
        {
            Console.WriteLine("Heroi perdeu");
        } 
} while(vidaMonstro >= 0);  */

do
{
   // Heroi atk se Montro == 0 acaba
   
        hitHeroi = atkHeroi.Next(1, 11);
        vidaMonstro = vidaMonstro - hitHeroi;
        Console.WriteLine($"ATK heroi {hitHeroi} - vida do Monstro {vidaMonstro}");
        if (vidaMonstro <= 0)
            {
                Console.WriteLine("Heroi venceu");
            } else  
            {
                hitMonstro = atkMonstro.Next(1,11);
                vidaHeroi = vidaHeroi - hitMonstro;
                Console.WriteLine($"ATK montro {hitMonstro} - vida do Heroi {vidaHeroi}");
                if (vidaHeroi <=0) 
                {
                    Console.WriteLine("Monstro venceu");
                    break;
                }
            }
} while(vidaMonstro >= 0);

Console.WriteLine("\n\n");

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health");
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");