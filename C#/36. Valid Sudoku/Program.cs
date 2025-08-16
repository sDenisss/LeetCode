using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        char[][] a = { ['5','3','.','.','7','.','.','.','.'],['6','.','.','1','9','5','.','.','.'],['.','9','8','.','.','.','.','6','.'],['8','.','.','.','6','.','.','.','3'],['4','.','.','8','.','3','.','.','1'],['7','.','.','.','2','.','.','.','6'],['.','6','.','.','.','.','2','8','.'],['.','.','.','4','1','9','.','.','5'],['.','.','.','.','8','.','.','7','9'] };
        System.Console.WriteLine(Solution.IsValidSudoku(a));
    }
}


public class Solution
{
    public static bool IsValidSudoku(char[][] board)
    {
        // Проверка строк и столбцов
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> row = new HashSet<char>();
            HashSet<char> col = new HashSet<char>();

            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    if (!row.Add(board[i][j]))
                        return false;
                }

                if (board[j][i] != '.')
                {
                    if (!col.Add(board[j][i]))
                        return false;
                }
            }
        }

        // Проверка 3x3 блоков
        for (int boxRow = 0; boxRow < 3; boxRow++)
        {
            for (int boxCol = 0; boxCol < 3; boxCol++)
            {
                HashSet<char> box = new HashSet<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char current = board[boxRow * 3 + i][boxCol * 3 + j];
                        if (current != '.')
                        {
                            if (!box.Add(current))
                                return false;
                        }
                    }
                }
            }
        }

        return true;
    }
}
