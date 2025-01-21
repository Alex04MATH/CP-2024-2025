using ContadorDePosibilidades;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Probable.Contador(100);
    }
}
namespace ContadorDePosibilidades
{
    class Probable
    {
        
        public static void Contador(int num)
        {
            Random a=new Random();
            int[,] index=new int[2,6];
            for(int i=0;i<6;i++)
            {
                index[0,i]=i+1;
            }
            
            for(int i=0;i<num-1;i++)
            {
                int number=a.Next(1,7);
                index[1,posicion(number)]+=1;
            }
            Console.WriteLine("El elemento que mas se repite es:"+" " +index[0,busquedamayor(index)]+" con un total de:" +" "+index[1,busquedamayor(index)]);
        System.Console.WriteLine();
        for(int i=0;i<index.GetLength(1);i++)
        {
            Console.Write(index[1,i]+", ");
        }
        }
        private static int posicion(int a)
        {
            return a-1;
        }
        private static int busquedamayor(int[,]a)
        {
            int mayor=0;
            int value=a[1,0];
            List<int>iguals=new List<int>();
            for(int i=0,j=1;j<a.GetLength(1);i++,j++)
            {
                if(a[1,i]<a[1,j])
                {
                    if(value<a[1,j])
                    {
                        mayor=j;
                        value=a[1,j];
                    }
                }
                if(a[1,i]==a[1,j]) iguals.Add(j);
            }
            return mayor;
        }
    }
}