using System.Collections.Concurrent;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // int [] uno = BubbleSort([23,45,9238,1,3,30,29,0,-1]);
        // for (int i = 0; i < uno.Length; i++)
        // {
        //     Console.WriteLine(uno[i]);
        // }
        // Console.WriteLine(CualNumber(4,[4, 2, 4, 5, 6, 2, 7]));
        int[] a = Solution.BubbleSort([23, 45, 9238, 1, 3, 30, 29, 0, -1]);
        int[] b = Solution.SelectionSort([23, 23, 9238, 1, 1, 1, 29, 0, -1]);
        int c = Solution.MinDiff( [4, 9, 1, 32, 13, 6]);
        Console.WriteLine(Solution.SistemaDeNumeracion(['a', 'b'], "a"));
        Console.WriteLine(Solution.SistemaDeNumeracionInvertido(['a', 'b'], 0));
        Console.WriteLine(Solution.BinarySearch(a, 30));
        Console.WriteLine(c);
        Console.WriteLine(Solution.Consecutive(b,3));
        Console.WriteLine(Solution.MaxSumSub([0, -1, 0, -2, 0, -3]));
        Console.WriteLine(Solution.CountInversions( [1, 2, 3, 4, 5]));
    }
}