public class Solution {
    public int ThirdMax(int[] nums) {

        if (nums.Length == 1) return nums[0];

        Array.Sort(nums);
        List<int> topThree = new List<int>();
        int valCount = 0;
        
        for (int i = nums.Length - 1; i >= 0; i--) 
        {
            if (valCount == 3) break;

            if (0 < topThree.Count && topThree[topThree.Count - 1] == nums[i])
            {
                topThree.Add(nums[i]);
            }
            else
            {
                valCount++;
                topThree.Add(nums[i]);
            }
           
        }

        topThree = topThree.Distinct().ToList();

        if ( topThree.Count < 3)
        {
            return topThree[0];
        }
        else
        {
            return topThree[topThree.Count - 1];
        }
    }
}