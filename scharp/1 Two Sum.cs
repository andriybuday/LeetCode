public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var n = nums.Length;
        var d = new Dictionary<int, int>();
        for (int i = 0; i < n; ++i) {
            var needed = target - nums[i];
            if(d.ContainsKey(needed)) {
                return new int[] {d[needed], i};
            }
            d[nums[i]] = i;
        }
        return null;
    }
}