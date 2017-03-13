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
    public int SumOfLeftLeaves(TreeNode root) {
        if(root == null) return 0;
        if(root.left != null && root.left.left == null && root.left.right == null) {
            return root.left.val + SumOfLeftLeaves(root.right);
        }
        return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right);
    }
}