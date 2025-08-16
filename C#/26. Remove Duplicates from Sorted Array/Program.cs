public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[]{1, 1, 2, 2, 2, 3};
        Solution.RemoveDuplicates(a);
    }
}
public class Solution {
    public static int RemoveDuplicates(int[] nums) {
        int[] b = new int[nums.Length];



        int k = 1;
        b[0] = nums[0];
        for (int i = 1; i < b.Length; i++)
        {
            if (nums[i-1] != nums[i])
            {
                b[k] = nums[i];
                k++;
            }
        }


        for(int i = 0; i < b.Length; i++)
            System.Console.WriteLine(b[i]);


        return k;
    }
}