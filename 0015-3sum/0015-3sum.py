class Solution:
    def threeSum(self, nums: list[int]) -> list[list[int]]:
        nums.sort()

        rs = []
        # edge case cac so bang nhau lien tiep
        for i in range(len(nums)):
            if i > 0 and nums[i] == nums[i-1]:
                continue
            l = i + 1
            r = len(nums) - 1
            while l < r:
                total = nums[l] + nums[r] + nums[i]

                if total == 0:
                    rs.append([nums[i],nums[l],nums[r]])
                    # fix sau khi tim 1 so bo roi van tim tiep dc va skip cac so bang nhau 
                    l += 1
                    r -= 1
                    while l < r and nums[l] == nums[l-1]:
                        l += 1
                    while l < r and nums[r] == nums[r+1]:
                        r -= 1                    
                    
                    #skip dulicate
                elif total < 0:
                    l += 1
                else: r -= 1
        return rs


