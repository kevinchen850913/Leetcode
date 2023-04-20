/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    vector<uint> vec;
    int max = 0;
    int widthOfBinaryTree(TreeNode* root) {
        DFS(root, 0, 0);
        return max + 1;
    }

    void DFS(TreeNode* root, int y, uint x)
    {
        if (root == NULL)
            return;
        if (vec.size() <= y)
            vec.push_back(x);
        else
            max = max < x - vec[y] ? x - vec[y] : max;
        DFS(root->left, y + 1, 2 * x);
        DFS(root->right, y + 1, 2 * x + 1);
        return;
    }
};