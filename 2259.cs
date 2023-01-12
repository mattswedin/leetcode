public class Solution
{
    public string RemoveDigit(string number, char digit)
    {
        List<string> numsList = new List<string>();

        for (int i = 0; i < number.Length; i++)
        {
            char num = number[i];

            if (num == digit)
            {
                numsList.Add(number.Remove(i, 1));
            }

        }

        return numsList.Max();
    }
}