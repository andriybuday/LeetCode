/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode node) {
        if(node == null) {
            return 0;
        }
        return 1 + Math.Max(MaxDepth(node.left), MaxDepth(node.right));
    }
}