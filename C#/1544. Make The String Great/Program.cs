using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string a = "leEeetcode";
        string b = "abBAcC";
        string c = "";
        System.Console.WriteLine(solution.MakeGood(a));
        System.Console.WriteLine(solution.MakeGood(b));
        System.Console.WriteLine(solution.MakeGood(c));
    }
}

public class Solution {
    public string MakeGood(string s) 
    {
        if (s == null || s.Length == 0)
            return "";

        Stack<char> stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0 && IsBadPair(stack.Peek(), s[i]))
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        char[] res = new char[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--)
        {
            res[i] = stack.Pop();
        }
        return new string(res);
    }

    public bool IsBadPair(char c1, char c2)
    {
        if (c1.Equals(c2)) return false;
        
        return char.ToUpper(c1).Equals(c2) || char.ToLower(c1).Equals(c2) ? true : false;
    }
}