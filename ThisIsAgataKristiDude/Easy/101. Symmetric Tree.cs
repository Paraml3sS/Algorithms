using FluentAssertions;
using ThisIsAgataKristiDude;
using Xunit;

/// https://leetcode.com/problems/symmetric-tree
/// 

namespace SymmetricTree
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {


            var tree = new TreeNode([1, 2, 2, 3, 4, 4, 3]);

            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(tree);

            dumbSHit.Should().Be(true);
        }

    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(TreeNode root)
        {

            return ShawtyHelp(root.left, root.right);
        }

        public bool ShawtyHelp(TreeNode left, TreeNode right)
        {
            if (left?.val != right?.val)
                return false;

            if (left is null || right is null)
                return true;


            return ShawtyHelp(left.right, right.left) && ShawtyHelp(left.left, right.right);
        }
    }
}
