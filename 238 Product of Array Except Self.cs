public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // n > 1
        var n = nums.Length;
        var result = new int[n];
        result[0] = 1;
        var tmp = 1;
        for(var i = 1; i < n; ++i) {
            tmp *= nums[i-1];
            result[i] = tmp;
        }
        tmp = 1;
        for(var i = n-2; i >= 0; --i) {
            tmp *= nums[i+1];
            result[i] = result[i] * tmp;
        }
        return result;
    }
}