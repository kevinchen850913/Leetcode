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
    int notCover = 0, hasCamera = 1, covered = 2;
    int res = 0;
    public int MinCameraCover(TreeNode root)
    {
        return helper(root) == 0 ? res + 1 : res;
    }

    public int helper(TreeNode root)
    {
        if (root == null) return covered;
        int left = helper(root.left), right = helper(root.right);
        if (left == notCover || right == notCover)
        {
            res++;
            return hasCamera;
        }
        else if (left == hasCamera || right == hasCamera)
        {
            return covered;
        }
        else
        {
            return notCover;
        }
    }
}