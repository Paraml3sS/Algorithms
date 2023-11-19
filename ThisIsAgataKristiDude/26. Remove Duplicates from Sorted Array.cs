using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/remove-duplicates-from-sorted-array
/// 
/// 

namespace RemoveDuplicatesFromSortedArray
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 } )]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
        public void SolutionTest(int[] nums, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            int k = dude.SolveThisShitBroooo(nums);

            k.Should().Be(realShit.Length);
            nums.Take(k).Should().Equal(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int[] nums)
        {
            int j = 1;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    nums[j] = nums[i + 1];
                    j++;
                }
            }


            return j;
        }
    }
}
