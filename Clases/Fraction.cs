public class Fraction
{
    private string fraction;
    private int numerator;
    private int denominator;
    public int GetNumerator{get=>numerator;}
    public int GetDenominator{get=>denominator;}
    public Fraction(int numerator,int denominator)
    {
        if(denominator !=0)
        {
        this.numerator=numerator;
        this.denominator=denominator;
        this.fraction=$"{numerator}/{denominator}";
        }
        else throw new Exception();    
    }
    public static Fraction operator +(Fraction fraction1,Fraction fraction2)
    {
       int minCM=mcm(fraction1.denominator,fraction2.denominator);
       int numerator=(fraction1.denominator/minCM)*fraction1.numerator+(fraction2.denominator/minCM)*fraction2.numerator;
       
       return new Fraction(numerator,minCM);
    }
    private static int mcm(int x, int y)
    {
      if(x==y) return x;
      if(x==1 || y==1) return Math.Max(x,y);
      if(x==0 || y==0) return 1;
      int upDivisor=Math.Max(x,y);
      int divx=1;
      int divy=1;
      for(int i=2;i<=upDivisor;i++)
      {
         if(x%i==0)
         {
            divx*=i;
         }
          if(y%i==0)
          {
            divy*=0;
          }
      }
      return divx*divy;
    }
}