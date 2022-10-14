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
    public ListNode DeleteMiddle(ListNode head)
    {
        ListNode nodeA = head;
        ListNode nodeB = head;
        if (head.next == null)
        {
            return null;
        }
        if (head.next.next == null)
        {
            head.next = null;
            return head;
        }
        while (nodeA.next != null)
        {
            nodeA = nodeA.next;
            nodeB = nodeB.next;
            if (nodeA.next == null)
            {
                break;
            }
            nodeA = nodeA.next;
        }
        nodeB.val = nodeB.next.val;
        nodeB.next = nodeB.next.next;
        return head;
    }
}