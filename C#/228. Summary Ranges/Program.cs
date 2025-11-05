using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1 };

        int[] b = { 0,2,3,4,6,8,9 };

		Solution sol = new Solution();
		
		foreach (var item in sol.SummaryRanges(a))
		{
			Console.WriteLine(item);
		}
		
		System.Console.WriteLine("====");
		foreach(var item in sol.SummaryRanges(b))
		{
			Console.WriteLine(item);
		}
		
        System.Console.WriteLine(sol.SummaryRanges(a));
        System.Console.WriteLine(sol.SummaryRanges(b));
    }
}

public class Solution {
	public IList<string> SummaryRanges(int[] nums)
	{
		IList<string> list = new List<string>();

		for (int i = 0; i < nums.Length;)
		{
			if (i + 1 < nums.Length && nums[i] + 1 == nums[i+1])
			{
				int start = nums[i];
				while (i + 1 < nums.Length && nums[i] + 1 == nums[i+1])
				{
					if (i != nums.Length)
					{
						i++;
					}
				}
				list.Add($"{start}->{nums[i]}");
				i++;
			}
			else
			{
				list.Add($"{nums[i]}");
				i++;
			}
		}
		return list;
	}
}