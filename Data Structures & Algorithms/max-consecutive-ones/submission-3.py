class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        counterConsecutive = 0
        maxCount = 0
       
        for i in nums:
            if(i == 1):
                counterConsecutive += 1
                maxCount = max(maxCount, counterConsecutive)
            else:
                
                counterConsecutive = 0

        return maxCount



        
        