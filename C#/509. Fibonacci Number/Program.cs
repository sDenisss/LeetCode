using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        System.Console.WriteLine(sol.Fib(1));
        System.Console.WriteLine(sol.Fib(4));
    }
}

public class Solution {
    public int Fib(int n)
    {
        if ( n == 0 || n == 1) return n;
        else
        {
            return Fib(n - 2) + Fib(n - 1);
        }
    }
}