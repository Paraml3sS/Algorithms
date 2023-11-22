using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/rotate-array
/// 
/// 

namespace ThisIsAgataKristiDude.Medium
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 }, 38,
                    new int[] { 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2, new int[] { 6, 7, 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5, new int[] { 3, 4, 5, 6, 7, 1, 2 })]
        [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        [InlineData(new int[] { 1, 2 }, 0, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 2, new int[] { 2, 3, 1 })]
        [InlineData(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
        [InlineData(new int[] { -1 }, 2, new int[] { -1 })]
        public void SolutionTest(int[] nums, int val, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            dude.SolveThisShitBroooo(nums, val);

            nums.Should().Equal(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public void Reverse(int[] nums, int start, int end)
        {
            for (; start < end; start++, end--)
            {
                Swap(nums, start, end);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public void SolveThisShitBroooo(int[] nums, int k)
        {
            k %= nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);








            // Failed attemot - 2 ---------

            //if (k <= 0 || nums.Length <= 1) 
            //    return;

            //k = k > nums.Length ? k % nums.Length : k;

            //int stepBackMultiplier = 2;

            //for (
            //    int 
            //    iteration = 0, 
            //    i = nums.Length - 2 * k, 
            //    j = nums.Length - k;
            //    i > - k; i++, j++
            //    )
            //{
            //    i = i < 0 ? 0 : i;

            //    Swap(nums, i, j);

            //    ++iteration;

            //    if (iteration == k)
            //    {
            //        iteration = 0;
            //        ++stepBackMultiplier;
            //        i = nums.Length - stepBackMultiplier * k - 1;
            //        j = nums.Length - (stepBackMultiplier - 1) * k - 1;

            //        var overReach = stepBackMultiplier * k - nums.Length;
            //        if (overReach >= 0 && overReach < k) i = -1;
            //    }
            //}



            // Failed attemot - 1 ---------

            //int isOddLengthCollection = nums.Length % 2;

            //int numberInBetween = nums[nums.Length / 2];

            //for (int i = 0, j = nums.Length - k; i < nums.Length - k - isOddLengthCollection; i++, j++)
            //{
            //    Swap(nums, j, i, isOddLengthCollection == 1);
            //}

            //if (isOddLengthCollection != 0)
            //{
            //    nums[nums.Length - 1] = numberInBetween;
            //}
        }
    }
}
