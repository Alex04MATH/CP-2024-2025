using System.Text;

class Poly
{
    public int[] polinomio;

    public int GradeCoeficiente(int coeficiente)
    {
        if (coeficiente >= polinomio.Length) ;
        
        return polinomio[coeficiente];
    }
    public int GetCoef(int k)=>polinomio[k];
    public int Degrade()
    {
        return polinomio.Length;
    }

    public string ToString()
    {
        string s = "";
        for (int i = polinomio.Length - 1; i >= 0; i--)
        {
            if(polinomio[i] == 0) continue;
            
        }
    }
    
}