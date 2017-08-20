public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var mainTarget = 0;
        var n = nums.Length;
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for(int i = 0; i < n - 2; ++i) {
            if(i == 0 || (i > 0 && i < n && nums[i] != nums[i-1])) {
                var target = mainTarget - nums[i];
                var l = i+1;
                var r = n-1;
                while(l < r) {
                    if(nums[l] + nums[r] == target) {
                        result.Add(new List<int>(){nums[i], nums[l], nums[r]});
                        while(l < n-3 && nums[l] == nums[l+1])++l;
                        while(r > 0 && nums[r] == nums[r-1])--r;
                        l++;
                        r--;
                    } else if(nums[l] + nums[r] < target) {
                        l++;
                    } else {
                        r--;
                    }
                }
            }
        }
        return result;
    }
}