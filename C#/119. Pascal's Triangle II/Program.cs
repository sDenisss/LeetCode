public class Program
{
    public static void Main(string[] args)
    {
        Solution.GetRow(3);
        
    }
}
public class Solution
{
    public static IList<int> GetRow(int rowIndex)
    {
        IList<IList<int>> listOverall = new List<IList<int>>();
        for (int i = 0; i <= rowIndex; i++)
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
        
        // foreach (var item in listOverall[rowIndex])
        // {
        //     System.Console.WriteLine($"El {item}");
        // }
        return listOverall[rowIndex];
        

    }

}