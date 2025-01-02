using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine(Solution.Factorial(5));
    Solution.ImprimiendoNumeros(6);
    Solution.ImprimiendoNumerosInvertido(6);
    Solution.Avion(1, 58, 4, 20);
  }
}
static class Solution
{
  public static void Divisible(int number1, int number2)
  {
    if (number1 % number2 == 0)
    {
      Console.WriteLine($"Es divisible {number1}/{number2}");
    }
    else Console.WriteLine("no son divisibles");
  }
  public static void personSexByIdNumber(long idNumber)
  {
    if ((idNumber / 10 % 10) % 2 == 0)
    {
      Console.WriteLine("Felicidades es una persona de sexo Masculino 🥳🥳.");
    }
    else Console.WriteLine("es una persona del sexo Femenino");
  }
  enum TypeOfTriangule
  {
    NotATriangule,
    Escalene,
    Isosceles,
    Equilateral,
  }


  public static int Triangule(int lado1, int lado2, int lado3)
  {
    if (lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
    {
      Console.WriteLine("No es un triangulo");

      return (int)TypeOfTriangule.NotATriangule;
    }
    else if (lado2 == lado1 && lado3 == lado2)
    {
      Console.WriteLine("Es un triangulo equilatero");

      return (int)TypeOfTriangule.Equilateral;
    }
    else if ((lado1 != lado2 && lado3 != lado2) && lado3 != lado2)
    {
      Console.WriteLine("Es un triangulo escaleno");

      return (int)TypeOfTriangule.Escalene;
    }
    Console.WriteLine("Es un triangulo Isosceles");

    return (int)TypeOfTriangule.Isosceles;
  }
  public static int ValorAbsoluto(int number)
  {
    if (number < 0) return number * -1;

    return number;
  }
  public static void FormandoFechas(int day, int month, int year)
  {
    if (month == 4 || month == 6 || month == 9 || month == 11)
    {
      if (day <= 30 && day > 0) Console.WriteLine($"{day}/{month}/{year}");

      else Console.WriteLine("Fecha no valida");
    }

    else if (month == 2)
    {
      int max = (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0) ? 29 : 28);
      if (day <= max && day > 0) Console.WriteLine($"{day}/{month}/{year}");

      else Console.WriteLine("Fecha no valida");
    }
    else
    {
      if (day <= 31 && day > 0) Console.WriteLine($"{day}/{month}/{year}");

      else Console.WriteLine("Fecha no valida");
    }
  }
  public static int Factorial(int n)
  {
    if (n < 0) return 0;
    if (n == 1 || n == 0) return 1;

    return n * Factorial(n - 1);
  }

  public static void ImprimiendoNumeros(int n)
  {
    if (n == 0)
    {
      Console.WriteLine(n);
      return;
    }
    Console.WriteLine(n);
    ImprimiendoNumeros(n - 1);
  }
  public static void ImprimiendoNumerosInvertido(int n)
  {
    if (n == 0) Console.WriteLine(n);
    imprimiendoNumerosInvertido(n, 0);
  }
  private static void imprimiendoNumerosInvertido(int n, int i)
  {
    if (i == n)
    {
      Console.WriteLine(i);
      return;
    }
    Console.WriteLine(i);
    imprimiendoNumerosInvertido(n, i + 1);
  }
  public static void Avion(int horaS, int minutoS, int horallegada, int minutollegada)
  {
    if ((horaS > 24 || horallegada > 24) || (minutoS > 60 || minutollegada > 60)) Console.WriteLine("Hora y minutos no validos");
    int minDif = (60 - minutoS) + (minutollegada);
    int hora = (horallegada - horaS);

    if (minutollegada < minutoS) hora -= (minDif / 60 + horaS);

    int minuto = minDif % 60;
    if (minuto > 9)
      Console.WriteLine($"Tiempo transcurrido {hora}:{minuto}");
    else
      Console.WriteLine($"Tiempo transcurrido {hora}:0{minuto}");
  }
}
