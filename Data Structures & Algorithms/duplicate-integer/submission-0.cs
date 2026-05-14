public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int i = 0;
        while( i<nums.Length-1){
            if(nums[i] == nums[i+1])
            {
                return true;
            }
            else i++;
        }

        return false;

    }
}