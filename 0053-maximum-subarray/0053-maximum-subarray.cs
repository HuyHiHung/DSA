public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = -10001;
        int curr = -10001;
        foreach (int n in nums) {
            curr+=n;
            if( n > curr ) curr = n;     
            if( max < curr) max = curr;
        }
        return max;
    }
}