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
    public string Tree2str(TreeNode t) {
        if(t == null) return "";
        var l = Tree2str(t.left);
        var r = Tree2str(t.right);
        if(r != "")
            return $"{t.val}({l})({r})";
        else if(l != "")
            return $"{t.val}({l})";
        else
            return $"{t.val}";
    }
}