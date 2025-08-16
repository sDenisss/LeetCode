using System.Text;

public class Solution {

    Dictionary<int, char> dic = new Dictionary<int, char>()
    {
        {1, 'A'}, {2, 'B'}, {3, 'C'}, {4, 'D'}, {5, 'E'},
        {6, 'F'}, {7, 'G'}, {8, 'H'}, {9, 'I'}, {10, 'J'},
        {11, 'K'}, {12, 'L'}, {13, 'M'}, {14, 'N'}, {15, 'O'},
        {16, 'P'}, {17, 'Q'}, {18, 'R'}, {19, 'S'}, {20, 'T'},
        {21, 'U'}, {22, 'V'}, {23, 'W'}, {24, 'X'}, {25, 'Y'},
        {26, 'Z'}
    };
    public string ConvertToTitle(int columnNumber) {
        var strSheet = new StringBuilder();

        int ost = columnNumber % 26;
        if (columnNumber >= 26)
        {
            while (columnNumber > 0)
            {
                ost = columnNumber % 26;
                if (ost == 0) // Особый случай для 'Z'
                {
                    ost = 26;
                    columnNumber = columnNumber / 26 - 1;
                }
                else
                {
                    columnNumber /= 26;
                }
                strSheet.Insert(0, dic[ost]);
            }
        }
        else
        {

            strSheet.Append(dic[ost]);
        }
        return strSheet.ToString();
    }
}