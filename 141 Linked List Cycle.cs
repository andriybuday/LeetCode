/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head == null) return false;
        var n = 0;
        var outer = head;
        var inner = head.next;
        while(outer != null && inner != null) {
            if(outer == inner) {
                return true;
            }
            // move twice
            inner = inner.next;
            if(inner != null) {
                inner = inner.next;
            }
            // move once
            outer = outer.next;
        }
        return false;
    }
}