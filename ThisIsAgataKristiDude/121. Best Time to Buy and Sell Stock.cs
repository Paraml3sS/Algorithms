using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock
/// 
///

namespace BestTimeToBuyAndSellStock
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1, 2 }, 1)]
        public void SolutionTest(int[] nums, int realShit)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(nums);

            dumbShit.Should().Be(realShit);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(int[] prices)
        {
            int profit = 0, maxProfit = 0;

            for (int j = prices.Length - 1, i = j - 1; j > 0 && i >= 0; i--)
            {
                profit = prices[j] - prices[i];

                if (profit < 0)
                    j = i;
                else if (profit > maxProfit)
                    maxProfit = profit;
            }

            return maxProfit;
        }
    }
}
