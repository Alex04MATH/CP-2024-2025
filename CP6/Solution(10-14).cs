using System.ComponentModel.DataAnnotations.Schema;

public partial class Solution
{
    public static bool[] ErastotonSieve(int n)
    {
        bool[] Sieve = new bool[n];
        List<int> Prime = new List<int>();
        for (int i = 2; i < n; i++)
        {
            if (prime(i, Prime))
            {
                Prime.Add(i);
                Sieve[i] = true;
            }
        }
        return Sieve;
    }
    private static bool prime(int n, List<int> Prime)
    {
        foreach (int i in Prime)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static int[] ReverseSubArray(int[] items,int k)
    {
       
       int tall=k-1;
       for (int i = 0,j=tall;i<items.Length && j<items.Length;i=++j,j=i+tall)
       {
           for(int pointer=i,pointer1=j;j-(j-i)/2<=pointer1 && j-(j-i)/2>=pointer;pointer++,pointer1--)
           {
             int temp=items[pointer];
             items[pointer] = items[pointer1];
             items[pointer1] = temp;
           }
       }
       return items;
    }

    public static int[] SortbyProximity(int[] arr,int pivot)
    {
        bool[] mask=new bool[arr.Length];
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]>=0) mask[i]=true;
            arr[i]-=pivot;
            Math.Abs(arr[i]);
        }

        return 
    }
} 
    
    