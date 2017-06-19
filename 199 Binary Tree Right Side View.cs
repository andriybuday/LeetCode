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
    public IList<int> RightSideView(TreeNode root) {
        var res = new List<int>();
        if(root == null) {
            return res;
        }
        res.Add(root.val);
        if(root.left != null && root.right == null) {
            res.AddRange(RightSideView(root.left));
        }
        if(root.left == null && root.right != null) {
            res.AddRange(RightSideView(root.right));
        }
        if(root.left != null && root.right != null) {
            var v1 = RightSideView(root.right);
            var v2 = RightSideView(root.left);
            res.AddRange(v1);
            for(int i = v1.Count; i < v2.Count; ++i) {
                res.Add(v2[i]);
            }
        }
        return res;
    }
}