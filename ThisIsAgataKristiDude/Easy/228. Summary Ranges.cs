using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/summary-ranges
/// 
///


namespace SummaryRanges
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 0, 1, 2, 4, 5, 7 }, new string[] { "0->2","4->5","7" })]
        [InlineData(new int[] { 0, 2, 3, 4, 6, 8, 9 }, new string[] { "0", "2->4", "6", "8->9" })]
        public void SolutionTest(int[] nums, string[] realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(nums);

            dumbshit.Should().Equal(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public IList<string> SolveThisShitBroooo(int[] nums)
        {
            if (nums.Count() == 0)
                return new List<string>();

            List<string> ranges = new(nums.Length);

            for (int i = 0, j = 0; j < nums.Length; j++)
            {
                if (j != nums.Length - 1 && nums[j] + 1 == nums[j + 1])
                    continue;


                if (j > i) 
                {
                    ranges.Add($"{nums[i]}->{nums[j]}");
                    i = j + 1;
                }
                else
                {
                    ranges.Add($"{nums[i]}");
                    i++;
                }
            }

            return ranges;
        }
    }
}
