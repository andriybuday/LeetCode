/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        var d = new Dictionary<RandomListNode,RandomListNode>();
        var node = head;
        while(node != null) {
            var r = new RandomListNode(node.label);
            d.Add(node, r);
            node = node.next;
        }
        node = head;
        while(node != null) {
            var r = d[node];
            if(node.next != null)
                r.next = d[node.next];
            if(node.random != null)
                r.random = d[node.random];
            node = node.next;
        }
        return d.FirstOrDefault().Value;
    }
}