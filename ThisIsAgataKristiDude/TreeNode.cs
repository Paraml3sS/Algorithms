using FluentAssertions.Equivalency;

namespace ThisIsAgataKristiDude
{
    public class TreeNode
    {
        public int? val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int?[] values, int index = 0) => Build(values, index);

        private void Build(int?[] values, int index = 0)
        {
            this.val = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }

        public int?[] ToArray()
        {
            List<int?> values = new() { this.val };
            DirtyShawtyHelp(this.left, this.right, values);

            var lastNonNullValue = values.FindLastIndex(x => x.HasValue);
            values.RemoveRange(lastNonNullValue, values.Count() - lastNonNullValue - 1);

            return values.ToArray();
        }

        private void DirtyShawtyHelp(TreeNode left, TreeNode right, List<int?> values)
        {
            if (left is null && right is null)
                return;

            values.Add(left?.val); values.Add(right?.val);

            DirtyShawtyHelp(left.left, left.right, values);
            DirtyShawtyHelp(right.left, right.right, values);
        }

        public static TreeNode BuildDefaultTree()
        {
            TreeNode node3 = new(15);
            TreeNode node4 = new(7);

            TreeNode node1 = new(9);
            TreeNode node2 = new(20, node3, node4);

            TreeNode root = new(3, node1, node2);

            return root;
        }

        public static TreeNode BuildInvertedTree()
        {
            TreeNode node3 = new(15);
            TreeNode node4 = new(7);

            TreeNode node1 = new(9, node4, node3);
            TreeNode node2 = new(20);

            TreeNode root = new(3, node2, node1);

            return root;
        }
    }
}
