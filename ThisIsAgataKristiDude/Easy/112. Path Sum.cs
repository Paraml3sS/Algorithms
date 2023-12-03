using FluentAssertions;
using ThisIsAgataKristiDude;
using Xunit;

/// https://leetcode.com/problems/path-sum
/// 

namespace PathSum
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {
            var tree = new TreeNode([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);

            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(tree, 22);

            dumbSHit.Should().Be(true);
        }

    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(TreeNode root, int targetSum)
        {
            return ShawtyHelp(root, sum: 0, ref targetSum);
        }

        public bool ShawtyHelp(TreeNode root, int sum, ref int targetSum)
        {
            if (root?.val is null)
                return false;

            if (root.val.Value + sum == targetSum && root.left is null && root.right is null)
                return true;

            return ShawtyHelp(root.left, root.val.Value + sum, ref targetSum) ||
                   ShawtyHelp(root.right, root.val.Value + sum, ref targetSum);
        }
    }
}
