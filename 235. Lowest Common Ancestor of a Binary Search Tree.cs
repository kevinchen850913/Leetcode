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
    TreeNode N, P, Q;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        P = p;
        Q = q;
        F(root);
        return N;
    }
    public bool F(TreeNode node)
    {
        int i = 0;
        if (node == null || N != null)
            return false;
        if (node == P || node == Q)
            i++;
        if (F(node.left))
            i++;
        if (F(node.right))
            i++;
        if (i == 1)
            return true;
        else if (i == 2)
            N = node;
        return false;
    }
}