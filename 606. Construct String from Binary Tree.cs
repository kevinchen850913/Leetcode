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
    public string Tree2str(TreeNode root)
    {
        if (root == null)
        {
            return "";
        }
        string left = "";
        string right = "";
        left = Tree2str(root.left);
        right = Tree2str(root.right);
        if (right != "")
        {
            left = "(" + left + ")";
            right = "(" + right + ")";
        }
        else if (left != "")
        {
            left = "(" + left + ")";
        }
        return root.val + left + right;
    }
}