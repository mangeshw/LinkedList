using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
        }

        public Tree BuildTree()
        {
            TreeNode node = new TreeNode();
            Tree tree = new Tree(node);
            node.IntegerValue = 1;
            Queue<TreeNode> list = new Queue<TreeNode>();
            list.Enqueue(node);
            AddNodes(list, 1);
            return tree;
        }

        public void AddNodes(Queue<TreeNode> list, int index)
        {
            if (index > 10)
                return;
            index++;
            TreeNode left = new TreeNode();
            left.IntegerValue = index;
            TreeNode right = new TreeNode();
            index++;
            right.IntegerValue = index;
            TreeNode node = list.Dequeue();
            node.Left = left;
            node.Right = right;

            list.Enqueue(left);
            list.Enqueue(right);

            AddNodes(list, index);
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
        }

        private void btnLevelOrderTraversal_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            Queue<TreeNode> list = new Queue<TreeNode>();
            list.Enqueue(tree.Root);
            StringBuilder builder = new StringBuilder();
            txtResult.Text = LevelOrderTraversal(list, builder);
        }

        /// <summary>
        /// Breadth First Traversal
        /// </summary>
        /// <param name="list"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public String LevelOrderTraversal(Queue<TreeNode> list, StringBuilder builder)
        {
            TreeNode root;
            if (list.Count == 0)
                return String.Empty;
            
            root = list.Dequeue();
            if (root == null)
                return String.Empty;
            builder.Append(root.IntegerValue.ToString());
            builder.Append(", ");
            TreeNode left = root.Left;
            list.Enqueue(left);
            TreeNode right = root.Right;
            list.Enqueue(right);
            LevelOrderTraversal(list,builder);
            return builder.ToString();
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            txtResult.Text = InOrderTraversal(tree.Root, new StringBuilder());
        }

        public String InOrderTraversal(TreeNode root, StringBuilder builder)
        {
            //In Order is Left - Root - Right
            if (root == null)
                return String.Empty;
            TreeNode left = root.Left;
            TreeNode right = root.Right;
            InOrderTraversal(left, builder);
            builder.Append(root.IntegerValue);
            builder.Append(", ");
            InOrderTraversal(right, builder);
            return builder.ToString();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            txtResult.Text = PostOrder(tree.Root, new StringBuilder());
        }

        public String PostOrder(TreeNode root, StringBuilder builder)
        {
            //Left - Right - Root
            if (root == null)
                return String.Empty;

            TreeNode left = root.Left;
            TreeNode right = root.Right;
            PostOrder(left, builder);
            PostOrder(right, builder);
            builder.Append(root.IntegerValue);
            builder.Append(", ");
            return builder.ToString();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            txtResult.Text = PreOrder(tree.Root, new StringBuilder());
        }

        public String PreOrder(TreeNode root, StringBuilder builder)
        {
            //Root - Left - Right
            if (root == null)
                return String.Empty;

            TreeNode left = root.Left;
            TreeNode right = root.Right;
            builder.Append(root.IntegerValue);
            builder.Append(", ");
            PreOrder(left, builder);
            PreOrder(right, builder);
            return builder.ToString();
        }

        private void btnMaxDepth_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            TreeNode newNode = new TreeNode();
            newNode.IntegerValue = 12;
            tree.Root.Left.Left.Left.Left = newNode;
            txtResult.Text = FindMaxDepth(tree.Root, 0).ToString();
        }

        public int FindMaxDepth(TreeNode root, int currentDepth)
        {
            if (root == null)
                return currentDepth;
            
            currentDepth++;
            int leftDepth = FindMaxDepth(root.Left, currentDepth);
            int rightDepth = FindMaxDepth(root.Right, currentDepth);
            //maxDepth = currentDepth > maxDepth ? currentDepth : maxDepth;
            return Math.Max(leftDepth, rightDepth);
        }

        private void btnMirrorTree_Click(object sender, EventArgs e)
        {
            Tree tree = BuildTree();
            TreeNode mirrorNode = MirrorTree(tree.Root, null);
            txtResult.Text = InOrderTraversal(mirrorNode, new StringBuilder());
        }

        public TreeNode MirrorTree(TreeNode root, TreeNode mirrorNode)
        {
            if(root == null)
            {
                return null;
            }
            mirrorNode = new TreeNode();
            mirrorNode.IntegerValue = root.IntegerValue;
            mirrorNode.Right = MirrorTree(root.Left, mirrorNode.Right);
            mirrorNode.Left = MirrorTree(root.Right, mirrorNode.Left);
            return mirrorNode;
        }
    }
}
