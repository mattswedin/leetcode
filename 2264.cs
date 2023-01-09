public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string subNums = "000";
        bool gotNum = false;

        for (int i = 0; i < num.Length - 2; i++)
        {
            string num1 = num[i].ToString();
            string num2 = num[i + 1].ToString();
            string num3 = num[i + 2].ToString();

            if (num1 == num2 && num1 == num3)
            {
                gotNum = true;
                string sub = num1 + num2 + num3;
                if (Int32.Parse(subNums) < Int32.Parse(sub))
                {
                    subNums = sub;
                }
            }
        }

        if (gotNum)
        {
            return subNums;
        }
        else
        {
            return "";
        }
    }
}