using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/word-pattern
/// 
/// Didn't use split


namespace WordPattern
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("abba", "dog cat cat dog", true)]
        [InlineData("abba", "dog cat cat fish", false)]
        [InlineData("aaaa", "dog cat cat dog", false)]
        [InlineData("abba", "dog dog dog dog", false)]
        public void SolutionTest(string pattern, string s, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbshit = dude.SolveThisShitBroooo(pattern, s);

            dumbshit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string pattern, string s)
        {
            int wordCounter = 0;
            string word = string.Empty;
            Dictionary<char, string> cypher = new(pattern.Length);
            s += ' ';

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    word += s[i];
                }
                else
                {
                    if (wordCounter + 1 > pattern.Length || 
                        cypher.TryAdd(pattern[wordCounter], word) == false && cypher[pattern[wordCounter]] != word
                        )
                        return false;

                    if (cypher.Values.Where(x => x == word).Count() > 1) return false;

                    word = string.Empty;
                    wordCounter++;
                }
            }


            return wordCounter < pattern.Length ? false : true;
        }
    }
}
