class Solution {
public:
    string removeStars(string s) {
        vector<char> vec;
        for (auto c : s)
        {
            if (c == '*')
            {
                vec.pop_back();
            }
            else
            {
                vec.push_back(c);
            }
        }
        return string(vec.begin(), vec.end());
    }
};