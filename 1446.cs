public class Solution
{
    public int MaxPower(string s)
    {
        int count = 0;
        int maxCount = 1;
        bool streak = false;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1] && !streak)
            {
                count += 2;
                streak = true;
            }
            else if (s[i] == s[i + 1] && streak)
            {
                count += 1;
            }
            else
            {
                streak = false;
                maxCount = Math.Max(maxCount, count);
                count = 0;
            }
        }

        return maxCount = Math.Max(maxCount, count);

    }
}