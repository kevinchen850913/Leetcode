/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    int _p;
    int _q;
    TreeNode N;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        _p = p.val;
        _q = q.val;
        F(root);
        return N;
    }

    int F(TreeNode node)
    {
        int n = 0;
        if (node == null)
        {
            return 0;
        }
        if (node.val == _p || node.val == _q)
        {
            n += 1;
        }
        n += F(node.left);
        n += F(node.right);
        if (n == 2)
        {
            N = node;
            return -1;
        }
        return n;
    }
}