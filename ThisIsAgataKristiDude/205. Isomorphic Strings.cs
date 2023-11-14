using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/isomorphic-strings/
/// 
/// Faster solutions are by checking unique key and value on the go instead of Count Distinct

namespace IsomorphicStrings
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("egg", "aaa", false)]
        [InlineData("egg", "dad", false)]

        public void SolutionTest(string s, string t, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var batShit = dude.SolveThisShitBroooo(s, t);

            batShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string s, string t)
        {
            Dictionary<char, char> letterPairs = new(s.Length);

            string transformedString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                letterPairs.TryAdd(s[i], t[i]);
                transformedString += letterPairs[s[i]];
            }

            if (letterPairs.Values.Count() != letterPairs.Values.Distinct().Count())
            {
                return false;
            }

            return transformedString == t;
        }
    }
}
