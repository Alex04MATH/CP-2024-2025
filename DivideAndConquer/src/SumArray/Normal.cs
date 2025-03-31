namespace DivideAndConquer;
public class SumArrayRecursive
{
    public static int SumArray(int[] arr, int left, int right)
    {
        if (arr.Length == right)
            return arr[left];

        int mid = left+ (right-left)/ 2;
        int sum=SumArray(arr,left,mid);
        int sum2=SumArray(arr,mid+1,right);

        return sum+sum2;
    }
}