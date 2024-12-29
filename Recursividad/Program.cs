class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.Factorial(3));
        Console.WriteLine(Solution.SumaNnumeros(100));
        Console.WriteLine(Solution.Fibonnaci(4));
        Console.WriteLine(Solution.MaximoComunDivisor(125, 25));
        Console.WriteLine(Solution.Pow(3, 0));
        Console.WriteLine(Solution.PowMiddle(3, 0));
        System.Console.WriteLine(Solution.BinarySearch([1,2,3,4,5,6,80],-1));
    }
}    
    partial class Solution
    { 
    public static int Factorial(int x)
    {
        return x == 0 || x == 1 ? 1 : Factorial(x - 1) * x;
    }
    public static int SumaNnumeros(int x)
    {
        if (x == 0) return 0;

        return x == 1 ? 1 : SumaNnumeros(x - 1) + x;
    }
    public static int Fibonnaci(int x)
    {
        return x == 0 || x == 1 ? 1 : Fibonnaci(x - 1) + Fibonnaci(x - 2);
    }
    public static int MaximoComunDivisor(int x, int y)
    {
        if (x % y == 0) return y;
        return MaximoComunDivisor(y, x % y);
    }
    public static int Pow(int x, int n)
    {
        if (n == 0) return 1;

        return Pow(x, n - 1) * x;
    }
    public static int PowMiddle(int x, int n)
    {
        if (n == 0) return 1;

        int d = PowMiddle(x, n / 2);

        if (n % 2 == 0) return d * d;

        return x * d * d;
    }
}
