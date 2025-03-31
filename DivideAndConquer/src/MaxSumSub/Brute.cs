namespace DivideAndConquer;

public class MaxSubarrayBrute
{
    static int MaxCrossingSum(int[] arr)
    {
        int mid = arr.Length / 2;

        int leftSum = int.MinValue, tempSum = 0;
        for (int i = mid - 1; i >= 0; i--)
        {
            tempSum += arr[i];
            if (tempSum > leftSum)
                leftSum = tempSum;
        }

        int rightSum = int.MinValue;
        tempSum = 0;
        for (int i = mid; i < arr.Length; i++)
        {
            tempSum += arr[i];
            if (tempSum > rightSum)
                rightSum = tempSum;
        }

        return leftSum + rightSum;
    }

    public static int MaxSubarraySum(int[] arr)
    {
        if (arr.Length == 1)
            return arr[0];

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        int leftSum = MaxSubarraySum(left);
        int rightSum = MaxSubarraySum(right);
        int crossingSum = MaxCrossingSum(arr);

        return Math.Max(leftSum, Math.Max(rightSum, crossingSum));
    }
}