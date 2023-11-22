using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/ransom-note
/// 


namespace RansomNote
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        [InlineData("aab", "baa", true)]
        public void SolutionTest(string ransomNote, string magazine, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(ransomNote, magazine);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            Dictionary<char, int> keys = new(magazine.Length);

            for (int i = 0, j = 0; j < magazine.Length; i++, j++)
            {
                if (i < ransomNote.Length && keys.TryAdd(ransomNote[i], -1) == false)
                {
                    keys[ransomNote[i]]--;
                }
                    

                if (keys.TryAdd(magazine[j], 1) == false)
                    keys[magazine[j]]++;
            }

            return keys.Values.Any(x => x < 0) == false;
        }
    }
}
