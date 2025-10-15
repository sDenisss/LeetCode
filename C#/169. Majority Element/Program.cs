public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1 };
        int[] b = { 2, 2, 1, 1, 1, 2, 2 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.MajorityElement(a));
        System.Console.WriteLine(sol.MajorityElement(b));
    }
}


public class Solution {
    public int MajorityElement(int[] nums) 
    {
        int minOfAppears = nums.Length / 2;

        if (nums.Length == 1) 
            return nums[0];
        
        if (nums.Length % 2 != 0) 
            minOfAppears++;

        Dictionary<int, int> elements = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            // if its not first adding of unique el
            if (!elements.TryAdd(nums[i], 1))
            {
                elements[nums[i]]++;
                if (elements[nums[i]] >= minOfAppears)
                {
                    return nums[i];
                }
            }
        }
        return 0;
    }
}