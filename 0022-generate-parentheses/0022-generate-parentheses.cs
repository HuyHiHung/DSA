public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        // điều kiện để hợp lệ? 
        // cứ liệt kê ra, trước lúc add thì thêm điều kiện
        // có thể viết thêm 1 dòng để xóa bớt cái case 0, giảm 1 nửa độ phức tạp
        if( n == 1) return ["()"];
        List<string> rs = new();
        string s = "()";
        StringBuilder curr = new StringBuilder();
        bool isParentheses(string s){
            Stack<char> stack = new Stack<char>();
            foreach ( char c in s){
                if(c=='('){
                    stack.Push('('); 
                } else { // ')'
                    if(stack.Count == 0) return false;
                    if(stack.Pop()!='(') return false;
                }   
            }
            if(stack.Count != 0) return false;  
            return true;
        }
        void backTrack(int count){
            // điều kiện dừng + điều kiện Add
            if(count == 2*n){
                if(isParentheses(curr.ToString())) {
                    rs.Add(curr.ToString()); 
                }
                return;
            }
            // quay lui
            foreach (char c in s){
                curr.Append(c);
                //
                backTrack(count + 1);
                // quay lui khucs này
                curr.Length--;
                
            }
        }
        backTrack(0);
        return rs;
    }
}