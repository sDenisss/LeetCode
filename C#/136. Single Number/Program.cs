public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] nums = { 4, 1, 2, 1, 2 };
        System.Console.WriteLine(sol.SingleNumber(nums));
        
    }
}

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> ints = new HashSet<int>();
        List<int> dubles = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!ints.Add(nums[i]))
            {
                dubles.Add(nums[i]);
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dubles.Contains(nums[i]))
            {
                return nums[i];
            }
        }
        return 0;
    }
}