namespace DivideAndConquer;

public class SumArrayBrute
{
    public static int SumArray(int[] arr)
    {
        if (arr.Length == 1)
            return arr[0];

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        // Divide!
        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        // Conquer!
        return SumArray(left) + SumArray(right);
    }
}