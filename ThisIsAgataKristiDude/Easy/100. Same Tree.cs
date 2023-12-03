using FluentAssertions;
using ThisIsAgataKristiDude;
using Xunit;

/// https://leetcode.com/problems/same-tree
/// 

namespace SameTree
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {
            var tree1 = TreeNode.BuildDefaultTree();
            var tree2 = TreeNode.BuildDefaultTree();

            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(tree1, tree2);

            dumbSHit.Should().Be(true);
        }

    }


    public class ThisIsAlgoDude
    {
        public bool SolveThisShitBroooo(TreeNode tree1, TreeNode tree2)
        {
            return ShawtyHelp(tree1, tree2);

        }

        public bool ShawtyHelp(TreeNode firstRoot, TreeNode secondRoot)
        {
            if (firstRoot is null && secondRoot is null) return true;
            if (firstRoot is null || secondRoot is null) return false;
            if (firstRoot.val != secondRoot.val) return false;            

            var isLeftSideEqual = ShawtyHelp(firstRoot.left, secondRoot.left);
            var isRightSideEqual = ShawtyHelp(firstRoot.right, secondRoot.right);

            return isLeftSideEqual && isRightSideEqual;
        }
    }
}
