using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/longest-common-prefix
/// 
/// Lexicographic sorting allows to compare first and last
/// mine can be simplified usiing foreach instead of for (eliminate indices)

namespace LongestCommonPrefix
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "flower", "flower", "flower" }, "flower")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        [InlineData(new string[] { "" }, "")]
        [InlineData(new string[] { "", "" }, "")]
        [InlineData(new string[] { "a" }, "a")]
        [InlineData(new string[] { "ab", "a" }, "a")]
        public void SolutionTest(string[] strs, string realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(strs);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public string SolveThisShitBroooo(string[] strs)
        {
            if (strs.Length == 1 || string.IsNullOrEmpty(strs[0]))
                return strs.First();

            int maxPrefixLength = strs.First().Length;

            char prevChar = strs[0][0];

            int prefixPosition = 0;

            for (int i = 0; ; i++)
            {
                if (string.IsNullOrEmpty(strs[i]) || strs[i][prefixPosition] != prevChar)
                    break;

                prevChar = strs[i][prefixPosition];

                if (prefixPosition == 0 && strs[i].Length < maxPrefixLength)
                    maxPrefixLength = strs[i].Length;

                if (i >= strs.Length - 1)
                {
                    if (++prefixPosition >= maxPrefixLength)
                        break;

                    i = 0; 

                    prevChar = strs[i][prefixPosition];

                }
            }


            return strs.First().Substring(0, prefixPosition);
        }
    }
}
