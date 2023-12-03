using FluentAssertions;
using ThisIsAgataKristiDude;
using Xunit;

/// https://leetcode.com/problems/path-sum
/// 

namespace CountCompleteTreeNodes
{
    public class MakeItWorkDude
    {
        [Fact]
        public void SolutionTest()
        {
            // TODO: this constructor doesn't work -_-
            var tree = new TreeNode([5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1]);

            ThisIsAlgoDude dude = new();

            var dumbSHit = dude.SolveThisShitBroooo(tree);

            dumbSHit.Should().Be(13); // change to 9
        }

    }


    public class ThisIsAlgoDude
    {
        public int SolveThisShitBroooo(TreeNode root)
        {
            int count = 0;
            ShawtyHelp(root, ref count);
            return count;
        }

        public void ShawtyHelp(TreeNode root, ref int count)
        {
            if (root is null)
                return;

            ++count;

            ShawtyHelp(root.left, ref count);
            ShawtyHelp(root.right, ref count);
        }
    }
}
