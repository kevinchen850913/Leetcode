//這篇是參考https://leetcode.com/problems/remove-duplicate-letters/discuss/1859356/This-problem-is-hard.
//It took me such a long time to solve even with reading several hints from the discussion.It contains several key methods :
//
//Gready algorithm : the difficulty part is how to prove the correctness.I did not try that yet.
//Monotonic stack
//Bit mask.Of course, you can use a similaer way to not use the bit mask if you don't want to use it.
//The highlevel logic is :
//
//Put the res in a stack, each time, check whether the back of the res is larger than the current one.
//If the back is larger, then we have possibility to generate a smaller one by pop the last oneand push the current one.
//The step 2 can be repeated if the back is always larger than current one.Such as YZaYZ case, when meet a, you can keep on pop the Yand then Z as you have Yand Z later.The res update process for this exmaple is :
//For easy demo, the Y, Z should be lower case.
//Y: res = "Y"
//    Z : res = "YZ"
//    a : res "YZ", Z > a, we have  Z in the future, pop Z, got "Y".Similar, pop Yand push a we update res = "a"
//    Y: res = "aY"
//    Z : res = "aYZ".
//
//    The step 2 should be stopped if the back is the only letter left.If you pop the only letter, you will fail.
//    Pls check whether the current letter is already visited or not.If already visited, do not need do anything.
//    I am using a bit mask from back to front to indicate whether a specified letter still exist in the future.The mask building process took O(n) and the one pass took O(n), the overrall time complexity is O(n)

//這題比看起來的困難，直覺反應哈希或是堆疊都無法很有效的解決此問題，
//所以就需要混和雙方優點來解題，哈希處理重複問題，堆疊處理排序問題，
//很少遇到複合式的演算法，這方面可能有點缺乏練習。

class Solution {
public:
    bool seen(int visited, char c) {
        return visited & (1 << (c - 'a'));
    }
    string removeDuplicateLetters(string s) {
        const int n = s.size();
        // build bitmask from back. If you are not familar with bitmask, you will feel this is hard to understand.
        vector<int> masks(n + 1, 0);
        for (int i = n - 1; i >= 0; --i) {
            masks[i] = masks[i + 1] | (1 << (s[i] - 'a'));
        }
        string ret;
        int visited = 0;
        for (int i = 0; i < n; ++i) {
            while (!ret.empty() && (!seen(visited, s[i])) && ret.back() > s[i]) {
                // if the back is not the last element
                if (masks[i + 1] & (1 << (ret.back() - 'a'))) {
                    visited ^= (1 << (ret.back() - 'a'));
                    ret.pop_back();
                }
                else {
                    break;
                }
            }
            if (!(seen(visited, s[i]))) {
                visited |= (1 << (s[i] - 'a'));
                ret.push_back(s[i]);
            }

        }
        return ret;

    }
};