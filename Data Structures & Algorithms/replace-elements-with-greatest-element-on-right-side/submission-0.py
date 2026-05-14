class Solution:
    def replaceElements(self, arr: List[int]) -> List[int]:
        length = len(arr)
        position = 0
        while(position < length - 1):
            maxNumber = 0
            maxPosition = 0
            for i in range(position +1, length):
                if(arr[i]>= maxNumber):
                    maxNumber = arr[i]
                    maxPosition = i

            for j in range(position, maxPosition):
                arr[j] = maxNumber

            position = maxPosition
        arr[length - 1] = -1
        return arr
