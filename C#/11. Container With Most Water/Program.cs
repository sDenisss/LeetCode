public class Program
{
    public static void Main(string[] args)
    {
        int[] height = {1,8,6,2,5,4,8,3,7};
        System.Console.WriteLine(Solution.MaxArea(height));
    }
}
class Solution {
    public static int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right) {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));

            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxArea;        
    }
}
