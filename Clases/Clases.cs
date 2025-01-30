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
        for (int i = polinomio.Length - 1; i >= 0; i--)
        {
            if(polinomio[i] == 0) continue;
            s+=form(polinomio.Length - 1,i,polinomio[i]);
        }
        if(polinomio.Length>0 && s=="") return "0";
        return s;
    }
    private static string form(int polinomioL,int index,int value)
    {
        string s="";
        if(value==0) return s;
        else if(polinomioL==index && value>0) return s=$"{value}x^{index}";
        else if(value>0) return s=$" +{value}x^{index}";
        
        return $" +{value}x^{index}";
    }

}