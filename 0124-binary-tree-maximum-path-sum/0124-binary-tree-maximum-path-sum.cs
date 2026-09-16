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
    static int MNR = -1001;
    static int MR  = -1001;
    public int MaxNoneRoof(TreeNode root) { // de quy truong hop tinh roof cho tat ca cac
        if (root == null) return 0;

        int x = Math.Max(
            Math.Max(
                root.val + MaxNoneRoof(root.left),
                root.val + MaxNoneRoof(root.right)
            ),
            root.val
        );
        if( MNR < x) MNR =x;
        return x;
    }
    public void MaxRoof(TreeNode root) {
        if (root == null) return;

        int x = root.val
            + MaxNoneRoof(root.left)
            + MaxNoneRoof(root.right);

        MR = Math.Max(MR, x);

        MaxRoof(root.left);
        MaxRoof(root.right);
    }
    public int MaxPathSum(TreeNode root) {
        MaxNoneRoof(root);
        MaxRoof(root);
        int rs =  Math.Max(MNR, MR);
        MNR = -1001;
        MR  = -1001;
        return rs;
    }
}
        // if(root == null ) return 0;
        // int roof = root.val + MaxPathSum(root.left) + MaxPathSum(root.right);
        // if( max < roof ) max = roof;
        // Console.WriteLine(root.val +" " + max);
/// return Math.Max(root.val + Math.Max(MaxPathSum(root.left), MaxPathSum(root.right)) , max);