using System.Net;
using System.Runtime.InteropServices;

public partial class Solution
{
    public static int HowManyNumbers(int k, int[] arr)
    {
        int count = 1;
        int value =0 ;
        for (int i = 0; i < arr.Length; i++)
        {
            for(int j=(i+1)%arr.Length;j !=i ;j=(j+1)%arr.Length)
            {
               if(arr[j] == arr[i]) count++;
            }
            if(count==k) value++;
            count=1;
        }
        return value/k;
    }
    public static int SistemaDeNumeracion(char[] num, string a)
    {
        string b = "";
        int number = 0;
        int baseNum = num.Length;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            b += a[i];
        }

        for (int j = 0; j < b.Length; j++)
        {
            for (int k = 0; k < num.Length; k++)
            {
                if ((num[k] == b[j]))
                    number += k * (int)Math.Pow(baseNum, j);
            }
        }
        return number;
    }
    public static string SistemaDeNumeracionInvertido(char[] num, int a)
    {
        int basenum = num.Length;
        List<int> position = new List<int>();
        string b = "";
        while (a >= basenum)
        {
            int rest = 0;
            rest = a % basenum;
            a = a / basenum;
            position.Add(rest);

        }
        if (a < basenum) position.Add(a);

        for (int i = position.Count - 1; i >= 0; i--)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (position[i] == j) b += num[j];
            }
        }
        return b;
    }

    public static int MinDiff(int[] arr)
    {
        int min = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                int pos = (i + j) % arr.Length;
                int absDiff = Math.Abs(arr[pos] - arr[i]);
                if (absDiff < min) min = absDiff;
            }
        }

        return min;
    }
    public static bool Consecutive(int[] arr, int k)
    {
        int element = arr[0];
        int repetition = 1;
        bool exist = false;
        if (k < repetition) return exist;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                repetition++;
            }
            else if (repetition == k)
            {
                exist = true;
                break;
            }
            else
            {
                element = arr[i];
                repetition = 1;
            }
        }

        return exist;
    }
    public static int MaxSumSub(int[] arr)
    {
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = arr.Length - 1; j >= i; j--)
            {
                sum = Sum(arr, i, j);
                if (sum > maxSum) maxSum = sum;
                sum = 0;
            }
        }
        return maxSum;
    }

    private static int Sum(int[] arr, int i, int j)
    {
        int sum = 0;

        for (; i <= j; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public static int CountInversions(int[] arr)
    {
        int inversions = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    inversions++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return inversions;
    }
    public static bool Anagrams(string str, string str1)
    {
        if (str == str1) return true;
        if (str.Length != str1.Length) return false;
        str = str.ToUpper();
        str1 = str1.ToUpper();
        bool isAnagram = true;
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str1.Length; j++)
            {
                if (str[i] == str1[j])
                {
                    str1 = str1.Remove(j, 1);
                }
            }
        }
        if (str1 != "") isAnagram = false;
        return isAnagram;
    }

    public static int MaxSubSetAnagram(string[] arrStr)
    {
        int CardinalSubset = 0;
        int maxSubset = 0;
        for (int i = 0; i < arrStr.Length; i++)
        {
            for (int j = 0; j < arrStr.Length; j++)
            {
                if (Anagrams(arrStr[i], arrStr[j]))
                {
                    CardinalSubset++;
                }
                if (CardinalSubset > maxSubset) maxSubset = CardinalSubset;
            }
            CardinalSubset = 0;
        }
        return maxSubset;
    }

    public static int Occurrences(string text, string word)
    {
        int occurrences = 0;
        string build = "";
        string[] textSplit = text.Split(" ");
        for (int i = 0; i < textSplit.Length; i++)
        {
            if (textSplit[i].Length < word.Length) continue;
            int index = 0;
            for (int j = 0, k = 0; j < textSplit[i].Length; j++)
            {
                if (textSplit[i].Length - index >= word.Length - build.Length)
                {
                    if (k >= word.Length) k = 0;
                    if (textSplit[i][j] == word[k])
                    {
                        index = j;
                        build += textSplit[i][j];
                        k++;
                        if (build == word)
                        {
                            occurrences++;
                            k = 0;
                            build = "";
                            if (word.Length > 1)
                            {
                               
                                build += word[k];
                                k++;
                            }
                        }
                        if (textSplit[i].Length - index < word.Length - build.Length)
                        {
                            break;
                        }

                    }
                }
                else break;
            }
            build = "";
        }

        return occurrences;
    }
}