using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/palindrome-number
/// 
/// 

namespace PalindromeNumber
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(12231221, false)]
        public void SolutionTest(int x, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSit = dude.SolveThisShitBroooo(x);

            dumbSit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(int x)
        {
            if (int.IsNegative(x))
            {
                return false;
            }

            int temp = x, reversed = 0;

            while (temp != 0) {
                reversed = reversed * 10 + temp % 10;
                temp = temp / 10;
            }

            return reversed == x;
        }
    }
}
