﻿partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[,] a = new int[,]{{2,3,2,1},{2,3,4,5}};
        int[,] b =SumaDeMatrices(a,a);
        foreach(int i in b)
        {
            Console.WriteLine(i);
        }
    }
    
    static int[,] SumaDeMatrices(int[,] matrix1 , int [,] matrix2)
    {
        int[,] matrix3= new int[matrix1.GetLength(0),matrix1.GetLength(1)];
      
        for(int i=0; i<matrix1.GetLength(0);i++)
        {
            for(int j=0; j<matrix2.GetLength(1);j++)
            {
                matrix3[i,j]=matrix1[i,j]+matrix2[i,j];
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
        bool[,] mascara=new bool[matrix1.GetLength(0),matrix1.GetLength(1)];
        (int,int)[] direccion ={(1,0),(-1,0),(0,1),(0,-1)};
        int[] espiral=new int[matrix1.GetLength(0)*matrix1.GetLength(1)];
               
    }
    
}