/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1Node, ListNode l2Node) {
        int current = 0;
        int next = 0;
        
        ListNode l1 = l1Node;
        ListNode l2 = l2Node;
        ListNode root = new ListNode(0);
        ListNode l3 = root;
        
        while(l1 != null || l2 != null) {
            current = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + next;
            next = (current - 10) >= 0 ? 1 : 0;
            current = (current - 10) >= 0 ? current - 10 : current;
            
            ListNode lnew = new ListNode(current);
            l3.next = lnew;
            l3 = lnew;
            
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        
        if(next > 0) {
            ListNode lnew = new ListNode(1);
            l3.next = lnew;
            l3 = lnew;
        }
        
        return root.next;
    }
}