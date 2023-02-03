public class Solution
{
    public int AverageValue(int[] nums)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num % 3 == 0 && num % 2 == 0)
            {
                list.Add(num);
            }
        }

        if (list.Count == 0) return 0;

        return list.Sum() / list.Count;
    }
}