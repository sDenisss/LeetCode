public class Program
{
    public static void Main(string[] args)
    {
        Solution.Generate(5);
        
    }
}
public class Solution
{
    public static IList<IList<int>> listOverall = new List<IList<int>>();
    public static IList<IList<int>> Generate(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            IList<int> listSmall = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    listSmall.Add(1);
                }
                else
                {
                    int val = listOverall[i - 1][j - 1] + listOverall[i - 1][j];
                    listSmall.Add(val);
                }
            }
            listOverall.Add(listSmall);
        }
        
        // foreach (var item in listOverall)
        // {
        //     System.Console.WriteLine();
        //     foreach (var i in item)
        //     {
        //         System.Console.WriteLine($"El {i}");
        //     }
        // }
        return listOverall;
    }

}