public class Solution {
    public int CountCharacters(string[] words, string chars) {

        int overallCount = 0;

        foreach (string word in words)
        {
            if (HelperCount(word, chars))
            {
                overallCount += word.Length;
            }
        }

        return overallCount;
        
    }

    public bool HelperCount(string word, string chars)
    {
        int count = 0;

        for (int i = 0; i < word.Length; i++) 
        {
            char letter = word[i];
            if (chars.Contains(letter))
            {
                count += 1;
                chars = chars.Remove(chars.IndexOf(letter), 1);
            }
        }

        if (count == word.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}