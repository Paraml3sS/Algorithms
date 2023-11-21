using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/sqrtx
/// 
/// Binary search

namespace SqrtX
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 1)]
        [InlineData(8, 2)]
        [InlineData(4, 2)]
        [InlineData(1025, 32)]
        [InlineData(2147395599, 46340)]
        public void SolutionTest(int x, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(x);

            dumbSHit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int x)
        {
           
            int left = 1, right = x, middle;

            while (true)
            {
                middle = left + (right - left) / 2;

                if (middle <= x / middle)
                {
                    if (middle + 1 > x / (middle + 1))
                        return middle;

                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
        }
    }
}
