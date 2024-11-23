using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // int [] uno = BubbleSort([23,45,9238,1,3,30,29,0,-1]);
        // for (int i = 0; i < uno.Length; i++)
        // {
        //     Console.WriteLine(uno[i]);
        // }
        // Console.WriteLine(CualNumber(4,[4, 2, 4, 5, 6, 2, 7]));
        System.Console.WriteLine(SistemaDeNumeracion(['a','b','c'],"cbaa"));
        System.Console.WriteLine(SistemaDeNumeracionInvertido(['a','b','c'],63));
    }

    static int[] BubbleSort(int[] nums)
    {
        for(int i = 0; i< nums.Length-1; i++ )
        {
            for (int j = i+1; j< nums.Length;j++)
            if(nums[i]>nums[j])
            {
                Swap(ref nums[i], ref nums[j]);
            }
        }
     return nums;
    }
    static void Swap(ref int nums, ref int i)
    {
          int temp=nums;
          nums=i;
          i=temp;
    }
    static int CualNumber(int k, int [] arr)
    {
        int contador=0;

        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]==k)
            {
                ++contador;
            }
        }
        return contador;
    }
    static int SistemaDeNumeracion(char[] num, string a)
    {
        string b="";
        int numero=0;
        int baseNum=num.Length;
        for(int i=a.Length-1; i>=0; i--)
        {
            b+=a[i];
        }

        for(int j =0; j<b.Length ;j++)
        {
         for(int k=0;k<num.Length;k++)
         {
            if((num[k]==b[j]))
            numero+= k*(int) Math.Pow(baseNum,j);
         } 
        }
        return numero;
    }
    static string SistemaDeNumeracionInvertido(char[] num, int a)
    {
        int basenum=num.Length;
        List<int> posiciones=new List<int>();
        string b="";
        while(a>=basenum)
        {
            int residuo=0;
            residuo=a%basenum;
            a=a/basenum;
            posiciones.Add(residuo);if(a<basenum) posiciones.Add(a);
        }
        for(int i = posiciones.Count-1; i>=0;i--)
        {
            for(int j =0;j<num.Length;j++)
            {
                if(posiciones[i]==j) b+=num[j];
            }
        }
        return b;
    }
    }