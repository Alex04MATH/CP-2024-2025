class Program
{
    public static void Main(string[] args)
    {
        #region  Di Hola
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine(int.MaxValue);

        Console.WriteLine(int.MinValue);

        Console.WriteLine(Math.PI);
        #endregion
        
        #region Recibiendo entradas
        Console.WriteLine("Inserte Un Mensaje");
        
        string message = Console.ReadLine()!;

        Console.WriteLine($"{message} Medio Limon");

        int num = int.Parse(Console.ReadLine()!);

        Console.WriteLine(num*2);
        
        Console.WriteLine("Introduce 2 numeros para hallar el mayor");
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine((Math.Abs(a-b) + a + b) / 2);

        System.Console.WriteLine("Introdusca tres numeros enteros");
        int one = int.Parse(Console.ReadLine()!);
        int two = int.Parse(Console.ReadLine()!);
        int tree = int.Parse(Console.ReadLine()!);
        int max = Math.Max(one,two);
        int min = Math.Min(one,two);
        Console.WriteLine((one+two+tree) - (Math.Max(max,tree) + Math.Min(min,tree)));

        Console.WriteLine("introduce Un String");

        string contador=Console.ReadLine()!;
        
        Console.WriteLine($"Introduce un entero no negativo menor que {contador.Length} para dar que caracter ocupa dicha posicion");

        int posicion = int.Parse(Console.ReadLine()!);
        System.Console.WriteLine(contador[posicion-1]);
        #endregion

        #region intercambio de variables
        //Con variable auxiliar 
        int uno = int.Parse(Console.ReadLine()!);
        int dos = int.Parse(Console.ReadLine()!);
        // int tres = uno;
        // uno=dos;
        // dos= tres;

        // sin variable auxiliar
        uno=dos+uno;
        dos=uno-dos;
        uno=uno-dos;
        Console.WriteLine($"el valor del primero ahora es: {uno} y el del segundo: {dos}");
        #endregion
       
        #region Circunferencia
        Console.WriteLine("Introduce en consola el valor del radio para calcular el area sombreada entre las circunferencias");
        double radio = double.Parse(Console.ReadLine()!);          
        // se calculo el area como dos veces el area del triangulo eqilatero mas 4 veces el area de del sector circular menos el area del triangulo equilatero
        //double areaTriangulo = (radio*radio)*(Math.Sqrt(3)/4); double areaSector= (1/6)*Math.PI*radio*radio - areaTriangulo;
        double raizDeTres=(Math.Sqrt(3));
       
        double areaRegion=((radio*radio)*((4*Math.PI-3*raizDeTres)/6)); // forma simplificada de todos los calculos

        Console.WriteLine($"Area de la Region = {areaRegion} u^2");
        #endregion 
        
        #region Ecuacion Cuadratica
        double coeficiente1=double.Parse(Console.ReadLine()!),coeficiente2=double.Parse(Console.ReadLine()!),coeficiente3=double.Parse(Console.ReadLine()!);
        
        double Discriminante=coeficiente2*coeficiente2-(4*(coeficiente1*coeficiente3));

        double solution1=(-coeficiente2+Math.Sqrt(Discriminante))/2*coeficiente1, solution2=(-coeficiente2-Math.Sqrt(Discriminante))/2*coeficiente1;

        Console.WriteLine($"La solucion 1 es:{solution1}; y la segunda: {solution2}.");
        #endregion
        
        #region Velocidad de escritura
       
        Console.WriteLine("Introduce un texto para medir la velocidad de escritura");
        double tickCount=Environment.TickCount;
       
        string texto=Console.ReadLine()!;
        
        double tickCount2=Environment.TickCount;

        Console.WriteLine($"Velocidad de escritura {((tickCount2-tickCount)/1000)}ms , con una velocidad de {(texto.Length/((tickCount2-tickCount))/1000):F2} caracteres/s "); 
        #endregion
        
        #region Fecha de Nacimiento
        
        Console.WriteLine("Introduce un numero de identidad");
        
        long id=long.Parse(Console.ReadLine()!);

        long fecha=  id/100000;

        long dia= (fecha%100);

        long mes=(fecha/100)%100;

        long año=fecha/10000;

        Console.WriteLine($"{dia}/{mes}/{año}");
        #endregion
    }
}
