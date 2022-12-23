using System;
using System.Console;

public class Solution {
    public bool KLengthApart(int[] nums, int k) 
    {
        int count = 0;
        bool atOne;

        for (int i = 1; i < nums.Length; i++) 
        {
            int num = nums[i];

            if (num == 1)
            {
                if (count < k || !atOne) return false;
                if (!atOne) atOne = true;
                count = 0;
            }

            if (num == 0)
            {
                count++;
            }
        }

        return true;
    }
}