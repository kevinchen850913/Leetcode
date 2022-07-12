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
    IList<int> L;
    public IList<int> RightSideView(TreeNode root)
    {
        L = new List<int>();
        F(root, 1);
        return L;
    }
    public void F(TreeNode Node, int n)
    {
        if (Node == null)
        {
            return;
        }
        if (L.Count < n)
        {
            L.Add(Node.val);
        }
        F(Node.right, n + 1);
        F(Node.left, n + 1);
        return;
    }
}