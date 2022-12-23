using System;

public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> parenthesesMap = new Dictionary<char, char>();
        parenthesesMap["("] = ")";
        parenthesesMap["{"] = "}";
        parenthesesMap["["] = "]";

        Stack<char> closedParentheses = new Stack<char>();

        foreach (char p in s)
        {
            if (parenthesesMap.ContainsKey(p)) 
            {
                closedParentheses.Push(p);
            }
            else if (parenthesesMap.ContainsValue(p)) 
            {
                if (closedParentheses.Count == 0) return false;

                if (closedParentheses.Pop() != p) return false;
            }
            else
            {
                return false;
            }
        }
        return (closedParentheses.Count == 0);
    }

    
}