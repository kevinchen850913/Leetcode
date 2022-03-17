class Solution {
public:
    int scoreOfParentheses(string s) {

        stack<int> st;
        int ind = 0;

        for (auto i : s)
        {
            if (i == '(')
            {
                st.push(ind);
                ind = 0;
            }
            else
            {
                ind = st.top() + (ind < 1 ? 1 : ind * 2);
                st.pop();
            }
        }
        return ind;
    }
};