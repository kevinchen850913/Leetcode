class Char {
public:
    Char() {
        for (int i = 0; i < 26; ++i) {
            next[i] = INT_MAX;
        }
    }
    int get(char c) {
        return next[c - 'a'];
    }
    void set(char c, int n) {
        next[c - 'a'] = n;
    }
    void assign(const Char& c) {
        for (int i = 0; i < 26; ++i) {
            next[i] = c.next[i];
        }
    }
    int next[26];
};

class Solution {
public:
    int numMatchingSubseq(string S, vector<string>& words) {
        vector<Char> chars(S.size() + 1);
        Char pos;
        for (int i = S.size() - 1; i >= 0; --i) {
            chars[i + 1].assign(pos);
            pos.set(S[i], i + 1);
        }
        chars[0].assign(pos);

        int result = 0;
        for (auto word : words) {
            bool flg = true;
            int next = 0;
            for (int i = 0; i < word.size(); ++i) {
                next = chars[next].get(word[i]);
                if (next == INT_MAX) {
                    flg = false;
                    break;
                }
            }
            if (flg) {
                ++result;
            }
        }
        return result;
    }
};