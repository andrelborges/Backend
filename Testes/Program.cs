class Program
{
    static void Main()
    {

        Calculate calculate = new Calculate(Sum);
        int result = calculate(10,20);
        Console.WriteLine(result);
        //metodo anonimo
        var divade = delegate(int x, int y) {return x / y; };
        var multiply1 = delegate(int x, int y) {return x * y; };
        //Expressão lambda 
        //var multiplylambda = (int x, int y) => {return x * y; };
        var multiplylambda = (int x, int y) => x * y;
        Run(Sum);
        Run(Multiply);
        
        Console.WriteLine(divade(10, 5));

        Runfunc(multiply1);
        
        Action<string> test = delegate(string name) { Console.WriteLine(name);};

        //Expressao lambda
        var nameLambda = (string name) => Console.WriteLine($"Ola {name}");

       test("Kik");
       test("Andre");
       test("Outro nome");

        Func<decimal> teste2 = delegate () { return 4.2M;};

        Func<decimal> lambdateste2 = () => 4.2M;

        Console.WriteLine(teste2());

        Func<string, bool> checkName = delegate (string name) { return name == "Andre";};

        Func<string, bool> checkNamelambda = name => name == "Andre";

        Console.WriteLine(checkName("Kik"));
        

        /*
       ILogger logger = new FileLogger("mylog.txt");
       BankAccount account1 = new BankAccount("Andre", 100, logger);
       BankAccount account2 = new BankAccount("kik", 100, logger); 

       List<BankAccount> accounts = new List<BankAccount>()
        {
            account1,
            account2
        };


         DataStore<string> store = new DataStore<string>();
        store.Value = "Andre";

        Console.WriteLine(store.Value.Length);
        
        
        DataStore<int> store = new DataStore<int>();
        store.Value = 42;

        Console.WriteLine(store.Value);
      
        List<int> numbers = new List<int> {1, 4, 8, 10};

        foreach (BankAccount account in accounts)
        {
            Console.WriteLine(account.Balance);
        }

       //accounts.Add(account1);
       //accounts.Remove(account1);


       account1.Deposit(-100);
 
       account2.Deposit(100);
       account2.Deposit(250);

       Console.WriteLine(account1.Balance);
       Console.WriteLine(account2.Balance);
       
        */
    }
    static void Runfunc(Func<int, int, int> calc)
    {
        Console.WriteLine(calc(20,2));
    }

    static void Run(Calculate calc)
    {
        Console.WriteLine(calc(20, 30));
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}

/*
class DataStore<T>
{
    public T Value {get; set; }
}
*/

delegate int Calculate(int x, int y);

class FileLogger : ILogger
{

    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
    }
}


class ConsoleLogger : ILogger
{
   
}

interface ILogger
{
    void Log(string message)
    {
       Console.WriteLine($"LOGGER: {message}"); 
    }
}

class BankAccount
{
    private string name;
    private readonly ILogger logger;

    public decimal Balance 
    { 
        get; private set;
    }

    public BankAccount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Nome invalido", nameof(name));
        }
        if (balance < 0 )
        {
            throw new Exception("Saldo não pode ser negativo");
        }
        this.name = name;
        Balance = balance;
        this.logger = logger;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            logger.Log($"Não e possivel depositar {amount} na conta de {name}");
            return;
        }
        //balance = balance + amount;
        Balance += amount;
    }

   
}























/*class Program
{
    static void Main()
    {
        string s = null;

        try
        {
            Console.WriteLine(s.Length);
        }
        catch (System.NullReferenceException exception)
        {
            
            Console.WriteLine($"Erro de referencia");
        }
    }
}

*/







/*
Console.Write("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine($"Ola {name}!");

Console.Write("Digite o ano do seu nascimento: ");

int year = int.Parse(Console.ReadLine());
int age = 2023 - year;
Console.WriteLine($"Você tem {age} anos.");

if (age >= 18 && name == "Andre") Console.WriteLine("Você e maior de idade");
// else if Console.WriteLine("Você e menor de idade");
else Console.WriteLine("Você é menor de idade");

// Com bloco de codigo

// if(age >=18)
// {
//     Console.WriteLine("Você é maior de idade);     
// }

*/

/*
class Program
{
    static void Main()
    {
        string[] names = {"Andre", "Kik"};
        
        if (string.Equals(names[0], "andre", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Igual");
        }
        //Console.WriteLine(names[0]);
        //Console.WriteLine(names[1]);
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        foreach (string name in names)
        {
            Console.WriteLine(names);
        }

        string names1 = "Andre";


        Console.WriteLine(names1.Length);
        Console.WriteLine(names1.EndsWith('r'));
        // -> " "<- string mais de um caracter -->' '<-- somente um caracter
        Console.WriteLine(names1.IndexOf("dr"));
        Console.WriteLine(string.IsNullOrEmpty(names1));
        Console.WriteLine(string.Join('+', names));

        if(int.TryParse("42", out int x))
        {
            Console.WriteLine(x);

        }
        
        int inteiro = 10;
        long longo = 1002340;

        inteiro = (int)longo;
        string str = longo.ToString();
        Console.WriteLine(inteiro);

        //Tipo de referencia

        //TIpo de Valor

        Test t = new Test();
        t.x = 10;

        Console.WriteLine(t.x);

        t = null;
        int? nulo = 10;
        if (nulo == null)
        {
            Console.WriteLine("variavel nula");
        }
        
        if (nulo != null)
        {
            !=
        }

        if (nulo is null)
        {
            
        }

        if (nulo is not null)
        {
            
        }
    }
}

class Test
{
    public int x;
}


*/