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
    ListNode* swapNodes(ListNode* head, int k) {
        ListNode* p1 = head;
        ListNode* p2 = head;
        for (int i = 0; i < k - 1; i++)
            p1 = p1->next;
        ListNode* p3 = p1;
        while (p1->next != NULL)
        {
            p1 = p1->next;
            p2 = p2->next;
        }
        swap(p2->val, p3->val);
        return head;
    }
};