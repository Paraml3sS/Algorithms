using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/happy-number
/// 


namespace HappyNumber
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(19, true)]
        [InlineData(2, false)]
        public void SolutionTest(int n, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(n);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(int n)
        {
            int slow = n, fast = n;

            do
            {
                slow = DigitSquareSum(slow);
                fast = DigitSquareSum(DigitSquareSum(fast));

            } while (slow != fast);

            return slow == 1 ? true : false;
        }

        int DigitSquareSum(int n)
        {
            int sum = 0, tmp;
            while (n > 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }
    }
}
