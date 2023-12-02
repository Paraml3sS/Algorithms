using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/contains-duplicate-ii
/// 
/// Use set instead of dic and remove first elements to maintain a window of k length


namespace ContainsDuplicateII
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 3, true)]
        [InlineData(new int[] { 1, 0, 1, 1 }, 1, true)]
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
        public void SolutionTest(int[] nums, int k, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(nums, k);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(int[] nums, int k)
        {
            Dictionary<int, int> uniques = new(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                if (uniques.TryAdd(nums[i], i))
                    continue;

                if (Math.Abs(uniques[nums[i]] - i) <= k)
                    return true;
                else
                    uniques[nums[i]] = i;
            }


            return false;
        }
    }
}
