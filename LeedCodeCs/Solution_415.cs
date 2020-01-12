using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode {
     *     public int val;
     *     public TreeNode left;
     *     public TreeNode right;
     *     public TreeNode(int x) { val = x; }
     * }
     */
    public class Solution_545
    {
        private int res = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = Depth(root.left);
            int right = Depth(root.right);
            this.res = Math.Max(res, left + right + 1);
            return res - 1;
        }

        private int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = Depth(root.left);
            int right = Depth(root.right);
            this.res = Math.Max(res, left + right + 1);
            return Math.Max(left, right) + 1;
        }
    }
}
