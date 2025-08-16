public class Program
{
    public static void Main(string[] args)
    {
        int[] a = new int[]{7,1,5,3,6,4};
        System.Console.WriteLine(Solution.MaxProfit(a));
    }
}

public class Solution
{
    public static int MaxProfit(int[] prices)
    {
        int minPrice = prices[0];
        int maxPrice = prices[0];
        int maxProfit = 0;
        int currentProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (minPrice > prices[i])
            {
                minPrice = prices[i];
                maxPrice = 0;
            }
            if (maxPrice < prices[i])
            {
                maxPrice = prices[i];
            }
            currentProfit = prices[i] - minPrice;
            if (maxProfit <= currentProfit)
            {
                maxProfit = currentProfit;
            }
        }
        if (maxProfit > 0)
        {
            return maxProfit;
        }


        return 0;
    }
}