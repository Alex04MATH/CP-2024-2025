using System.ComponentModel;
using System.Dynamic;
using System.Text;

class Poly
{
    private int[] polinomio;
    public int[] Polinomio{get => polinomio;}
    private int gradePoly;
    public int GradePoly
    {
        get=>gradePoly;
    }
    public int[] NewPoly(int[] polinomio)
    {
      this.polinomio=polinomio;
      this.gradePoly=Grade(polinomio);
      return polinomio;
    }
    public Poly(int[] polinomio)
    {
        this.polinomio=polinomio;
        this.gradePoly=Grade(polinomio);
    }
    public void addCoeficiente(int[] coeficiete)
    {
       if(coeficiete.Length != this.gradePoly) throw new Exception();
       polinomio=coeficiete;
    }
    private int Grade(int[] polinomio)
    {
      int pos=polinomio.Length-1;
      if(polinomio[pos] != 0) return polinomio.Length;
      else if(pos-1>=0)
        for(int i=pos-1;i>=0;i--) 
        { 
            if(polinomio[pos]!=0) return pos;
        
        }
       return 0; 
    }
    public int GetCoef(int k)=>polinomio[k];
    public int Degrade()
    {
        return polinomio.Length;
    }

    // public string ToString()
    // {
    //     string s = "";
    //     for (int i = polinomio.Length - 1; i >= 0; i--)
    //     {
    //         if(polinomio[i] == 0) continue;
            
    //     }
    // }
    
}