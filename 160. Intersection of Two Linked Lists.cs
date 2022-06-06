/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == headB)
            return headA;
        ListNode LA = headA;
        ListNode LB = headB;
        int A = 0;
        int B = 0;
        while (LA != null)
        {
            A++;
            LA = LA.next;
        }
        while (LB != null)
        {
            B++;
            LB = LB.next;
        }
        LA = headA;
        LB = headB;
        if (A > B)
        {
            for (int i = 0; i < A - B; i++)
            {
                LA = LA.next;
            }
        }
        else
        {
            for (int i = 0; i < B - A; i++)
            {
                LB = LB.next;
            }
        }
        while (LA != null)
        {
            if (LA == LB)
                return LA;
            LA = LA.next;
            LB = LB.next;
        }
        return null;
    }
}