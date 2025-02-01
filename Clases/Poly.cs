using System.ComponentModel;
using System.Dynamic;
using System.Text;

class Poly
{
    private int[] polinomio;
    public int[] Polinomio { get => polinomio; }
    private int gradePoly;
    
    public int GradePoly
    {
        get => gradePoly;
    }

    public int[] NewPoly(int[] polinomio)
    {
        this.polinomio = polinomio;
        this.gradePoly = Grade(polinomio);
        return polinomio;
    }
    public Poly(int[] polinomio)
    {
        this.polinomio = polinomio;
        this.gradePoly = Grade(polinomio);
    }
    public void addCoeficiente(int[] coeficiete)
    {
        if (coeficiete.Length != this.gradePoly) throw new Exception();
        polinomio = coeficiete;
    }
    private int Grade(int[] polinomio)
    {
        int pos = polinomio.Length - 1;
        if (polinomio[pos] != 0) return polinomio.Length-1;
        else if(pos-1>=0)   
            for (int i = pos=1; i >= 0; i--)
            {
                if (polinomio[i] != 0) return i;
                 
            }
        
        return 0;
    }
    public int GetCoef(int k)
    {
        if(k<0) throw new Exception();
        else if(k>gradePoly) return 0;
        return polinomio[k];
    }
   

    public new string ToString()
    {
        string s = "";
        int antvalue=0;
        for (int i = polinomio.Length - 1; i >= 0; i--)
        {
            if(polinomio[i] == 0) continue;
            s+=form(i,polinomio[i],antvalue);
            antvalue=polinomio[i];
        }
        if(polinomio.Length>0 && s=="") return "0";
        return s;
    }
    private static string form(int index,int value,int antvalue)
    {
        if(value==0) return "";  
        
        return $"{antvalueString(value,antvalue)}{exponencialString(index)}";
    }
    private static string antvalueString(int value,int antvalue)
    {
       if(antvalue==0)
       {
         if(value>0) return $"{value}";
       }
       if(value>0) return $"+{value}";

       return $"{value}";
    }
    private static string exponencialString(int index)
    { 
        if(index==0) return "";
        else if(index==1) return "x";
        return $"x^{index}";
    }
    public static Poly operator +(Poly poly1,Poly poly2)
    {
        int a=poly1.polinomio.Length;
        int b=poly2.polinomio.Length;
        int[]arr=new int[Math.Max(a,b)];
        for(int i=0;i<arr.Length;i++)
        {
            if(i>=a)
            {
                arr[i]=poly2.polinomio[i];
                continue;
            }      
            if(i>=b)
            {
                arr[i]=poly1.polinomio[i];
                continue;
            }
            arr[i]=poly1.polinomio[i]+poly2.polinomio[i];
        }
        return new Poly(arr);
    }
    public static Poly operator *(Poly poly1,Poly poly2)
    {
        int a=poly1.polinomio.Length-1;
        int b=poly2.polinomio.Length-1;
        int[]arr=new int[a+b+1];
        for(int i=0;i<=a;i++)
        {
            for(int j=0;j<=b;j++)
            {
                arr[i+j]+=poly1.polinomio[i]*poly2.polinomio[j];
            }
        }
        return new Poly(arr);
    }
    public static Poly operator *(int x,Poly poly)
    {
        int[] arr=new int[poly.polinomio.Length];
        for(int i=0;i<poly.polinomio.Length;i++)
        {
            arr[i]=x*poly.polinomio[i];
        }
        return new Poly(arr);
    }
    public static bool operator ==(Poly poly1, Poly poly2)
    {
        if(poly1.polinomio.Length != poly2.polinomio.Length) return false;
        for(int i=0;i<poly1.polinomio.Length;i++)
        {
            if(poly1.polinomio[i] != poly2.polinomio[i]) return false;
        }
        return true;
    }
    public static bool operator !=(Poly poly1, Poly poly2)
    {
        return !(poly1==poly2);
    }
    public static bool operator >(Poly poly1, Poly poly2)
    {
        if(poly1.polinomio.Length>poly2.polinomio.Length) return true;
        if(poly1.polinomio.Length<poly2.polinomio.Length) return false;
        for(int i=0;i<poly1.polinomio.Length;i++)
        {
            if(poly1.polinomio[i]<poly2.polinomio[i]) return false;
        }
        return true && (poly1!=poly2);
    }
    public static bool operator <(Poly poly1,Poly poly2)
    {
        return !(poly1>poly2) && (poly1!=poly2);
    }
    public static bool operator >=(Poly poly1,Poly poly2)
    {
        return (poly1>poly2) || (poly1==poly2);
    }
    public static bool operator <=(Poly poly1,Poly poly2)
    {
        return (poly1<poly2) || (poly1==poly2);
    }
    
    public static Poly operator /(Poly poly1,Poly poly2)
    {
        //implementar Exeption cuando poly2.grade ==0
        int _newpolygrade=poly1.polinomio.Length-poly2.gradePoly;
        int[]arr=new int[_newpolygrade+1];
        int i=poly1.gradePoly;
        for(;i>=poly2.gradePoly;i--)
        {
          int division=poly1.polinomio[i]/poly2.polinomio[poly2.gradePoly];
          int index=i-poly2.gradePoly;
          int resto=poly1.polinomio[i]%poly2.polinomio[poly2.gradePoly];
          arr[index]=division;
          Poly polyx=calculateMonicPoly(index);
          poly1+=(-division)*(poly2*polyx)+(-1*restoIntDivisor(poly2.gradePoly,resto)*polyx);
        }
        
        return new Poly(arr);
    }
    private static Poly calculateMonicPoly(int index)
    {
        int[]arr=new int[index+1];
        arr[index]=1;
        return new Poly(arr);
    }
    private static Poly restoIntDivisor(int index,int value)
    {
        int[]arr=new int[index+1];
        arr[index]=value;
        return new Poly(arr);
    }
    public static Poly operator %(Poly poly1,Poly poly2)
    {
        //implementar Exeption cuando poly2.grade ==0
        int[] arr;
        int i=poly1.gradePoly;
        for(;i>=poly2.gradePoly;i--)
        {
          int division=poly1.polinomio[i]/poly2.polinomio[poly2.gradePoly];
          int index=i-poly2.gradePoly;
          int resto=poly1.polinomio[i]%poly2.polinomio[poly2.gradePoly];
          Poly polyx=calculateMonicPoly(index);
          poly1+=(-division)*(poly2*polyx)+(-1*restoIntDivisor(poly2.gradePoly,resto)*polyx);
        }
        arr=poly1.polinomio;
        return new Poly(arr);
    }
    public static Poly Dx(Poly poly1)
    {
      if(poly1.gradePoly==0) return new Poly([0]);
      int[] arr=new int[poly1.polinomio.Length-1];
      for(int i=arr.Length-1,j=poly1.polinomio.Length-1;i>=0;i--,j--)
      {
        if(poly1.polinomio[j]==0)
        {
            continue;
        }
        arr[i]=poly1.polinomio[j]*j;
      }
      return new Poly(arr);
    }
    public static int EvaluateX(Poly poly,int value)
    {
        int evaluate=0;
        if(poly.gradePoly==0 && poly.polinomio.Length !=0) return poly.polinomio[0];
        if(poly.polinomio.Length==0) return 0; 
        for(int i=0;i<poly.polinomio.Length;i++)
        {
            evaluate+=poly.polinomio[i]*(int)Math.Pow(value,i);
        }
        return evaluate;
    }
}