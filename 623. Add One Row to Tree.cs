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
    int m_val;
    int m_depth;
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth == 1)
        {
            TreeNode Node = new TreeNode();
            Node.val = val;
            Node.left = root;
            return Node;
        }
        m_val = val;
        m_depth = depth;
        DFS(root, 2);
        return root;
    }

    void DFS(TreeNode Node, int n)
    {
        if (Node == null)
        {
            return;
        }
        if (m_depth != n)
        {
            DFS(Node.left, n + 1);
            DFS(Node.right, n + 1);
        }
        else
        {
            TreeNode N = new TreeNode();
            N.val = m_val;
            N.left = Node.left;
            Node.left = N;
            N = new TreeNode();
            N.val = m_val;
            N.right = Node.right;
            Node.right = N;
        }
        return;
    }
}

//簡化TreeNode的產生方式
public class Solution
{
    int m_val;
    int m_depth;
    public TreeNode AddOneRow(TreeNode root, int val, int depth)
    {
        if (depth == 1)
        {
            return new TreeNode(val, root, null);
        }
        m_val = val;
        m_depth = depth;
        DFS(root, 2);
        return root;
    }

    void DFS(TreeNode Node, int n)
    {
        if (Node == null)
        {
            return;
        }
        if (m_depth != n)
        {
            DFS(Node.left, n + 1);
            DFS(Node.right, n + 1);
        }
        else
        {
            Node.left = new TreeNode(m_val, Node.left, null);
            Node.right = new TreeNode(m_val, null, Node.right);
        }
        return;
    }
}