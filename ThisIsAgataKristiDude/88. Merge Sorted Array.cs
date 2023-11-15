using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/merge-sorted-array/
/// 
/// Start from end to not shift (if started from front)

namespace MergeSortedArray
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void SolutionTest(int[] nums1, int m, int[] nums2, int n, int[] realShit)
        {
            ThisIsAlgoDude dude = new();

            dude.SolveThisShitBroooo(nums1, m, nums2, n);

            nums1.Should().BeEquivalentTo(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public void SolveThisShitBroooo(int[] nums1, int m, int[] nums2, int n)
        {
            var (i, j, k) = (m - 1, n - 1, m + n - 1);

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                }
                else
                {
                    nums1[k--] = nums2[j--];
                }
            }
        }
    }
}
