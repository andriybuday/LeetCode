/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        var n = 0;
        var node = head;
        while(node != null) {
            n++;
            node = node.next;
        }
        node = head;
        var i = 0;
        while(i < n/2) {
            var tmp = head.next;
            head.next = node;
            node = head;
            head = tmp;
            ++i;
        }
        if(n % 2 == 1) {
            head = head.next;
        }
        while(node != null && head != null) {
            if(node.val != head.val)
                return false;
            node = node.next;
            head = head.next;
        }
        
        return true;
    }
}