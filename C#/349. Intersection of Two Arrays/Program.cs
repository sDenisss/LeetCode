public class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1,2,2,1 };
        int[] a2 = { 2,2 };

        int[] b = { 4,9,5 };
        int[] b2 = { 9,4,9,8,4 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.Intersection(a , a2));
        System.Console.WriteLine(sol.Intersection(b, b2));
    }
}

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> hashSet = new HashSet<int>();
        HashSet<int> resSet = new HashSet<int>();

        foreach (var item in nums1)
        {
            hashSet.Add(item);
        }

        foreach (var item in nums2)
        {
            if (hashSet.Contains(item))
            {
                resSet.Add(item);
            }
        }

        int[] res = new int[resSet.Count];

        int j = 0;
        foreach (var item in resSet)
        {
            res[j] = item;
            j++;
        }

        return res;
    }
}