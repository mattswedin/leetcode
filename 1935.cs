public class Solution
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        string[] splitStr = text.Split(' ');
        int count = 0;

        foreach (string word in splitStr)
        {
            count += IsValidWord(word, brokenLetters);
        }

        return count;
    }

    public int IsValidWord(string word, string brokenLetters)
    {
        for (int i = 0; i < word.Length; i++)
        {
            char letter = word[i];

            if (brokenLetters.Contains(letter))
            {
                return 0;
            }
        }

        return 1;
    }
}