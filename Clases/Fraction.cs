public class Fraction
{
    private string fraction;
    private int numerator;
    private int denominator;
    private string[] simplify { get => Simplify(numerator, denominator); }
    public int GetNumerator { get => int.Parse(simplify[0]); }
    public int GetDenominator { get => int.Parse(simplify[1]); }
    public string FractionSimplify { get => simplify[2]; }
    public Fraction(int numerator, int denominator)
    {
        if (denominator != 0)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.fraction = $"{numerator}/{denominator}";
        }
        else throw new Exception();
    }
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
        this.fraction = $"{numerator}";
    }
    public Fraction()
    {
        this.numerator = 0;
        this.denominator = 1;
        this.fraction = $"{numerator}";
    }
    private static string[] Simplify(int numerator, int denominator)
    {
        int divisor = MCD(numerator, denominator);
        String[] arr = new string[3];
        arr[0] = $"{numerator / divisor}";
        arr[1] = $"{denominator / divisor}";
        if (numerator / divisor == 0)
        {
            arr[2] = "0";
            return arr;
        }
        if (denominator / divisor == 1)
        {
            arr[2] = $"{numerator / divisor}";
            return arr;
        }
        arr[2] = $"{numerator / divisor}/{denominator / divisor}";
        return arr;
    }
    public static Fraction operator +(Fraction fraction1, Fraction fraction2)
    {
        int minCM = mcm(fraction1.denominator, fraction2.denominator);
        int numerator = (fraction1.denominator / minCM) * fraction1.numerator + (fraction2.denominator / minCM) * fraction2.numerator;

        return new Fraction(numerator, minCM);
    }

    public static Fraction operator *(int num, Fraction fraction)
    {
        return new Fraction(num * fraction.numerator, fraction.denominator);
    }

    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        fraction2 = -1 * fraction2;
        fraction1 = fraction1 + fraction2;
        return new Fraction(fraction1.numerator, fraction2.denominator);
    }
    public static Fraction operator *(Fraction fraction1, Fraction fraction2)
    {
        return new Fraction(fraction1.numerator * fraction2.numerator, fraction1.denominator * fraction2.denominator);
    }

    public static Fraction operator /(Fraction fraction1, Fraction fraction2)
    {
        return new Fraction(fraction1.numerator * fraction2.denominator, fraction1.denominator * fraction2.numerator);
    }
    public static bool operator >(Fraction fraction1, Fraction fraction2)
    {
        if (fraction1.GetDenominator > fraction2.GetDenominator) return false;
        else if (fraction1.GetDenominator == fraction2.GetDenominator)
        {
            if (fraction1.GetNumerator > fraction2.GetNumerator) return true;
            else return false;
        }
        return true;
    }

    public static bool operator <(Fraction fraction1, Fraction fraction2)
    {
        return !(fraction1 > fraction2);
    }
    public static bool operator ==(Fraction fraction1, Fraction fraction2)
    {
        if (fraction1.GetNumerator != fraction2.GetNumerator) return false;
        if (fraction2.GetDenominator != fraction1.GetDenominator) return false;
        return true;
    }
    public static bool operator !=(Fraction fraction1, Fraction fraction2)
    {
        return !(fraction1 == fraction2);
    }
    private static int mcm(int x, int y)
    {
        if (x == y) return x;
        if (x == 1 || y == 1) return Math.Max(x, y);
        if (x == 0 || y == 0) return 1;
        int upDivisor = Math.Max(x, y);
        int divx = 1;
        int divy = 1;
        for (int i = 2; i <= upDivisor; i++)
        {
            if (x % i == 0)
            {
                divx *= i;
            }
            if (y % i == 0)
            {
                divy *= 0;
            }
        }
        return divx * divy;
    }
    private static int MCD(int numerator, int denominator)
    {
        if (numerator == denominator) return numerator;
        if ((numerator == 1 || denominator == 1) || (numerator == 0 || denominator == 0)) return 1;
        int mcd = 1;
        int min = Math.Min(numerator, denominator);
        for (int i = 2; i <= min; i++)
        {
            if (numerator % i == 0 && denominator % i == 0)
            {
                mcd *= i;
            }
        }
        return mcd;
    }
}