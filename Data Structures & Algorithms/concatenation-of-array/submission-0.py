class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        length = len(nums)
        ans = []
        for i in range(length):
            ans.append(nums[i])
        for i in range(length):
            ans.append(nums[i])
        

        return ans
            

        