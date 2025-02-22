
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public class BigInt
{
    private string num;
    private char[] digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    private int Length;
    private string numInvert;
    public string GetString{get=>num;}
    public BigInt(string num)
    {
        if (!validateNum(num)) new NotImplementedException();
        this.num = num;
        this.numInvert= invertString(num);
        Length=num.Length;
    }

    private static bool validateNum(string num)
    {
        char[] digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        for (int i = 0; i < num.Length; i++)
        {
            if (!digit.Contains(num[i])) return false;
        }
        return true;
    }
    private static string invertString(string str)
    {
       var invert=str.ToCharArray();
       Array.Reverse(invert);
       str=new string(invert);
       return str;
    }
    private static int Value(Char num)
    {
        int val=0;
        char[] digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

        for(int i = 0;i<digit.Length;i++)
        {
            if(num==digit[i])
            {
                val = i;
                break;
            }
        }
     return val;
    }
    public static BigInt operator +(BigInt bigInt1, BigInt bigInt2)
    {
        string num="";
        int arras=0;
        for(int i=0;i<Math.Max(bigInt1.Length, bigInt2.Length);i++)
        {
           if(i>=bigInt1.Length)
           {
             int value1=Value(bigInt2.numInvert[i])+arras;
             num+=value1%10;
             arras=value1/10;
             continue;
           }
           if(bigInt2.Length<=i)
           {
             int value2=Value(bigInt1.numInvert[i])+arras;
             num+=value2%10;
             arras=value2/10;
             continue;
           }
             int value=Value(bigInt1.numInvert[i])+Value(bigInt2.numInvert[i])+arras;
             num+=value%10;
             arras=value/10;
        }
        if(arras==1) num+=1;
        num=invertString(num);
       return new BigInt(num);
    }
}