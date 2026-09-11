public class Solution {
    public int Divide(int dividend, int divisor) {
        // chạy dòng while, lấy dividend-=  divisor liên tục cho đến khi đổi dấu => cần xử lý số âm dương
        // số lớn chia cho 1 chắc chết luôn :D 

        // chuyển về cơ số divisor rồi shift 1 bit? 
        // => cũng là shift bit nhưng mà giữ nguyên phị nhân
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue;
        bool negative = false;

        if (dividend < 0 && divisor > 0)
        {
            negative = true;
        }

        if (dividend > 0 && divisor < 0)
        {
            negative = true;
        }

        long a = Math.Abs((long)dividend);
        long b = Math.Abs((long)divisor);

        long rs = 0;

        for (int i = 31; i >= 0; --i) {

            // b * 2^i <= a
            if ((b << i) <= a) {
                a -= b << i;
                rs += 1L << i; // 1* 2^i
            }
        }
        return negative ? (int)-rs : (int)rs;     
    }
}