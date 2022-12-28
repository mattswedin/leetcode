public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        int j = 0;

        if (s.Length < 1) return true;

        for (int i = 0; i < t.Length; i++)
        {
            char sChar = s[j];
            char tChar = t[i];

            

            if (sChar == tChar)
            {
                j++;
            }

            if (j == s.Length) return true;
        
        }

        if (j == s.Length) return true;
        return false;
    }
}