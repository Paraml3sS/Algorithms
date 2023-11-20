using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/climbing-stairs/
/// 
///

namespace ClimbingStairs
{
    public class MakeItWorkDude
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 8)]
        [InlineData(6, 13)]
        public void Solution(int n, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(n);

            dumbShit.Should().Be(realShit);
        }
    }


    /// <summary>
    /// 1 - 1
    /// 1
    /// 
    /// 1 level
    /// 
    /// 2 - 2
    /// 1 1
    /// 2
    /// 
    /// 2 levels
    /// 
    /// 3 - 3
    /// 1 1 1
    /// 1 2
    /// 2 1
    /// 
    /// 3 levels
    /// 
    /// 4 - 5
    /// 1 1 1 1
    /// 1 1 2
    /// 2 1 1
    /// 1 2 1
    /// 2 2
    /// 
    /// 3 levels
    /// 
    /// 5 - 8
    /// 1 1 1 1 1
    /// 1 1 1 2
    /// 1 1 2 1
    /// 1 2 1 1
    /// 2 1 1 1
    /// 2 2 1
    /// 2 1 2
    /// 1 1 2
    /// 
    /// 
    /// 6 - 13
    /// 1 1 1 1 1 1
    /// 1 1 1 1 2
    /// 1 1 1 2 1
    /// 1 1 2 1 1
    /// 1 2 1 1 1
    /// 2 1 1 1 1
    /// 2 2 1 1
    /// 2 1 2 1
    /// 2 1 1 2
    /// 1 2 2 1
    /// 1 2 1 2
    /// 1 1 2 2
    /// 2 2 2
    /// 
    /// </summary>

    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            return ShawtyHelp(previous: 1, current: 2, n, currentLevel: 2);

            //int previousLevel = 1, currentLevel = 2;
            //for (int i = 2; i < n; i++)
            //{
            //    int temp = currentLevel;
            //    currentLevel += previousLevel;
            //    previousLevel = temp;
            //}


            //return currentLevel;
        }

        public int ShawtyHelp(int previous, int current, int n, int currentLevel = 2)
        {
            if (currentLevel == n)
                return current;

            return ShawtyHelp(current, current + previous, n, ++currentLevel);
        }
    }
}
