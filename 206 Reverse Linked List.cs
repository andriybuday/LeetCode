/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode node = null;
        while(head != null) {
            var tmp = new ListNode(head.val);
            tmp.next = node;
            node = tmp;
            head = head.next;
        }
        return node;
    }
}