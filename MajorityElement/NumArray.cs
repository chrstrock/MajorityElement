using System;

namespace MajorityElement
{
    public class NumArray
    {
        public int MajorityElement(int[] nums)
        {

            int majority = 0;
            if(nums.Length == 1)
            {
                majority = nums[0];
            }
            else
            {
                int count = 0;
                majority = nums[0];
                foreach(int n in nums)
                {
                    if(n == majority)
                    {
                        count += 1;
                    }
                    else
                    {
                        count -= 1;
                        if(count == 0)
                        {
                            majority = n;
                            count = 1;
                        }
                    }
                }
            }

            return majority;
        }
    }
}