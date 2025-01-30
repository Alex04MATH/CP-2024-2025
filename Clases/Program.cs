class Program
{
    private static void Main()
    {
       Poly poly=new Poly([2,2,0,7,9,10]);
       Poly poly1=new Poly([4,3,2,1,3]);
       System.Console.WriteLine(poly.GradePoly);
       System.Console.WriteLine((poly+poly).ToString());
       System.Console.WriteLine((3*poly).ToString());
    }
}