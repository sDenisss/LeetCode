public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1,2,3,1 };
        int[] b = { 1,2,3,4 };

        Solution sol = new Solution();
        System.Console.WriteLine(sol.ContainsDuplicate(a));
        System.Console.WriteLine(sol.ContainsDuplicate(b));
    }
}

public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> elements = new HashSet<int>();
        foreach (var item in nums)
        {
            if (!elements.Add(item))
            {
                return true;
            }
        }
        return false;
    }
}