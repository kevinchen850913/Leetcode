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
	TreeNode root2;
	public TreeNode InvertTree(TreeNode root)
	{
		if (root == null)
		{
			return null;
		}
		root2 = new TreeNode(root.val, null, null);
		F(root, root2);
		return root2;
	}

	void F(TreeNode root, TreeNode root2)
	{
		if (root.left != null)
		{
			root2.right = new TreeNode(root.left.val, null, null);
			F(root.left, root2.right);
		}
		if (root.right != null)
		{
			root2.left = new TreeNode(root.right.val, null, null);
			F(root.right, root2.left);
		}
		return;
	}
}