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
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null)
            return null;
        if (root.val == val)
            return root;
        TreeNode N = SearchBST(root.left, val);
        if (N == null)
            N = SearchBST(root.right, val);
        return N;
    }
}