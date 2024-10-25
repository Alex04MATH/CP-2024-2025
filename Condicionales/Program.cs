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
}