public class Program
{
    public static void Main(string[] args)
    {
        NumArray p = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
        System.Console.WriteLine(p.SumRange(0, 5));
    }
}
public class NumArray
{
    private int[] _nums;
    public NumArray(int[] nums)
    {
        _nums = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            sum += _nums[i];
        }
        return sum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */