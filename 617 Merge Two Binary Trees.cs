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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if(t1 != null && t2 != null) {
            var tm = new TreeNode(t1.val + t2.val);
            tm.left = MergeTrees(t1.left, t2.left);
            tm.right = MergeTrees(t1.right, t2.right);
            return tm;
        } else if(t1 != null) {
            return t1;
        } else if(t2 != null) {
            return t2;
        }
        return null;
    }
}