using FluentAssertions;
using ThisIsAgataKristiDude;
using Xunit;

/// https://leetcode.com/problems/invert-binary-tree
/// 

namespace InvertBinaryTree
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {
            var tree = new TreeNode([4, 2, 7, 1, 3, 6, 9]);

            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(tree);

            dumbSHit.ToArray().Should().Equal([4, 7, 2, 9, 6, 3, 1]);
        }
    }


    public class ThisIsAlgoDude
    {
        public TreeNode SolveThisShitBroooo(TreeNode tree)
        {
            ShawtyHelp(tree);

            return tree;
        }

        public void ShawtyHelp(TreeNode root)
        {
            if (root is null)
                return;

            var tmpLeft = root.left;
            root.left = root.right;
            root.right = tmpLeft;

            ShawtyHelp(root.left);
            ShawtyHelp(root.right);
        }
    }
}
