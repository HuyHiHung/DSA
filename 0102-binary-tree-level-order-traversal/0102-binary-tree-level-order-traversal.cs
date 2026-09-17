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
        List<int> list = new();
        List<IList<int>> rs = new();
        Queue<(TreeNode node, int depth)> q = new();
        q.Enqueue((root, 0));
        while (q.Count > 0){         
            var item = q.Dequeue();
            TreeNode node = item.node;
            int depth = item.depth;
            if (rs.Count <= depth)
                rs.Add(new List<int>());

            rs[depth].Add(item.node.val);
            depth++;
            if(node.left != null)  q.Enqueue((node.left, depth));
            if(node.right != null) q.Enqueue((node.right, depth));
        }
        return rs; 
    }
}