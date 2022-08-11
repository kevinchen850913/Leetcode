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
    private TreeNode prev = null;
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return true;
        if (!IsValidBST(root.left) || prev != null && prev.val >= root.val)
            return false;
        prev = root;
        return IsValidBST(root.right);
    }
}