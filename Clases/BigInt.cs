
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Numerics;

public class BigInt
{
    private string num;
    private char[] digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    private int Length;
    private string numInvert;
    public string GetString { get => num; }
    public BigInt(string num)
    {
        if (!validateNum(num)) new NotImplementedException();
        this.num = CreateBigInt(num);
        this.numInvert = invertString(this.num);
        Length = num.Length;
    }
    public BigInt()
    {
        this.num = "0";
        this.numInvert = num;
        Length = num.Length;
    }

    private static string CreateBigInt(string num)
    {
        string newNum = "";
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] != '0') newNum += num[i];
        }

        return newNum == "" ? "0" : newNum;
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
        var invert = str.ToCharArray();
        Array.Reverse(invert);
        str = new string(invert);
        return str;
    }

    private static int Value(Char num)
    {
        int val = 0;
        char[] digit = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

        for (int i = 0; i < digit.Length; i++)
        {
            if (num == digit[i])
            {
                val = i;
                break;
            }
        }
        return val;
    }

    private static int Value(string num)
    {
        int value = 0;
        int Length = num.Length;
        for (int i = 0; i < Length; i++)
        {
            value += (int)Math.Pow(10, (Length - 1) - i) * Value(num[i]);
        }
        return value;
    }

    public static BigInt operator +(BigInt bigInt1, BigInt bigInt2)
    {
        string num = "";
        int arras = 0;
        for (int i = 0; i < Math.Max(bigInt1.Length, bigInt2.Length); i++)
        {
            if (i >= bigInt1.Length)
            {
                int value1 = Value(bigInt2.numInvert[i]) + arras;
                num += value1 % 10;
                arras = value1 / 10;
                continue;
            }
            if (bigInt2.Length <= i)
            {
                int value2 = Value(bigInt1.numInvert[i]) + arras;
                num += value2 % 10;
                arras = value2 / 10;
                continue;
            }
            int value = Value(bigInt1.numInvert[i]) + Value(bigInt2.numInvert[i]) + arras;
            num += value % 10;
            arras = value / 10;
        }
        if (arras == 1) num += 1;
        num = invertString(num);
        return new BigInt(num);
    }

    public static BigInt operator -(BigInt bigInt1, BigInt bigInt2)
    {
        if (bigInt1.Length < bigInt2.Length) throw new Exception();
        if (bigInt1.Length == bigInt2.Length && (Value(bigInt1.num[0])) < Value(bigInt2.num[0])) throw new Exception();
        string num = "";
        for (int i = 0; i < bigInt1.Length; i++)
        {
            num += Value(bigInt1.numInvert[i]) - Value(bigInt2.numInvert[i]);
        }
        num = invertString(num); //cambiar el calcúlo en for desde el ultimo para ejecutar mas rápido con StringBuilder
        return new BigInt(num);
    }

    public static BigInt operator *(BigInt bigInt1, BigInt bigInt2)
    {
        int val = Value(bigInt1.num);
        int val1 = Value(bigInt2.num);
        string num = $"{val * val1}";

        return new BigInt(num);
    }

    public static BigInt operator /(BigInt bigInt1, BigInt bigInt2)
    {
        int val = Value(bigInt1.num);
        int val1 = Value(bigInt2.num);
        string num = $"{val / val1}";

        return new BigInt(num);
    }

    public static BigInt operator %(BigInt bigInt1, BigInt bigInt2)
    {
        int val = Value(bigInt1.num);
        int val1 = Value(bigInt2.num);
        string num = $"{val % val1}";

        return new BigInt(num);
    }

    public static BigInt Pow(BigInt bigInt, int exponent)
    {
        int val = Value(bigInt.num);
        string num = $"{(int)Math.Pow(val, exponent)}";

        return new BigInt(num);
    }

    public static bool operator ==(BigInt bigint1, BigInt bigInt2)
    {
        if (bigint1.num == bigInt2.num) return true;

        return false;
    }

    public static bool operator !=(BigInt bigInt1, BigInt bigInt2)
    {
        if (bigInt1.num == bigInt2.num) return false;

        return true;
    }

    public static bool operator >(BigInt bigint1, BigInt bigInt2)
    {
        if (bigint1.Length < bigInt2.Length) return false;
        if ((bigint1 == bigInt2 && Value(bigint1.num[0]) < Value(bigInt2.num[0])) || bigint1 == bigInt2) return false;

        return true;
    }

    public static bool operator <(BigInt bigint1, BigInt bigint2)
    {
        if (bigint1 > bigint2 || bigint1 == bigint2) return false;

        return true;
    }

    public static bool operator >=(BigInt bigint1, BigInt bigint2)
    {
        return (bigint1 > bigint2) || (bigint2 == bigint1);
    }
    public static bool operator <=(BigInt bigint1, BigInt bigint2)
    {
        return (bigint1 < bigint2) || (bigint1 == bigint2);
    }
}