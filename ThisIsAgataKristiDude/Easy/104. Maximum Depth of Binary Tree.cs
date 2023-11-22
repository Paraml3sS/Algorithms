using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/maximum-depth-of-binary-tree
/// 
///

namespace MaximumDepthOfBinaryTree
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {
            TreeNode node3 = new(15);
            TreeNode node4 = new(7);

            TreeNode node1 = new(9);
            TreeNode node2 = new(20, node3, node4);

            TreeNode root = new(3, node1, node2);


            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(root);

            dumbSHit.Should().Be(3);
        }
    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(TreeNode root)
        {
            return ShawtyHelp(level: 0, root);
        }

        public int ShawtyHelp(int level, TreeNode root = null)
        {
            if (root is null) return level;

            ++level;

            int leftPathLevel = ShawtyHelp(level, root.left);
            int rightPathLevel = ShawtyHelp(level, root.right);

            return Math.Max(leftPathLevel, rightPathLevel);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
