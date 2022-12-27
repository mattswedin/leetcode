public class Solution {
    public int MaxAscendingSum(int[] nums) 
    {
        int sum = nums[0];
        int overallSum = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                sum += nums[i];
            }
            else
            {
                if (overallSum < sum) overallSum = sum;
                sum = nums[i];
            }
        }

        if (overallSum < sum) overallSum = sum;
        
        return overallSum;
        
    }
}