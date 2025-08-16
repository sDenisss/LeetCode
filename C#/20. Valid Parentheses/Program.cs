public class Solution
{
    public static void Main(string[] args)
    {
        Solution p = new Solution();
        System.Console.WriteLine(p.IsValid("()[]{}"));
        System.Console.WriteLine(p.IsValid("([])"));
        System.Console.WriteLine(p.IsValid("([)]"));
    }
    public bool IsValid(string s)
    {
        try
        {
            if (s == null || s.Length == 0)
            {
                return false;
            }

            char[] openBrackets = { '(', '[', '{' };
            char[] closeBrackets = { ')', ']', '}' };
            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (openBrackets.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }
            
            return stack.Count == 0;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    private bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '[' && close == ']') ||
               (open == '{' && close == '}');
    }
}