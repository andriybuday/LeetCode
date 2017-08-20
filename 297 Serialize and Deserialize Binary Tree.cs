/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        return serialize(root, 0, 0);
    }
    
    public string serialize(TreeNode root, int isRight, int level) {
        if(root == null) return "";
        var left = serialize(root.left, 0, level + 1);
        var right = serialize(root.right, 1, level + 1);
        return $"{level}|{root.val}|{isRight} {left} {right}";
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(data == "") return null;
        var vals = data.Split(' ').Where(s => s != "").Select(d => d.Split('|').Select(x => Int32.Parse(x)).ToArray()).ToList();
        return deserialize(vals, 0, vals.Count, 0);
    }
    private TreeNode deserialize(List<int[]> vals, int l, int r, int level) {
        if(l >= r) return null;
        var root = new TreeNode(vals[l][1]);
        var nLevel = level + 1;
        var lInd = -1;
        var rInd = -1;
        for(int i = l+1; i < r; ++i) {
            if(lInd < 0 && vals[i][0] == nLevel && vals[i][2] == 0) {
                lInd = i;
            }
            if(rInd < 0 && vals[i][0] == nLevel && vals[i][2] == 1) {
                rInd = i;
                break;
            }
        }
        if(lInd > 0 && rInd > 0) {
            root.left = deserialize(vals, lInd, rInd, nLevel);
            root.right = deserialize(vals, rInd, r, nLevel);
            return root;
        }
        else if(lInd > 0) {
            root.left = deserialize(vals, lInd, r, nLevel);
            return root;
        } else if(rInd > 0) {
            root.right = deserialize(vals, rInd, r, nLevel);
            return root;
        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));