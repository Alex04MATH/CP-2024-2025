class Program
{
    private static void Main()
    {
       Poly poly=new Poly([2,2,0,7,9,10]);
       Poly poly1=new Poly([4,3,2,1,3]);
    //    System.Console.WriteLine(poly.GradePoly);
    //    System.Console.WriteLine((poly+poly).ToString());
    //    System.Console.WriteLine((3*poly).ToString());
    //    System.Console.WriteLine(poly!=poly);
    //    System.Console.WriteLine((poly/poly1).ToString());
       Poly poly2=new Poly([2,3]);
       Poly poly3=new Poly([-6,-16,-13,-1]);
       poly3=poly2*poly1+poly3;
       System.Console.WriteLine((poly3).ToString());
       System.Console.WriteLine((poly%poly1).ToString());
    }
}