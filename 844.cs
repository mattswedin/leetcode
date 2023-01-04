public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        Console.WriteLine(manipString(s));
        return manipString(s) == manipString(t);
    }

    public string manipString(string s)
    {
        int amountToDestroy = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            string letter = s[i].ToString();

            if (letter == "#")
            {
                s = s.Remove(i, 1);
                amountToDestroy++;
            }
            else
            {
                if (amountToDestroy > 0)
                {
                    s = s.Remove(i, 1);
                    amountToDestroy--;
                }
            }

        }

        return s;
    }
}