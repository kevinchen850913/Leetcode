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
    public void Flatten(TreeNode root)
    {
        TreeNode n;
        if (root == null)
        {
            return;
        }
        Flatten(root.right);
        Flatten(root.left);
        if (root.left != null)
        {
            n = root.right;
            root.right = root.left;
            root.left = null;
            while (root.right != null)
            {
                root = root.right;
            }
            root.right = n;
        }
        return;
    }
}