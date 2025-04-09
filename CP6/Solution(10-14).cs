using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Formats.Asn1;

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

    public static int[] ReverseSubArray(int[] items, int k)
    {

        int tall = k - 1;
        for (int i = 0, j = tall; i < items.Length && j < items.Length; i = ++j, j = i + tall)
        {
            for (int pointer = i, pointer1 = j; j - (j - i) / 2 <= pointer1 && j - (j - i) / 2 >= pointer; pointer++, pointer1--)
            {
                int temp = items[pointer];
                items[pointer] = items[pointer1];
                items[pointer1] = temp;
            }
        }
        return items;
    }

    public static int[] SortbyProximity(int[] arr, int pivot)
    {
        bool[] isNegative = new bool[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] -= pivot;
            if (arr[i] < 0) isNegative[i] = true;
            arr[i] = Math.Abs(arr[i]);
        }

        return Sort(arr, isNegative, pivot);
    }
    private static int[] Sort(int[] arr, bool[] isNegative, int pivot)
    {
        (int, bool) index, index1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                index = (arr[i], isNegative[i]);
                index1 = (arr[j], isNegative[j]);
                if (index.Item1 >= index1.Item1)
                {
                    if (index.Item1 == index1.Item1 && (index.Item2 != index1.Item2 && index.Item2 == false))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = arr[i];
                        isNegative[i] = true;
                        isNegative[j] = false;
                    }
                    else
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        bool temp1 = isNegative[i];
                        isNegative[i] = isNegative[j];
                        isNegative[j] = temp1;

                    }
                }
            }
        }
        return sumArr(arr, isNegative, pivot);
    }
    private static int[] sumArr(int[] arr, bool[] isNegative, int pivot)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (isNegative[i]) arr[i] = -arr[i] + pivot;
            else arr[i] += pivot;
        }
        return arr;
    }

    public static int[] SolveDistributionChocolate(int[] arr, int student)
    {
       int sum=0;
       for (int i = 0;i<arr.Length;i++)
       {
           sum+=arr[i];
       }
       if(sum<student) return new int[] {};

       int[] DistributionByStudent=new int[student];
       int div=sum/student;
       int rest=sum%student;
       for (int i=0;i<DistributionByStudent.Length;i++)
       {
         int temp=0;
         if(rest<=0) rest = 0;
         else temp=1;
         DistributionByStudent[i]=div+temp;
         rest--;
       }

       return DistributionByStudent;
    }
}