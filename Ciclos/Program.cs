class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine(Factorial(3));
       Console.WriteLine(SumaImpares(6));
       
       MayorMenorPromedio([12,345,7364.5,2899,738,1]);
    }

    public static int Factorial(int n)
    {
        int factorial=1;
        if (n==1 || n == 0) return factorial;
        
        for (int i = 0; i < n; i++)
        {
            factorial*=n-i;
            
        }
        return factorial;
    }
    public static int SumaImpares(int n)
    {
       int suma = 0;
       for(int i=1;i<=n;i+=2)
       {
         suma+=i;
       } 
       return suma;
    }
    public static void MayorMenorPromedio(double[] arr)
    {
        double mayor=arr[0], menor=arr[0], promedio=arr[0];

        for(int i=0; i<arr.Length;i++)
        {
            if(arr[i]>=mayor) mayor = arr[i];
            if(arr[i]<=menor) menor = arr[i];
           
            if(i>0) promedio+=arr[i];
        }
        promedio = promedio/arr.Length;
        
        Console.WriteLine($"El menor elemento: {menor}, el mayor elemento:{mayor}, el promedio {promedio} .");
    }
    public static void RecorriendoArray(int[]arr)
    {
         
    }
}