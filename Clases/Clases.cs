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

       return $"-{value}";
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
                break;
            }      
            if(i>=b)
            {
                arr[i]=poly1.polinomio[i];
                break;
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
        for(int i=0;i<poly.polinomio.Length;i++)
        {
            poly.polinomio[i]=x*poly.polinomio[i];
        }
        return poly;
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
}