public class Solution
{
    public string[] FindWords(string[] words)
    {
        string row1 = "qwertyuiop";
        string row2 = "asdfghjkl";
        string row3 = "zxcvbnm";

        List<string> list = new List<string>();


        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (isValid(row1, word) || isValid(row2, word) || isValid(row3, word))
            {
                list.Add(word);
            }
        }

        return list.ToArray();

    }

    public bool isValid(string row, string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (!row.Contains(Char.ToLower(word[i]))) return false;
        }

        return true;
    }
}