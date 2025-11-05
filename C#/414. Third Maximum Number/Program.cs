using System;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] arr1 = { 3,2,1 };
        int[] arr2 = { 2,2,3,1 };
        System.Console.WriteLine(sol.ThirdMax(arr1));
        System.Console.WriteLine(sol.ThirdMax(arr2));
    }
}

public class Solution {
    public int ThirdMax(int[] nums)
    {
        HashSet<int> hashset = new HashSet<int>();
        // int[] resArr = new int[3];
        long first = long.MinValue;
        long second = long.MinValue;
        long third = long.MinValue;

        // int j = 0;
        // const int minIndex = 2;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!hashset.Add(nums[i])) continue;

            if (nums[i] > first)
            {
                third = second;
                second = first;
                first = nums[i];
            }
            else if (nums[i] > second)
            {
                third = second;
                second = nums[i];
            }
            else if (nums[i] > third)
            {
                third = nums[i];
            }
        }

        return third == long.MinValue ? (int)first : (int)third;
    }
}