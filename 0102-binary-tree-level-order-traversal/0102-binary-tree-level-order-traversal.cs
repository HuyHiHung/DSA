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

    public IList<IList<int>> LevelOrder(TreeNode root) {
        // chuyển về bài toán ủi phẳng cây theo depth, phari theo kiểu bfs
        // tới 1 nút, add trái phải rồi mới đệ quy
        // điều kiện để tiến tới depth++ là đã hết nút ở depth
        if(root == null) return [];
        
        List<IList<int>> rs = new();
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while (q.Count > 0){    
            int levelSize = q.Count;
            List<int> list = new(); 
            for( int i = 0; i < levelSize; ++i){
                TreeNode item = q.Dequeue();
                list.Add(item.val);
                if(item.left != null)  q.Enqueue(item.left);
                if(item.right != null) q.Enqueue(item.right);
            }
            rs.Add(list);    
        }
        return rs; 
    }
}