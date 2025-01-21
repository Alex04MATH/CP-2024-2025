using System.ComponentModel;

partial class Program
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

    static int[,] SumaDeMatrices(int[,] matrix1, int[,] matrix2)
    {
        int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return matrix3;
    }
    // static bool TableroAlcanzableCaballo(bool[,]matrix)
    // {
    //   bool[,] mascara;
    //   (int,int)[] direccion={(1,2),(1,-2),(-1,2),(-1,-2),(2,1),(2,-1),(-2,1),(-2,-1)};
    // }

    static int[] Espiral(int[,] matrix1)
    {
        int direct = 0;
        bool[,] mascara = new bool[matrix1.GetLength(0), matrix1.GetLength(1)];
        (int, int)[] direccion = { (0, 1), (1, 0), (0, -1), (1, 0) };
        int fila = matrix1.GetLength(0);
        int columna = matrix1.GetLength(1);
        int[] espiral = new int[fila * columna];
        espiral[0] = matrix1[0, 0];
        int x = 0, y = 0;
        for (int i = 1; i < espiral.Length; i++)
        {
            if (x == fila)
            {
                direct = (direct + 1) % 4;
                x = fila - 1;
            }
            if (y == columna)
            {
                direct = (direct + 1) % 4;
                y = columna - 1;
            }
            else
            {  
                if (mascara[x, y] == true) direct = (direct + 1) % 4;
                x += direccion[direct].Item1;
                y += direccion[direct].Item2;
                espiral[i] = matrix1[x, y];
                mascara[0, 0] = true; 
                mascara[x, y] = true;
            }
        }
    
        return espiral;
    }
    private static bool pro(bool[,] mask,int x , int y)
    {
        return mask[x,y];
    }
}