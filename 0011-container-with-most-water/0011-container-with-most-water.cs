public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length -1;
        int max=-1;
        int curr;
        
        while (l < r){
            curr = Math.Min(height[l],height[r])* (r-l);
            if(curr >= max){
                max = curr;
            }
            if(height[l]< height[r]){
                l +=1;
            } else {
                r-=1;
            }
        }
        return max;
    }
}
// bằng cái thấp nhì nhân với range rộng => tìm max tích của thấp nhì*range