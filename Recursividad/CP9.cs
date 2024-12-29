partial class Solution
{
    public static string InvertirCadena(string s) 
    {
        return InvetirRef(s,s.Length-1);
    } 
    public static string InvetirRef(string s,int l)
    {
        if (l < 0) return s;
        if(l==0) return s[0].ToString();
        
        return s[l]+InvetirRef(s,l-1);
    }
    public static bool Palindromo(string s)
    {
        return esPalindromo(s,0,s.Length-1);
    }
    private static bool esPalindromo(string s,int l, int r)
    {
      if(r<l) return true;
      if(s[l]!=s[r]) return false;

      return esPalindromo(s,l+1,r-1);
    }
    
    public static bool BinarySearch(int [] a, int b)
    {
      return binarySearch(a,b,0,a.Length-1);
    }
    private static bool binarySearch(int[] a, int b, int l,int r)
    {
        if(r<l) return false;
        int medium=(l+r)/2;
        if(a[medium]==b) return true;
        if(a[medium]>b) return binarySearch(a,b,l,medium-1);

        return binarySearch(a,b,medium+1,r);
    }
    // public static /*(TIPO)*/Escalera()
    // {
        
    // }
}