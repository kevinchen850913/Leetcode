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
    public IList<int> L;
    public IList<IList<int>> LL;
    Queue<TreeNode> q1 = new Queue<TreeNode>();
    Queue<TreeNode> q2 = new Queue<TreeNode>();
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        LL = new List<IList<int>>();
        if (root != null)
            q1.Enqueue(root);
        while (q1.Count != 0)
        {
            L = new List<int>();
            while (q1.Count != 0)
                q2.Enqueue(q1.Dequeue());
            while (q2.Count != 0)
                F(q2.Dequeue());
            LL.Add(L);
        }
        return LL;
    }

    public void F(TreeNode N)
    {
        if (N.left != null)
            q1.Enqueue(N.left);
        if (N.right != null)
            q1.Enqueue(N.right);
        L.Add(N.val);
        return;
    }
}