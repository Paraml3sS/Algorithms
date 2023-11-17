using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/remove-element
/// 
/// No need to swap, element can be just removed/cleaned etc...

namespace RemoveElement
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 0, 1, 3, 4 })]
        public void SolutionTest(int[] nums, int val, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(nums, val);

            dumbSHit.Should().Be(realShit.Length);
            nums.Take(dumbSHit).Order().Should().BeEquivalentTo(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int[] nums, int val)
        {
            int k = 0;
            int j = nums.Length - 1;

            for (int i = 0; i <= j;)
            {
                if (nums[i] == val && val == nums[j])
                {
                    --j; ++k;
                }
                else if (nums[i] == val)
                {
                    Swap(nums, val, j, i);
                    ++i; --j; ++k;
                }
                else ++i;
            }

            return nums.Length - k;
        }

        private static void Swap(int[] nums, int val, int j, int i)
        {
            var elementFromTheEnd = nums[j];
            nums[j] = val;
            nums[i] = elementFromTheEnd;
        }
    }
}
