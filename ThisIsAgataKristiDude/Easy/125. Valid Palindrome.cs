using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/valid-palindrome
/// 
/// same as best solution

namespace ValidPalindrome
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData("aa", true)]

        public void SolutionTest(string s, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var batShit = dude.SolveThisShitBroooo(s);

            batShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string s)
        {
            for ( int i = 0, j = s.Length - 1; i < j; ) {

                if (char.IsAsciiLetterOrDigit(s[i]) == false)
                {
                    ++i; continue;
                }

                if (char.IsAsciiLetterOrDigit(s[j]) == false)
                {
                    --j; continue;
                }

                if (
                    char.ToLower(s[i]) != char.ToLower(s[j])
                    )
                {
                    return false;
                }

                ++i; --j;
            }

            return true;
        }
    }
}
