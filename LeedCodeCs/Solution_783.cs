using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCs
{
    class Solution_783
    {
        int ans, prev;
        bool flag;
        public int MinDiffInBST(TreeNode root)
        {
            ans = Int32.MaxValue;
            dfs(root);
            return ans;
        }

        public void dfs(TreeNode node)
        {
            if (node == null) return;
            dfs(node.left);

            if (flag)
                ans = Math.Min(ans, node.val - prev);
            prev = node.val;
            flag = true;
            dfs(node.right);
        }

    }
}
