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
    int _max;
    int DFS(TreeNode* root, int lr) {
        if (root == NULL)
            return 0;
        int l = DFS(root->left, 0);
        _max = _max < l ? l : _max;
        int r = DFS(root->right, 1);
        _max = _max < r ? r : _max;
        return lr == 0 ? r + 1 : l + 1;
    }
    int longestZigZag(TreeNode* root) {
        _max = 0;
        int l = DFS(root->left, 0);
        _max = _max < l ? l : _max;
        int r = DFS(root->right, 1);
        _max = _max < r ? r : _max;
        return _max;
    }
};