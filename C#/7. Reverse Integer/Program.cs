using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        System.Console.WriteLine(sol.Reverse(1534236469));
        
    }
}

public class Solution {
    public int Reverse(int x)
    {
        try
        {
            string xStr = Math.Abs(x).ToString();
            StringBuilder resStr = new StringBuilder();

            for (int i = xStr.Length - 1; i >= 0; i--)
            {
                resStr.Append(xStr[i]);
            }
            int res = int.Parse(resStr.ToString());


            if (x < 0)
            {
                res *= -1;
            }
            return res;
        }
        catch (System.Exception)
        {
            return 0;
        }
        
    }
}