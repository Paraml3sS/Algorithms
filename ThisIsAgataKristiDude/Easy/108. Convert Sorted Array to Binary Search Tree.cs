using Xunit;

/// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
/// 
/// Optimize by returnning treeNode (null) instead of void - so ifs not needed
/// ref is not needed too

namespace ConvertSortedArrayToBinarySearchTree
{
    public class MakeItWorkDude
    {

        [Theory]
        [InlineData(new int[] { -10, -3, 0, 5, 9 })]
        [InlineData(new int[] { 1, 3})]
        public void SolutionTest(int[] nums)
        {
            ThisIsAlgoDude dude = new();

            var dumbShit = dude.SolveThisShitBroooo(nums);
        }
    }


    public class ThisIsAlgoDude
    {
        public TreeNode SolveThisShitBroooo(int[] nums)
        {
            int numOfNodes = 0;
            TreeNode root = new();
            ShawtyHelp(nums, 0, nums.Length, ref numOfNodes, root);

            return root;
        }

        public void ShawtyHelp(int[] nums, int i, int j, ref int numOfNodes, TreeNode root = null)
        {
            if (numOfNodes++ == nums.Length)
                return;
                

            int middle = (i + j) / 2;
            root.val = nums[middle];

            if (j - i <= 1)
                return;
            

            if (i < middle)
            {
                root.left = new TreeNode();
                ShawtyHelp(nums, i, middle, ref numOfNodes, root.left);
            }

            if (middle + 1 < j)
            {
                root.right = new TreeNode();
                ShawtyHelp(nums, middle + 1, j, ref numOfNodes, root.right);
            }
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
