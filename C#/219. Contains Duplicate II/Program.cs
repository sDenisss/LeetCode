public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1,2,3,1 };
        int k = 3;

        int[] b = { 1,2,3,1,2,3 };
        int l = 2;


        Solution sol = new Solution();
        System.Console.WriteLine(sol.ContainsNearbyDuplicate(a, k));
        System.Console.WriteLine(sol.ContainsNearbyDuplicate(b, l));
    }
}

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        Dictionary<int, int> elements = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
			// if it's already in dic
            if(!elements.TryAdd(nums[i], i))
			{
				int j = elements[nums[i]];
				elements[nums[i]] = i;
				if(Math.Abs(i-j) <= k)
				{
					return true;
				}
			}
        }
		return false;
    }
}