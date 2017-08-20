/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var nodeA = headA;
        var nodeB = headB;
        int i = 0;
        while(headA != null) {
            headA = headA.next;
            i++;
        }
        int j = 0;
        while(headB != null) {
            headB = headB.next;
            j++;
        }
        while(i < j) {
            nodeB = nodeB.next;
            j--;
        }
        while(j < i) {
            nodeA = nodeA.next;
            i--;
        }
        while(i > 0) {
            if(nodeA == nodeB)
                return nodeA;
            i--;
            nodeB = nodeB.next;
            nodeA = nodeA.next;
        }
        return null;
    }
}