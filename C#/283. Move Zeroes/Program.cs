using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 0,1,0,3,12 };

        int[] b = { 9,6,4,2,3,5,7,0,1 };


        Solution sol = new Solution();
        sol.MoveZeroes(a);
        sol.MoveZeroes(b);
    }
}

public class Solution {
    public void MoveZeroes(int[] nums) 
    {
        // int[] newNums = new int[nums.Length];

        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        for (int i = j; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}