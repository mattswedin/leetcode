public class Solution
{
    public int MaximumValue(string[] strs)
    {
        int maxCount = 0;

        foreach (string str in strs)
        {
            maxCount = Math.Max(maxCount, Value(str));
        }

        return maxCount;
    }

    public int Value(string str)
    {
        bool numbers = false;
        bool letters = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsDigit(str[i]))
            {
                numbers = true;
            }
            else
            {
                letters = true;
            }

            if (numbers && letters) return str.Length;
        }

        if (numbers) return Int32.Parse(str);
        if (letters) return str.Length;
        return str.Length;
    }
}