using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
/// 
///

namespace FindTheIndexOfTheFirstOccurrenceInAString

{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("butsad", "sad", 3)]
        [InlineData("butsasad", "sad", 5)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("leetcode", "leetoddddddd", -1)]
        [InlineData("mississippi", "issip", 4)]
        public void SolutionTest(string haystack, string needle, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSHiiddude = dude.SolveThisShitBroooo(haystack, needle);

            dumbSHiiddude.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
                return -1;

            for (int i = 0, j = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != needle[j])
                {
                    if(j > 0)
                    {
                        i -= j;
                        j = 0;
                    }
                    
                    continue;
                }

                if (++j == needle.Length)
                    return i - needle.Length + 1;                 
            }

            return -1;
        }
    }
}
