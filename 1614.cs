public class Solution
{
    public int MaxDepth(string s)
    {
        int amountOfP = 0;
        int mostAmountOfP = 0;

        Stack<int> parenthStack = new Stack<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                parenthStack.Push('(');
                amountOfP++;
            }
            else if (s[i] == ')')
            {
                parenthStack.Pop();
                amountOfP--;
            }

            if (mostAmountOfP < amountOfP)
            {
                mostAmountOfP = amountOfP;
            }
        }

        return mostAmountOfP;
    }
}