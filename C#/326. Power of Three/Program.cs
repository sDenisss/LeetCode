public class Solution {
    public static void Main(string[] args)
    {
        Solution p = new Solution();
        System.Console.WriteLine(p.IsPowerOfThree(5));
    }
    public bool IsPowerOfThree(int n)
    {
        if (n == 1)
            return true;

        if (n <= 0)
        {
            return false;
        }

        while (n != 1)
        {
            if (!(n % 3 == 0))
            {
                return false;
            }
            n /= 3;
        }
        return true;
    }
}