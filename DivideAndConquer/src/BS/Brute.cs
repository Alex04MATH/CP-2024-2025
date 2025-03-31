namespace DivideAndConquer;
public class BinarySearchBrute
{
    public static bool BinarySearch(int[] arr, int target)
    {
        if (arr.Length == 0)
            return false; // Base case: empty array

        int mid = arr.Length / 2;

        if (arr[mid] == target)
            return true; // Element found

        if (arr[mid] > target)
        {
            int[] left = new int[mid];
            Array.Copy(arr, 0, left, 0, mid);
            return BinarySearch(left, target);
        }
        else
        {
            int[] right = new int[arr.Length - mid - 1];
            Array.Copy(arr, mid + 1, right, 0, arr.Length - mid - 1);
            return BinarySearch(right, target);
        }
    }
}