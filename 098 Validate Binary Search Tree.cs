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
    public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, Int64.MinValue, Int64.MaxValue);
    }
    public bool IsValidBST(TreeNode root, Int64 minValue, Int64 maxValue) {
        if(root == null) return true;
        if((Int64)root.val <= minValue || (Int64)root.val >= maxValue) return false;
        var leftValid = root.left == null || IsValidBST(root.left, minValue, root.val);
        var rightValid = root.right == null || IsValidBST(root.right, root.val, maxValue);
        return leftValid && rightValid;
    }
}