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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || root == p || root == q) return root;
        var r = LowestCommonAncestor(root.right, p, q);
        var l = LowestCommonAncestor(root.left, p, q);
        if(r != null && l != null) return root;
        if(r != null) return r;
        if(l != null) return l;
        return null;
    }
}