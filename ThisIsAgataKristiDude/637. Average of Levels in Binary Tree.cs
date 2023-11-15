using FluentAssertions;
using Xunit;

/// https://leetcode.com/problems/merge-sorted-array/
/// 
/// BFS faster, dictionary can be optimized

namespace AverageOfLevelsInBinaryTree
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

            dumbSHit.Should().BeEquivalentTo(new double[] { 3, 14.5, 11 });
        }
    }


    public class ThisIsAlgoDude
    {
        public IList<double> SolveThisShitBroooo(TreeNode root)
        {
            Dictionary<int, (double Sum, int Num)> result = new();

            ShawtyHelp(result, root, level: 1);

            return result.Select(x => x.Value.Sum / x.Value.Num).ToList();
        }

        public void ShawtyHelp(Dictionary<int, (double Sum, int Num)> sumPerLevel, TreeNode root = null, int level = 1)
        {
            if (root is null) return;

            if (sumPerLevel.ContainsKey(level))
                sumPerLevel[level] = (Sum: sumPerLevel[level].Sum + root.val, Num: sumPerLevel[level].Num + 1);
            else
                sumPerLevel[level] = ( Sum: root.val, Num: 1 );

            ++level;

            ShawtyHelp(sumPerLevel, root.left, level);
            ShawtyHelp(sumPerLevel, root.right, level);
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
