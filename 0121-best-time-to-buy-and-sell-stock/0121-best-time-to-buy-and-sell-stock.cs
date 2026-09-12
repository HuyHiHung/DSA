public class Solution {
    public int MaxProfit(int[] prices) {
        // 2 vongf for => n^2
        // mucj tiêu tìm cặp số có hiệu lớn nhất, => tìm lowest dung truoc index i
        // => cho marng chay, luu lai so nho nhat truoc phan tu i la dc
        int rs = -1;
        int lowest = 10001;
        foreach ( int p in prices){
            if( p < lowest) lowest = p;
            int currProfit = p - lowest;
            if(currProfit > rs) rs = currProfit;
        }
        return rs;
    }
}