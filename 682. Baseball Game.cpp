class Solution {
public:
    int calPoints(vector<string>& operations) {
        vector<int> vec;
        int n = 0;
        for (auto str : operations)
        {
            if (str == "+")
            {
                vec.push_back(vec[vec.size() - 1] + vec[vec.size() - 2]);
            }
            else if (str == "D")
            {
                vec.push_back(2 * vec.back());
            }
            else if (str == "C")
            {
                vec.pop_back();
            }
            else
            {
                vec.push_back(stoi(str));
            }
        }
        for (auto i : vec)
        {
            n += i;
        }
        return n;
    }
};