public partial class Solution
{
    #region Ordenacion y Busqueda
    public static int[] BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] > arr[j])
                {
                    Swap(ref arr[i], ref arr[j]);
                }
        }
        return arr;
    }
    private static void Swap(ref int num, ref int i)
    {
        int temp = num;
        num = i;
        i = temp;
    }
    public static bool BinarySearch(int[] arr, int position)
    {
        for (int l = 0, r = arr.Length - 1; l <= r;)
        {
            int medium = (l + r) / 2;
            if (arr[medium] < position) l = medium + 1;
            else if (arr[medium] > position) r = medium - 1;
            else return true;
        }

        return false;
    }

    public static int[] SelectionSort(int[] arr)
    {
        if (arr.Length == 0 || arr.Length == 1) return arr;

        bool inversions = true;
        int i;
        int j;
        while (inversions)
        {
            inversions = false;
            for (int k = 0; k < arr.Length - 1; k++)
            {
                i = arr[k];
                j = arr[k + 1];

                if (j < i)
                {
                    int temp = i;
                    arr[k] = j;
                    arr[k + 1] = temp;
                    inversions = true;
                }
            }

        }
        return arr;
    }
    #endregion
}