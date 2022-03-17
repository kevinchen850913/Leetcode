//第一版本基本款解題
public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		ListNode head = new ListNode(0);
		ListNode aux = head;
		int sum = 0, extra = 0;
		while (l1 != null || l2 != null)
		{
			sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + extra;
			aux.next = new ListNode(sum % 10);
			extra = sum / 10;
			aux = aux.next;
			l1 = l1 != null ? l1.next : null;
			l2 = l2 != null ? l2.next : null;
		}

		if (extra != 0)
			aux.next = new ListNode(extra);

		return head.next;
	}
}

//第二版爆開稍微加速
public class Solution
{
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		ListNode head = new ListNode(0);
		ListNode aux = head;
		int sum = 0, extra = 0;
		while (l1 != null && l2 != null)
		{
			sum = l1.val + l2.val + extra;
			aux.next = new ListNode(sum % 10);
			extra = sum > 9 ? 1 : 0;
			aux = aux.next;
			l1 = l1.next;
			l2 = l2.next;
		}
		if (l1 != null)
		{
			while (extra != 0 && l1 != null)
			{
				sum = l1.val + extra;
				aux.next = new ListNode(sum % 10);
				extra = sum > 9 ? 1 : 0;
				aux = aux.next;
				l1 = l1.next;
			}
			aux.next = l1;
		}
		else if (l2 != null)
		{
			while (extra != 0 && l2 != null)
			{
				sum = l2.val + extra;
				aux.next = new ListNode(sum % 10);
				extra = sum > 9 ? 1 : 0;
				aux = aux.next;
				l2 = l2.next;
			}
			aux.next = l2;
		}
		if (extra != 0)
			aux.next = new ListNode(extra);

		return head.next;
	}
}

//看別人的寫法有夠潮，不過效能沒比較好
//exp1?.prop??exp2 功能相等 exp1==null?exp2:exp1.prop.
public ListNode AddTwoNumbers(ListNode p, ListNode q)
{
	ListNode dummy = new ListNode(0), curr = dummy;
	while (p != null || q != null || dummy.val != 0)
	{ // use dummy.val as carry ;)
		int sum = (p?.val ?? 0) + (q?.val ?? 0) + dummy.val;
		dummy.val = sum / 10;
		curr = curr.next = new ListNode(sum % 10);
		p = p?.next;
		q = q?.next;
	}

	return dummy.next;
}