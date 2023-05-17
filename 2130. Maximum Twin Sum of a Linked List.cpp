/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    int pairSum(ListNode* head) {
        // 竟然會確認記憶體，不給偷。
        // while(head)
        //     vec.push_back(head->val);
        // Memory Limit Exceeded

        int Max = 0;
        vector<int> vec;
        ListNode* node = head;
        while (node && node->next)
        {
            vec.push_back(head->val);
            node = node->next->next;
            head = head->next;
        }
        int i = vec.size() - 1;
        while (head)
        {
            Max = max(Max, head->val + vec[i]);
            head = head->next;
            i--;
        }
        return Max;
    }
};