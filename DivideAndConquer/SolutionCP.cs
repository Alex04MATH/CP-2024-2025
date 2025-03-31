using DivideAndConquer;

public class Solution
{
    static int MinimizeMaxPages(int[] arr, int k)
    {
       int page=SumArray(arr)/k;
       
    }
    static int SumArray(int[] arr)
    {
        int k=0;
        for(int i=0;i< arr.Length; i++)
        {
          k+=arr[i];
        }
        return k;
    }
}