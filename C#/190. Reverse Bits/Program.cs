public class Solution
{
    public static void Main(string[] args)
    {
        Solution p = new Solution();
        System.Console.WriteLine(p.ReverseBits(43261596));
    }
    public uint ReverseBits(uint n)
    {
        uint res = 0;

        for (int i = 0; i < 32; i++)
        {
            res <<= 1;

            res |= n & 1;

            n >>= 1;
        }
        return res;
    }
}