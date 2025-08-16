public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) 
            return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        for (int i = 0; i < s2.Length - s1.Length; i++) {
            if (IsEqual(s1Count, s2Count))
                return true;
    
            s2Count[s2[i] - 'a']--;
            s2Count[s2[i + s1.Length]  - 'a']++;
        }

        return IsEqual(s1Count, s2Count);
    }

    public bool IsEqual(int[] arr1, int[] arr2) {
        for (int i = 0; i < 26; i++) {
            if (arr1[i] != arr2[i])
                return false;
        }

        return true;
    }
}