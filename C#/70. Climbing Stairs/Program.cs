public class Solution {

    // public static void Main(string[] args)
    // {
    //     for (int i = 0; i < 10; i++)
    //     {
    //         System.Console.WriteLine(i + " " +Fib(i));
    //     }
    // }
    public int ClimbStairs(int n) {
        int countWays = 0;
        if (n >= 2)
        {
            countWays = Fib(n);
        }
        else if (n == 0 || n == 1)
        {
            return n;
        }
        return countWays;
    }

    static int Fib(int n)
    {
        int result = 1;
        int b = 1;
        int tmp;
    
        for (int i = 0; i < n; i++)
        {
            tmp = result;
            result = b;
            b += tmp;
        }
    
        return result;
    }
}