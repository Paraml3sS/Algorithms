using System.Collections.Generic;
using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/length-of-last-word/
/// 
///

namespace LengthOfLastWord
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("a", 1)]
        public void SolutionTest(string s, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(s);

            dumbShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(string s)
        {
            int count = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(s[i])) count++;

                if (count > 0 && (i == 0 || char.IsWhiteSpace(s[i - 1])))
                    break;
            }


            return count;
        }
    }
}
