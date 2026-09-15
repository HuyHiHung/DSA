public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r =  nums.Length - 1;
        bool isSorted = nums[l] < nums[r] ? true : false;
        int m;
        while( l < r){
            m = (l+r) / 2;
            Console.WriteLine(l);
            Console.WriteLine(r);
            if( nums[m] == target) return m;
            if(nums[l] <= nums[m] ){ // left sorted
                if(nums[l] <= target && target < nums[m]){ // target in left sorted
                    r = m;
                } else { // target in rigth none sorted
                    l = m + 1;
                }

            } else { // right sorted
                if(nums[m] < target && target <= nums[r]){
                    l = m + 1;
                } else {
                    r = m;
                }
            }


        }
        return nums[l] ==  target ? l : -1;
    }
}