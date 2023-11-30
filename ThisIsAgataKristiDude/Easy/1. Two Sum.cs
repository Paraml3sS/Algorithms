using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/merge-sorted-array/
/// 
/// Start from end to not shift (if started from front)

namespace TwoSum
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void SolutionTest(int[] nums, int target, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumShite = dude.SolveThisShitBroooo(nums, target);

            dumShite.Should().Equal(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int[] SolveThisShitBroooo(int[] nums, int target)
        {
            Dictionary<int, int> remainder = new(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (remainder.TryGetValue(nums[i], out int j))
                    return new int[] { j, i };

                remainder.TryAdd(target - nums[i], i);
            }


            return new int[] { };
        }
    }
}
