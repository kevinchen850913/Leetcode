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
    public bool IsPalindrome(ListNode head)
    {
        List<int> st = new List<int>();
        int n = 1;
        while (head.next != null)
        {
            n++;
            st.Add(head.val);
            head = head.next;
        }
        st.Add(head.val);
        for (int i = 0; i < n / 2; i++)
        {
            if (st[i] != st[n - i - 1])
                return false;
        }
        return true;
    }
}

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
    ListNode root;
    bool rt;
    public bool IsPalindrome(ListNode head)
    {
        root = head;
        rt = true;
        F(head);
        return rt;
    }

    public ListNode F(ListNode Node)
    {
        if (Node == null)
            return root;
        ListNode N = F(Node.next);
        if (N.val != Node.val)
            rt = false;
        return N.next;
    }
}