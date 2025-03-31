namespace DivideAndConquer;
public class MaxSubarrayRecursive
{
    static int MaxCrossingSum(int[] arr, int left, int mid, int right)
    {
        throw new NotFiniteNumberException();
    }

    public static int MaxSubarraySum(int[] arr)
    {
        int[] carry = new int[arr.Length];
        int MaxCarry = int.MinValue;
        int MaxCarryIndex = -1;
        int MinNegative = 0;
        int MinNegativeIndex = 0;
        for(int i = 0; i < arr.Length;i++)
        {
            if(i == 0)
                carry[i] = arr[i];
            else
                carry[i] = carry[i-1] + arr[i];             
            if(carry[i] > MaxCarry)
            {
                MaxCarry = carry[i];
                MaxCarryIndex = i;
            }
            if(carry[i] < MinNegative)
            {
                MinNegative = carry[i];
                MinNegativeIndex = i;
            }
        }
        if(MinNegativeIndex < MaxCarryIndex && Math.Sign(carry[MinNegativeIndex]) == -1)
        {
            return carry[MaxCarryIndex] - carry[MinNegativeIndex];
        }
        return MaxCarry;
    }
}