class Solution {
public:
    bool isValid(string s) {
        vector<char> vec;
        for (auto c : s)
        {
            switch (c)
            {
            case '(':
                vec.push_back(')');
                break;
            case '{':
                vec.push_back('}');
                break;
            case '[':
                vec.push_back(']');
                break;
            case ')':
            case '}':
            case ']':
                if (vec.empty() || vec.back() != c)
                    return false;
                vec.pop_back();
                break;
            }
        }
        return vec.empty();
    }
};