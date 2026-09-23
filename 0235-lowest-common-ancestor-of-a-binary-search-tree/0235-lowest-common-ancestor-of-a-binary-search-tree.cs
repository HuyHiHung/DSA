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
        //  p.val < root.val < q.val return root;
        if(p.val > q.val) return LowestCommonAncestor(root, q,p);
        if( p.val > root.val) return LowestCommonAncestor(root.right,q,p);
        if( q.val < root.val) return LowestCommonAncestor(root.left,q,p);
        // if( q.val == root.val || p.val == root.val) return root;
        if(p.val <= root.val && root.val <= q.val ){
            return root;
        }
        return root;
    }
}