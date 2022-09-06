/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public TreeNode PruneTree(TreeNode root)
    {
        return F(root) ? root : null;
    }

    public bool F(TreeNode Node)
    {
        if (Node == null)
        {
            return false;
        }
        bool b = false;
        if (!F(Node.left))
        {
            Node.left = null;
        }
        else
        {
            b = true;
        }
        if (!F(Node.right))
        {
            Node.right = null;
        }
        else
        {
            b = true;
        }
        return b || Node.val == 1;
    }
}