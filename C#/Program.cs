

Console.WriteLine("Hello World");
int[] arrayNum = new int[5] {1,5,3,6,4};
//Somar o conjunto dentro de um array.
//Usando o for
int soma = 0;

for (int i =0;i<arrayNum.Length; i++) {
        soma += arrayNum[i];
}
Console.WriteLine("A soma do array é: " + soma);

//Usando Array.ForEach()
soma = 0;


Array.ForEach(arrayNum, i =>soma +=i);
Console.WriteLine("A soma do usando ForEach() é: " + soma);

soma = 0;
foreach (int item in arrayNum) 
{
    soma += item;
    
}

Console.WriteLine("Utilizando ForEach em ciclo" + soma);

Console.WriteLine("Utilizando metodo Linq: " + arrayNum.Sum());


int[] a = new int[5] {1,2,3,6,6};
int[] b = new int[5] {3,2,1,5,5};

int somaa = 0;
int somab = 0;
int somac = 0;

for(int i =0; i < a.Length; i++) {
    if(a[i] >b[i]) {
        somaa++; 
    } 
    else if (b[i]>a[i]) {
        somab++;
    } else {
        somac++;

    }
    Console.WriteLine("Alice ganhou: " + somaa);
    Console.WriteLine("Bob ganhou: " + somab);
    Console.WriteLine("Empate: " + somac);

}

//Operador aritmetico
// + soma
// - Subtração
// * Multiplicação
// Divisão
///% Modulo

//Operador aritimetico de atribuição
// +=
//-=
//*=
// /=
// %=

//Incremento / decremento
// ++
// --
//Operador Reçacional
// ==
// !=
// >
// <
// >=
// <=
//operadores logicos 

// && AND
// || OR
// !

bool bol1 = true;
bool bol2 = false;

if(bol1 && bol2 == true) {
    Console.WriteLine("Verdadeiro");
}
if(bol1 && !bol2 == true) {
    Console.WriteLine("Verdadeiro2");
}
// teste logico? valor se verdadeiro: valor se falso

Console.WriteLine(arrayNum[0] > arrayNum[1]? "Sim": "Não " + arrayNum[1] );


 Console.WriteLine(12.30m); //tipo decimal
 Console.WriteLine(12.30);

 // var o copilador define o tipo da variavel

 string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

string messageEnglish = $@"c:\Exercise\{projectName}\data.txt \n\n ";
string russianMessage1 = $@"c:Exercise\{projectName}\ru-RU\data.txt";

Console.WriteLine($"View English output: \n\t\t {messageEnglish} \n");
Console.WriteLine($"{russianMessage} \n\t\t{russianMessage1}\n");
Console.WriteLine("\"casa\" \n\n\t\t aqz" + russianMessage + " " + messageEnglish);
//Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
  

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);
string firstName = "dek";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 +" widget");
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int diffetence = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Diffetence: " + diffetence);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//View English output:
//		c:\Exercise\ACME\data.txt

//Посмотреть русский вывод:
//		c:\Exercise\ACME\ru-RU\data.txt