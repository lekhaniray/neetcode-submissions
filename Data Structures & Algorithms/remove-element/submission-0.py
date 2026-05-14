class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        k = len(nums)
        counter = 0
        while(counter < k):
            if(nums[counter] == val):
                for j in range(counter, k - 1):
                    nums[j] = nums[j+1]
                k -= 1
            else:
                counter += 1
                

        return k
