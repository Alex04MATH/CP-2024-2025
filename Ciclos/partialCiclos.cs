partial class Solution
{
    public static int[] MezclaOrdenada(int[] arr, int[] arr1)
    {
        int[] arr2 = new int[arr.Length + arr1.Length];
        for (int i = 0, j = 0, k = 0; k < arr2.Length;)
        {
            if (validPosicion(arr.Length, i) && validPosicion(arr1.Length, j))
            {
                if (arr[i] <= arr1[j])
                {
                    arr2[k] = arr[i];
                    k++;
                    i++;
                }
                if (arr1[j] <= arr[i])
                {
                    arr2[k] = arr1[j];
                    k++;
                    j++;
                }
            }
            else if (!validPosicion(arr.Length, i) && validPosicion(arr1.Length, j))
            {
                arr2[k] = arr1[j];
                k++;
                j++;
            }
            else if (validPosicion(arr.Length, i) && !validPosicion(arr1.Length, j))
            {
                arr2[k] = arr[i];
                k++;
                i++;
            }
        }
        return arr2;
    }
    private static bool validPosicion(int tamaño, int i)
    {
        if (i >= tamaño) return false;
        return true;
    }
    public static dynamic[] AñadiendoFinal(dynamic[] arr, dynamic final)
    {
        dynamic[] arr1 = new dynamic[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            arr1[i] = arr[i];
        }
        arr1[arr1.Length - 1] = final;
        return arr1;
    }
    public static int[] Insert(int[] arr, int val, int pos)
    {
        if (pos < 0 || (pos >= arr.Length && pos != 0)) throw new NotImplementedException();
        int[] arr1 = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < arr1.Length; i++, j++)
        {
            if (j == pos)
            {
                arr1[i] = val;
                i++;
            }
            arr1[i] = arr[j];
        }
        return arr1;
    }
    public static int[] Elimnando(int[] arr, int pos)
    {
        if (pos < 0 || (pos >= arr.Length && pos != 0)) throw new Exception();
        int[] arr1 = new int[arr.Length - 1];
        for (int i = 0, j = 0; j < arr.Length; i++, j++)
        {
            if (j == pos)
            {
                if (j + 1 == arr.Length) break;
                j++;
            }
            arr1[i] = arr[j];
        }
        return arr1;
    }
    public static string DecimalBinary(int x)
    {
        if (x < 0) throw new Exception();
        int[] systemnum = { 0, 1 };
        string num = "";
        if (x < 2) return num = $"{x}";
        for (int i = 2; x >= 2;)
        {
            num += $"{x % i}";
            x = x / i;
            if (x < 2) num += x;
        }
        return invert(num);
    }
    private static string invert(string s)
    {
        string a = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            a += s[i];
        }
        return a;
    }
    public static int BinaryDecimal(string s)
    {
        int n = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1') n += (int)Math.Pow(2, (s.Length - 1) - i);
        }
        return n;
    }
    public static bool PerfectNumber(int x)
    {
        int divisor=1;
        if(x<6) return false;

        for(int i=2;i<=x/2;i++)
        {
            if(x%i==0)
            {
                divisor+=i;
            }
        }
        if(x==divisor) return true;
        else return false;
    }
    public static bool DetermSubstring(string substring,string s)
    {
       if(substring.Length>s.Length) return false;
       int contador=0;
       bool index=false;
       for(int i=0;i<substring.Length;i++)
       {
        for(int j=0;j<s.Length;j++)
        {
          if(substring[i]==s[j])
          {
            if(i+1==substring.Length) return true;
            i++;
            contador=j;
            index=true;
          }
          else if(index==true && (contador+1 == j)) return false;
        }
       }
       return false;
    }
}
