/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution
{
    TreeNode _target;
    TreeNode ret;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        _target = target;
        DFS(cloned);
        return ret;
    }

    public void DFS(TreeNode cloned)
    {
        TreeNode N;
        if (cloned == null || ret != null)
            return;
        if (cloned.val == _target.val)
        {
            ret = cloned;
            return;
        }
        DFS(cloned.left);
        DFS(cloned.right);
        return;
    }
}