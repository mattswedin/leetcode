public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        dic['I'] = 1;
        dic['V'] = 5;
        dic['X'] = 10;
        dic['L'] = 50;
        dic['C'] = 100;
        dic['D'] = 500;
        dic['M'] = 1000;

        int total = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char romanNum = s[i];
            if (i < s.Length - 1 && romanNum == 'I' || i < s.Length - 1 && romanNum == 'X' || i < s.Length - 1 && romanNum == 'C')
            {
                if (dic[s[i + 1]] > dic[romanNum])
                {
                    total -= dic[romanNum];
                }
                else
                {
                    total += dic[romanNum];
                }
            }
            else
            {
                total += dic[romanNum];
            }
        }

        return total;
    }


}