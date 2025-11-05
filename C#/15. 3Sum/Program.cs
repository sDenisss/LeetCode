using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { -1,0,1,2,-1,-4 };

        int[] b = { 0,1,1 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.ThreeSum(a));
        System.Console.WriteLine(sol.ThreeSum(b));
    }
}

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
	{
		Array.Sort(nums);
		IList<IList<int>> resLists = new List<IList<int>>();
		List<int> subList;
		int left, rigth;

		for (int i = 0; i < nums.Length-2; i++)
		{
			if (i > 0 && nums[i-1] == nums[i])
			{
				continue;
			}
			left = i + 1;
			rigth = nums.Length - 1;

			while (left < rigth)
			{
				if (nums[left] + nums[rigth] == (nums[i] * (-1)))
				{
					subList = new List<int> { nums[i], nums[left], nums[rigth] };
					resLists.Add(subList);

					while (left < rigth && nums[left] == nums[left + 1]) left++;
					while (left < rigth && nums[rigth] == nums[rigth - 1]) rigth--;

					left++;
					rigth--;
				}
				else if (nums[left] + nums[rigth] < (nums[i] * (-1)))
				{
					left++;
				}
				else
				{
					rigth--;
				}
			}
		}
		
		// Console.WriteLine("\nФИНАЛЬНЫЙ РЕЗУЛЬТАТ:");
        // foreach (var triplet in resLists)
        // {
        //     Console.WriteLine($"[{string.Join(", ", triplet)}]");
        // }
		
		return resLists;
    }
}