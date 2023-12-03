using FluentAssertions.Equivalency;

namespace ThisIsAgataKristiDude
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int[] values, int index = 0) => Build(values, index);

        private void Build(int[] values, int index = 0)
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

        public int[] ToArray() {
            List<int> values = new(); int i = 0;

            AddToArray(this, values, ref i);

            return values.ToArray();
        } 

        void AddToArray(TreeNode tree, List<int> values, ref int i)
        {
            if (tree is null)
                return;

            values.Add(tree.val);
            ++i;
            AddToArray(tree.left, values, ref i);
            AddToArray(tree.right, values, ref i);
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
