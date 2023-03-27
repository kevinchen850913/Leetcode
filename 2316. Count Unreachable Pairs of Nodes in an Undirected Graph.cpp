class Solution {
public:
    int dfs(vector<vector<int>>& nums, vector<bool>& b, int i) {
        int n = 1;
        b[i] = true;
        for (auto v : nums[i])
        {
            if (!b[v])
            {
                n += dfs(nums, b, v);
            }
        }
        return n;
    }

    long long countPairs(int n, vector<vector<int>>& edges) {
        vector<vector<int>> nums(n);
        vector<bool> b(n);
        long long temp1 = 0, temp2 = 0, rt = 0;
        for (auto v : edges)
        {
            nums[v[0]].push_back(v[1]);
            nums[v[1]].push_back(v[0]);
        }
        for (int i = 0; i < b.size(); i++)
        {
            if (!b[i])
            {
                temp1 = dfs(nums, b, i);
                rt += temp1 * temp2;
                temp2 += temp1;
            }
        }
        return rt;
    }
};