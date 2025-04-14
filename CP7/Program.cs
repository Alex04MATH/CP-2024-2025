using System.ComponentModel;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch= new Stopwatch();
        stopwatch.Start();
        Console.WriteLine("Hello, World!");
        int[,] a = new int[,] { { 2, 3 ,4}, { 3, 2,5 },{4,5,2} };
        int[,] b = Solution.SumOfMatrix(a, a);
        foreach (int i in b)
        {
            Console.WriteLine(i);
        }

        foreach (var e in a)
        {
            Console.Write(e + ", ");
        }
        stopwatch.Stop();
        System.Console.WriteLine();
        System.Console.WriteLine(stopwatch.ElapsedTicks);
       System.Console.WriteLine(Solution.MultiplyMatrix(a,a));
       System.Console.WriteLine(Solution.Trace(a));
       int[,] c = new int[,] { { 5, 7 ,2}, { 6, 0,3 },{1,4,5} };
       System.Console.WriteLine(Solution.Spiral(c));
    }
}