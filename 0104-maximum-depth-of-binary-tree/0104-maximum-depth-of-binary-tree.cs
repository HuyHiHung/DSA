/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        // index 0 => l, r = 1,2
        // index 1 => 3,4
        // index 2 => 5,6
        // => 2 node lá là 2*index+1, 2*index+2
        if (root == null) return 0;

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);

        return 1 + Math.Max(left, right);

    }
}