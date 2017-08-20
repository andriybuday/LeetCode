/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var root = new ListNode(0);
        var tmp = root;
        while(l1 != null && l2 != null) {
            if(l1.val < l2.val) {
                tmp.next = l1;
                l1 = l1.next;
            } else {
                tmp.next = l2;
                l2 = l2.next;
            }
            tmp = tmp.next;
        }
        var leftOver = l1 != null ? l1 : l2;
        if(leftOver != null) {
            tmp.next = leftOver;
            leftOver = leftOver.next;
        }
        return root.next;
    }
}