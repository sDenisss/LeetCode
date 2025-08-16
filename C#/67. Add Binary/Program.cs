
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        System.Console.WriteLine(sol.AddBinary("10", "1"));
        
    }
}

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int temp = 0;
        StringBuilder res = new StringBuilder();

        while (i >= 0 || j >= 0 || temp > 0)
        {
            int aInt = (i >= 0) ? a[i] - '0' : 0;
            int bInt = (j >= 0) ? b[j] - '0' : 0;

            int sum = aInt + bInt + temp;
            res.Insert(0, sum % 2);
            temp = sum / 2;
            i--;
            j--;
        }
        return res.ToString();
    }
}