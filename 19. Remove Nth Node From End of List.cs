/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null)
        {
            return null;
        }
        ListNode LA = head;
        for (int i = 0; i < n; i++)
        {
            LA = LA.next;
        }
        if (LA == null)
        {
            return head.next;
        }
        else
        {
            LA = LA.next;
        }
        ListNode LB = head;
        while (LA != null)
        {
            LA = LA.next;
            LB = LB.next;
        }
        LB.next = LB.next.next;
        return head;
    }
}