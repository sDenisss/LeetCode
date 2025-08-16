public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        bool firstEnter = true;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                count++;
                firstEnter = false;
            } 
            else
            {
                if (!firstEnter)
                {
                    return count;
                }
            }
        }
        return count;
    }
}