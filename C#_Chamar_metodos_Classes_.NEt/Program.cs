// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Classe 'Console'
// '.' operador de acesso de mebro
//Método 'WriteLine'
//Operador de chamada do método '()'
//Adicionar um valor que deseja que o metodo imprima
//Console.WriteLine("Hello, World!");
Random dice = new Random();
int roll = dice.Next(1,8);
Console.WriteLine(roll + "primeiro");
int x =0;

for (int i = 0 ; i < 4; i++) {
    
    Console.WriteLine(x + "segundo");
    x = dice.Next(8,12);
    Console.WriteLine(x + "terceiro");
}

Random dice1 = new Random();
// sem limite para gerar um numero de 0 a 2,14,483,647
int roll1 = dice.Next(); 
//define limite superior ate 100
int roll2 = dice.Next(101);
// define limite inferior e superior
int roll3 = dice.Next(50,101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"First roll: {roll2}");
Console.WriteLine($"First roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue,secondValue);

//public static int Max (int val1, int val2);

Console.WriteLine(largerValue);

// Objeto e uma instância de uma classe


