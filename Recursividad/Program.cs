class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(3));
        Console.WriteLine(SumaNnumeros(100));
        Console.WriteLine(Fibonnaci(4));
    }
    public static int Factorial(int x) 
    {
        return x==0 || x==1?1: Factorial(x-1) *x; 
    }
    public static int SumaNnumeros(int x)
    {
        if (x==0) return 0;
        
        return x==1? 1: SumaNnumeros(x-1)+x;
    }
    public static int Fibonnaci(int x)
    {
        return x==0 || x==1?1:Fibonnaci(x-1)+Fibonnaci(x-2);
    }
}