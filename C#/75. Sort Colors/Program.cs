public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[]{2,0,2,1,1,0};
        Solution.SortColors(a);
    }
}

public class Solution
{
    public static void SortColors(int[] nums)
    {
        Array.Sort(nums);
        foreach (var item in nums)
        {
            System.Console.WriteLine(item);
        }
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     for (int j = 0; j < nums.Length - 1; j++)
        //     {
        //         if (nums[j] > nums[j + 1])
        //         {
        //             Swap(nums, j, j + 1);
        //         }
        //     }
        // System.Console.WriteLine(nums[i]);
        // }
    }

    // public static void Swap(int[] arr, int frst_idx, int snd_idx)
    // {
    //     int temp = arr[frst_idx];
    //     arr[frst_idx] = arr[snd_idx];
    //     arr[snd_idx] = temp;
    // }

}