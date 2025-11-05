using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 2,3,6,7 };

        int[] b = { 2,3,5 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.CombinationSum(a, 7));
        System.Console.WriteLine(sol.CombinationSum(b, 8));
    }
}

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> resLists = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), resLists);

        return resLists;
    }

    private void Backtrack(int[] candidates, int remaining, int start, IList<int> subList, IList<IList<int>> resLists)
    {
        if (remaining == 0) resLists.Add(new List<int>(subList));
            
        if (remaining < 0) return;

        for (int i = start; i < candidates.Length; i++)
        {
            int current = candidates[i];
            subList.Add(current);
            Backtrack(candidates, remaining - current, i, subList, resLists);
            subList.RemoveAt(subList.Count - 1);
        }
    }
}
