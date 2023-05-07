//Teste no valor de variavel
/*

int a = 15;
int b = a;
int c = a;

Console.WriteLine($"{a} variavel a");
Console.WriteLine($"{b} variavel b");
Console.WriteLine($"{c} variavel c");

a = 10;

Console.WriteLine("Alterado o valor da variavel a para 10");

Console.WriteLine($"{a} variavel a");
Console.WriteLine($"{b} variavel b");
Console.WriteLine($"{c} variavel c");

int i = 123;
object o = i;
int j = (int)o;

Console.WriteLine(i);
Console.WriteLine(o);
Console.WriteLine(j);
Console.WriteLine(i + j );
*/
public class Point
{
    public int X { get; }
    public int Y { get; }
    
    public Point(int x, int y) => (X, Y) = (x, y);
}

public class Program
{
    static void Main()
    {
        var p1 = new Point(0, 0);
        var p2 = new Point(10, 20);

    }
}