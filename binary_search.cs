using System;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle = (left + right) / 2;

        while (left <= right)
        {
            if (target == nums[middle]) return middle;
            if (target == nums[left]) return left;
            if (target == nums[right]) return right;

            if (target > nums[left] && target < nums[middle])
            {
                right = middle - 1;
                left++;
                middle = (left + right) / 2;
            }
            else if (target < nums[right] && target > nums[middle])
            {
                left = middle + 1;
                right--;
                middle = (left + right) / 2;
            }
        }
        return -1;
    }

}