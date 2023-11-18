using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/valid-parentheses
/// 
///

namespace ValidParentheses
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        public void SolutionTest(string s, bool realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(s);

            dumbSHit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(string s)
        {
            Stack<char> brackets = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    brackets.Push(')');
                else if (s[i] == '{')
                    brackets.Push('}');
                else if (s[i] == '[')
                    brackets.Push(']');
                else if (brackets.Count == 0 || brackets.Pop() != s[i])
                    return false;
            }

            return brackets.Count == 0;
        }
    }
}
