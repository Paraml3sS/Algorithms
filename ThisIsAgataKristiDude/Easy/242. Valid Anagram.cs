using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/valid-anagram
/// 


namespace ValidAnagram
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void SolutionTest(string ransomNote, string magazine, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(ransomNote, magazine);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string s, string t)
        {
            if (t.Length != s.Length)
                return false;

            Dictionary<char, int> charOccurence = new(s.Length);

            for (int i = 0, j = 0; i < s.Length; i++, j++)
            {
                charOccurence.TryAdd(s[i], 0);
                charOccurence.TryAdd(t[j], 0);

                charOccurence[s[i]]++;
                charOccurence[t[j]]--;
            }

            return charOccurence.Values.Any(x => x != 0) == false;
        }
    }
}
