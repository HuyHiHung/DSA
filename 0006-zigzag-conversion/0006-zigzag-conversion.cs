using System.Text;
public class Solution {
    // PAYPALISHIRING len 14
    // ex0: 3 row => mul 5: 14 mod 4 = 3 dư 2 => 4 cột 
    //char?[,] board = new char?[3, 4]; rồi nén vào và duyệt :D
    // cách 2
    // step đc xé thành 2 bước nhảy tương ứng với hàng
    public string Convert(string s, int numRows) {
        
        int len = s.Length;
        if(numRows==1) return s;
        int step = 2*numRows - 2; //6
        StringBuilder result = new StringBuilder();
        int j = 0;
        while(j< numRows){
            int step1 = step - 2*j;
            int step2 = 2*j;

            if (step1 == 0)
            {
                step1 = step2;
            }
            else if (step2 == 0)
            {
                step2 = step1;
            }
            bool first=true;
            for( int i =j; i<len;){
                result.Append(s[i]);
                i += first ? step1 : step2;
                first = !first;
            }
            j++;
        }
        return result.ToString();
    }
}
