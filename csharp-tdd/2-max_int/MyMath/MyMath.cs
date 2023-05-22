﻿using Engine;

namespace MyMath
{
    public class Class1
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            int max = nums[0];

            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            return max;
        }
    }
}