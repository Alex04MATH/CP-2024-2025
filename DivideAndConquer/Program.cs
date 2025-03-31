
using DivideAndConquer;

/*int[] arr1 = { 3, 5, 1, 2, 5, 2, 7, 10, 2, 2 };
Console.WriteLine("Sum of array elements (brute): " + SumArrayBrute.SumArray(arr1));
Console.WriteLine("Sum of array elements (normal): " + SumArrayRecursive.SumArray(arr1, 0, arr1.Length - 1));

int[] arr2 = { 1, 3, 3, 4, 5, 8, 9, 10, 11, 12 };
int target = 4;

Console.WriteLine(BinarySearchBrute.BinarySearch(arr2, target) ? $"Element found (brute)" : "Element not found (brute)");
Console.WriteLine(BinarySearchRecursive.BinarySearch(arr2, 0, arr2.Length - 1, target) ? $"Element found (brute)" : "Element not found (normal)");
*/

int[] arr3 = { -7,6,12,11,-70,4,-3,2};
Console.WriteLine("Maximum Subsequence Sum (brute): " + MaxSubarrayBrute.MaxSubarraySum(arr3));
Console.WriteLine("Maximum Subsequence Sum (normal): " + MaxSubarrayRecursive.MaxSubarraySum(arr3));