using System;

// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
// The order of the elements may be changed. Then return the number of elements in nums which are not equal
// to val.

// Consider the number of elements in nums which are not equal to val be k, to get accepted,
// you need to do the following things:
//
// Change the array nums such that the first k elements of nums contain the elements which
// are not equal to val. The remaining elements of nums are not important as well as the size of nums.
//
// Return k.


namespace leet_code_easy
{
    public class RemoveElement
    {
        public static int RemoveElementFromList(int[] nums, int val) {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    int temp = nums[k];
                    nums[k] = nums[i];
                    nums[i] = temp;
                    k++;
                }
            }

            return k;
        }
    }
}