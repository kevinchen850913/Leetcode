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
    public IList<double> AverageOfLevels(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            double sum = 0;
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                sum += curr.val;
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
            res.Add(sum / size);
        }
        return res;
    }
}

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
    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<TreeNode> A = new List<TreeNode>();
        List<TreeNode> B = new List<TreeNode>();
        IList<double> C = new List<double>();
        double ALL = 0;
        double Cnt = 0;
        A.Add(root);
        while (A.Count > 0)
        {
            ALL = 0;
            Cnt = 0;
            foreach (TreeNode n in A)
            {
                ALL += n.val;
                Cnt++;
                if (n.left != null)
                {
                    B.Add(n.left);
                }
                if (n.right != null)
                {
                    B.Add(n.right);
                }
            }
            A = new List<TreeNode>();
            foreach (TreeNode n in B)
            {
                A.Add(n);
            }
            B = new List<TreeNode>();
            C.Add(ALL / Cnt);
        }
        return C;
    }
}