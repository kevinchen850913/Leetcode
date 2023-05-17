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
    ListNode* swapPairs(ListNode* head) {
        if (!head || !head->next)
            return head;
        ListNode* node1 = new ListNode();
        ListNode* node2 = head;
        head = head->next;
        while (node2 && node2->next)
        {
            node1->next = node2->next;
            node2->next = node2->next->next;
            node1->next->next = node2;
            node1 = node2;
            node2 = node1->next;
        }
        return head;
    }
};