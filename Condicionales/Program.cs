class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introduce dos numeros enteros para determinar si es divisible el primero entre el segundo");
        
        int number1 = int.Parse(Console.ReadLine()!);
        int number2 = int.Parse(Console.ReadLine()!);

        Divisible(number1,number2);
        
        Console.WriteLine("Introduce un numero de identificacion para determinar el sexo de la persona");

        long idNumber = long.Parse(Console.ReadLine()!);
        
        personSexByIdNumber(idNumber);

        Console.WriteLine("Introduce tres numeros enteros, para determinar si forman un triangulo");

        int lado1 = int.Parse(Console.ReadLine()!);
        int lado2 = int.Parse(Console.ReadLine()!);
        int lado3 = int.Parse(Console.ReadLine()!); 
        
        Console.WriteLine(Triangule(lado1,lado2,lado3));

        Console.WriteLine("Introduce un numero entero para calacular su valor absoluto");
        
        int number = int.Parse(Console.ReadLine()!);
        
        number=ValorAbsoluto(number);
        
        Console.WriteLine("Valor absoluto: "+ number);
    }
    public static void Divisible(int number1, int number2)
    {
        if(number1%number2==0)
        {
            Console.WriteLine($"Es divisible {number1}/{number2}");
        }
        else Console.WriteLine("no son divisibles");
    }
    public static void personSexByIdNumber(long idNumber)
    {
      if((idNumber/10%10)%2==0)
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
      if(lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
      {
        Console.WriteLine("No es un triangulo");

        return (int) TypeOfTriangule.NotATriangule;
      }
      else if (lado2 == lado1 && lado3 == lado2)
      {
        Console.WriteLine("Es un triangulo equilatero");

        return (int) TypeOfTriangule.Equilateral;
      }
      else if( (lado1 != lado2 && lado3 != lado2) && lado3 != lado2)
      {
        Console.WriteLine("Es un triangulo escaleno");
         
        return (int) TypeOfTriangule.Escalene;
      }
      Console.WriteLine("Es un triangulo Isosceles");
      
      return (int) TypeOfTriangule.Isosceles;
    }
    public static int ValorAbsoluto(int number)
    {
      if(number < 0) return number*-1;

      return number;
    }
}