public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[] { 2, 7, 11, 15 };
        System.Console.WriteLine(Solution.TwoSum(a, 9));
    }
}

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int curNum = nums[i];
            // dic.Add(i, target - curNum);

            if (dic.ContainsKey(target - curNum))
            {
                return new int[] { dic[target - curNum], i };
            }

            dic[curNum] = i;
        }

        return new int[0];
    }
}
