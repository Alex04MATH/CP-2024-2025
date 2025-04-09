using System.ComponentModel;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[,] a = new int[,] { { 2, 3, 2, 1 }, { 2, 3, 4, 5 } };
        int[,] b = SumaDeMatrices(a, a);
        foreach (int i in b)
        {
            Console.WriteLine(i);
        }
        int[] h = Espiral(a);
        foreach (var e in h)
        {
            Console.Write(e + ", ");
        }
    }
}