public class Solution {

    bool palindromic(string s){
        int len = s.Length;
        if( len == 1) return true;
        for( int i = 0; i < len/2; ++i){
            if(s[i] != s[len-1-i]) return false;
        }
        return true;
    }
    public string LongestPalindrome(string s) {
        StringBuilder rs = new StringBuilder();
        StringBuilder bd = new StringBuilder();
        int max = 0;
        for( int i = 0; i < s.Length; i++ ){
            for(int j = 0; j <= s.Length-i; ++j){
                if(palindromic(bd.Append(s,i,j).ToString())){
                    if( max < bd.Length){
                        max = bd.Length;
                        rs.Clear();
                        rs.Append(bd);
                    }
                }
                bd.Clear();
            }

        }
        return rs.ToString();
    }
}