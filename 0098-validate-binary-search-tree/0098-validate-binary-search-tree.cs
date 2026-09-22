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

    

    public int max(TreeNode root){
        while(root.right != null) {
            root = root.right;
        }
        return root.val;
    }
    public int min(TreeNode root){
        while(root.left != null) {
            root = root.left;
        }
        return root.val;
    }
    public bool IsValidBST(TreeNode root) {

        // tại 1 node kiểm tra maximum của cây bên trái và minimum bên phải
        // cần 1 hàm trả về maximum và minimum 
        // kiem tra val left < curr < right
        // hoặc tại 1 node kiểm tra giá trị node trái và phải sau đó đệ quy xuống? => bug: nếu như 5->7, 4<-7 => sai


        if(root == null) return true;
        if(root.right != null){
            if( root.right.val <= root.val || root.val >= min(root.right)) return false;
        }
        if(root.left != null){
            if( root.left.val >= root.val || max(root.left) >= root.val ) return false;
        }
        return IsValidBST(root.left) && IsValidBST(root.right);
        return true;
        
    }
}