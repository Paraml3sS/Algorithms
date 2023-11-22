using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/majority-element
/// 
/// Start from end to not shift (if started from front)

namespace MajorityElement
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void SolutionTest(int[] nums, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(nums);

            dumbShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int[] nums)
        {
            Array.Sort(nums);

            return nums[nums.Length / 2];
        }
    }
}
