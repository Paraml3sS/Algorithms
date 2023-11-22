using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/plus-one
/// 
///

namespace PlusOne
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 1, 2, 9 }, new int[] { 1, 3, 0 })]
        [InlineData(new int[] { 1, 9, 9 }, new int[] { 2, 0, 0 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 1 })]
        [InlineData(new int[] { 9, 9, 9, 9 }, new int[] { 1, 0, 0, 0, 0 })]
        [InlineData(new int[] { 8, 9, 9, 9 }, new int[] { 9, 0, 0, 0 })]
        public void SolutionTest(int[] nums, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(nums);

            dumbSHit.Should().Equal(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int[] SolveThisShitBroooo(int[] digits)
        {

            for (int j = digits.Length - 1; j >= 0; j--)
            {
                if (digits[j] + 1 > 9)
                {
                    digits[j] = 0;
                }
                else
                {
                    digits[j] += 1;
                    return digits;
                }
            }

            int[] newArray = new int[digits.Length + 1];
            newArray[0] = 1;

            return newArray;
        }
    }
}
