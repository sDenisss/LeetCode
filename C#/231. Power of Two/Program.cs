public class Solution {
    public static void Main(string[] args)
    {
        Solution p = new Solution();
        System.Console.WriteLine(p.IsPowerOfTwo(5));
        System.Console.WriteLine(p.IsPowerOfTwo(1));
        System.Console.WriteLine(p.IsPowerOfTwo(16));
        System.Console.WriteLine(p.IsPowerOfTwo(0));
    }
    public bool IsPowerOfTwo(int n)
    {
        if (n == 1)
        {
            return true;
        }
        if (n % 2 != 0 || n <= 0)
        {
            return false;
        }

        while (n >= 2)
        {
            if (n % 2 != 0)
            {
                return false;
            }
            n /= 2;
        }
        return true;

    }
}