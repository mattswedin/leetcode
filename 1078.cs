public class Solution
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        string[] splitStr = text.Split(" ");
        List<string> thirdList = new List<string>();

        for (int i = 0; i < splitStr.Length - 2; i++)
        {
            string word1 = splitStr[i];
            string word2 = splitStr[i + 1];
            string word3 = splitStr[i + 2];



            if (word1 == first && word2 == second)
            {
                Console.WriteLine(thirdList);

                thirdList.Add(word3);
            }

        }
        string[] result = thirdList.ToArray();
        return result;
    }
}