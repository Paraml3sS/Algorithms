using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/search-insert-position
/// 
/// 

namespace SearchInsertPosition

{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 0, 0)]
        [InlineData(new int[] { 1 }, 2, 1)]
        public void Solution(int[] nums, int target, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(nums, target);

            dumbShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int[] nums, int target)
        {




            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == target)
            //    {
            //        return i;
            //    }

            //    if (target < nums[i])
            //    {
            //        return i;
            //    }
            //}

            //if (target > nums[nums.Length - 1])
            //{
            //    return nums.Length;
            //}

            return ShawtyHelp(nums, target, 0, nums.Length - 1);
        }

        public int ShawtyHelp(int[] nums, int target, int begin, int end)
        {
            if (begin >= end)
                return target > nums[end] ? end + 1 : begin;

            int middle = begin + (end - begin) / 2;

            if (target == nums[middle])
            {
                return middle;
            }
            else if (target < nums[middle])
            {
                return ShawtyHelp(nums, target, begin, middle);
            }
            else
            {
                return ShawtyHelp(nums, target, middle + 1, end);
            }
        }
    }
}
