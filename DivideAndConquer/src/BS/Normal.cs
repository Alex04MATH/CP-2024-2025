namespace DivideAndConquer;

public class BinarySearchRecursive
{
    public static bool BinarySearch(int[] arr, int left, int right, int target)
    {
        if (arr.Length == 0)
            return false; // Base case: empty array

        int mid =left+(right-left)/2;

        if (arr[mid] == target)
            return true; // Element found
        if(arr[mid]<target)
         return BinarySearch(arr,left,mid,target);
       
         return BinarySearch(arr,mid,arr.Length-1,target);
    }
}