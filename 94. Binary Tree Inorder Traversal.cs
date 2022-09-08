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
    public IList<int> L = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {

        if (root == null)
            return L;
        P(root);
        return L;
    }
    public int P(TreeNode N)
    {

        if (N.left != null)
        {
            P(N.left);
        }
        L.Add(N.val);
        if (N.right != null)
        {
            P(N.right);
        }
        return 0;
    }
}