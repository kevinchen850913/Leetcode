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
    public int GoodNodes(TreeNode root)
    {
        return F(root, int.MinValue);
    }

    public int F(TreeNode Node, int max)
    {
        int rt = 0;
        if (Node == null)
            return rt;
        if (Node.val >= max)
        {
            rt += 1;
            max = Node.val;
        }
        rt += F(Node.left, max);
        rt += F(Node.right, max);
        return rt;
    }
}