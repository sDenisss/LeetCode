public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 3,0,1 };

        int[] b = { 9,6,4,2,3,5,7,0,1 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.MissingNumber(a));
        System.Console.WriteLine(sol.MissingNumber(b));
    }
}

public class Solution {
    public int MissingNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (var item in nums)
        {
            set.Add(item);
        }

        for (int i = 0; i < nums.Length+1; i++)
        {
            if (set.Add(i) == true)
            {
                return i;
            }
        }
        return 0;
    }
}