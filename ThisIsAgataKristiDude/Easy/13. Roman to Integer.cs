using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/roman-to-integer/
/// 
/// faster with switch instead of dic and go from end

namespace RomanToInteger
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("LVIII", 58)]
        [InlineData("III", 3)]
        public void SolutionTest(string roman, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(roman);

            dumbShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        Dictionary<char, int> RomanToInteger = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int SolveThisShitBroooo(string s)
        {
            int integer = 0;
            int previous = RomanToInteger[s.First()], current;

            for (int i = 0; i < s.Length; i++)
            {
                current = RomanToInteger[s[i]];

                integer += current > previous 
                    ? current - 2 * previous 
                    : RomanToInteger[s[i]];

                previous = current;
            }

            return integer;
        }
    }
}
