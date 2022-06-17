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
    int Output;
    public int DistributeCoins(TreeNode root)
    {
        Output = 0;
        DFS(root);
        return Output;
    }

    int DFS(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }
        int n = DFS(node.left) + DFS(node.right) + node.val - 1;
        Output += Math.Abs(n);
        return n;
    }
}