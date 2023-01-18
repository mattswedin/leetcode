public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        string nS = n.ToString();
        int sum = 0;
        int product = 1;

        for (int i = 0; i < nS.Length; i++)
        {
            int num = nS[i] - '0';
            sum += num;
            product *= num;
        }

        return product - sum;
    }
}