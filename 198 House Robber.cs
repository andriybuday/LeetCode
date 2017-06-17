public class Solution {
    public int Rob(int[] nums) {
        int prevMax = 0;
        int prevPrevMax = 0;
        for(int i = 0; i < nums.Length; ++i) {
            var x = prevMax;
            prevMax = Math.Max(prevMax, prevPrevMax + nums[i]);
            prevPrevMax = x;
        }
        return prevMax;
    }
}