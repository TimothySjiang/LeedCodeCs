using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    public class Solution_572
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (isMatch(s, t))
            {
                return true;
            }

            if (s == null)
            {
                return false;
            }
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private bool isMatch(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }

            if (root1 == null || root2 == null)
            {
                return false;
            }

            if (root1.val != root2.val)
            {
                return false;
            }

            return isMatch(root1.left, root2.left) && isMatch(root1.right, root2.right);

        }
    }
}
