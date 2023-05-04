class Solution {
public:
    vector<vector<int>> findDifference(vector<int>& nums1, vector<int>& nums2) {
        vector<int> vec1, vec2;
        set<int> set1(nums1.begin(), nums1.end());
        set<int> set2(nums2.begin(), nums2.end());
        for (auto n : set1) if (!set2.count(n)) vec1.push_back(n);
        for (auto n : set2) if (!set1.count(n)) vec2.push_back(n);
        return { vec1, vec2 };
    }
};