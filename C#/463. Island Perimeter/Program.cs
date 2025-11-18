public class Program
{
    public static void Main(string[] args)
    {
        int[][] a = { [0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0] };
        int[][] b = { [1] };
        int[][] c = { [1, 0] };

        // int[][] b = { 2,3,5 };


        Solution sol = new Solution();
        System.Console.WriteLine(sol.IslandPerimeter(a));
        System.Console.WriteLine(sol.IslandPerimeter(b));
        System.Console.WriteLine(sol.IslandPerimeter(c));
    }
}

public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int perimeter = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    perimeter += 4;
                    
                    // Вычитаем за общие границы с соседями
                    if (i > 0 && grid[i-1][j] == 1) perimeter -= 1;
                    if (i < rows - 1 && grid[i+1][j] == 1) perimeter -= 1; 
                    if (j > 0 && grid[i][j-1] == 1) perimeter -= 1; 
                    if (j < cols - 1  && grid[i][j+1] == 1) perimeter -= 1; 
                }
            }
        }
        
        return perimeter;
    }
}