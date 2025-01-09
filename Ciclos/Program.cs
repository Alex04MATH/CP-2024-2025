using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.Factorial(5));
        Console.WriteLine(Solution.SumaImpares(6));
        Solution.MayorMenorPromedio([12, 345, 7364.5, 2899, 738, 1]);
        Solution.RecorriendoArray([12, 345, 2, 2899, 738, 1], 1);
        int[] arr = Solution.InvertirArr([12, 345, 2, 2899, 738, 1]);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine("\n" + Solution.EsPalindromo("A"));
        int[] arr1 = Solution.Rotando([25, 40, 17, 83, 9], -2);
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + ", ");
        }
    }
}
class Solution
{
    public static int Factorial(int n)
    {
        int factorial = 1;
        if (n == 1 || n == 0) return factorial;

        for (int i = 0; i < n; i++)
        {
            factorial *= n - i;

        }
        return factorial;
    }
    public static int SumaImpares(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i += 2)
        {
            suma += i;
        }
        return suma;
    }
    public static void MayorMenorPromedio(double[] arr)
    {
        double mayor = arr[0], menor = arr[0], promedio = arr[0];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= mayor) mayor = arr[i];
            if (arr[i] <= menor) menor = arr[i];

            if (i > 0) promedio += arr[i];
        }
        promedio = promedio / arr.Length;

        Console.WriteLine($"El menor elemento: {menor}, el mayor elemento:{mayor}, el promedio {promedio} .");
    }
    #region Recorriendo Array
    public static void RecorriendoArray(int[] arr, int n)
    {
        Console.WriteLine($"El mayor elemento del array es {mayor(arr)}");
        Console.WriteLine($"El segundo menor elemento es {segundoMenor(arr)}");
        Console.WriteLine($"El elemento {n}: ({pertenece(arr, n)}) pertenece al array");
        Console.WriteLine($"El promedio del array es {promedio(arr):F2}");
        Console.WriteLine($"Cantidad de elementos mayores que el promedio {cantidadDeElementosMayores(arr)}");
    }
    private static int mayor(int[] arr)
    {
        int mayor = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (mayor < arr[i]) mayor = arr[i];
        }
        return mayor;
    }
    private static int segundoMenor(int[] arr)
    {
        int menor = arr[0];
        int segundoMenor = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (menor > arr[i])
            {
                segundoMenor = menor;
                menor = arr[i];
            }
        }
        return segundoMenor;
    }
    private static bool pertenece(int[] arr, int n)
    {
        bool _pertenece = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == n) return true;
        }
        return _pertenece;
    }
    private static double promedio(int[] arr)
    {
        double _promedio = arr[0];
        for (int i = 1; i < arr.Length; i++)
            _promedio += arr[i];

        return _promedio / arr.Length;
    }
    private static int cantidadDeElementosMayores(int[] arr)
    {
        int numelementos = 0;
        int _promedio = (int)promedio(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            if (_promedio < arr[i]) numelementos++;
        }
        return numelementos;
    }
    #endregion
    public static int[] InvertirArr(int[] arr)
    {
        int[] arr1 = new int[arr.Length];
        for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
        {
            arr1[j] = arr[i];
        }
        return arr1;
    }
    public static int[] FiltrandoPositivos(int[] arr)
    {
        List<int> arr1 = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) arr1.Add(arr[i]);
        }
        return arr1.ToArray();
    }
    public static bool EsPalindromo(string s)
    {
        bool palindromo = true;
        for (int i = 0, j = s.Length - 1; i <= s.Length / 2 && j >= s.Length / 2; i++, j--)
        {
            if (s[i] != s[j]) return false;
        }
        return palindromo;
    }
    public static int[] Rotando(int[] arr, int n)
    {
        if (n == 0 || arr.Length == 0 || arr.Length == 1) return arr;
        int[] arr1 = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            int posicion = i + n;
            int posicionPositiva = (posicion) % arr.Length;

            if (n > 0)
            {
                arr1[posicionPositiva] = arr[i];
            }
            if (n < 0)
            {
                if (posicion < 0)
                    arr1[arr.Length + posicion] = arr[i];
                if (posicion >= 0)
                    arr1[posicion] = arr[i];
            }
        }

        return arr1;
    }
}
