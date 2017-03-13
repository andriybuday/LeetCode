public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var nums = new List<int>();
        var i1 = 0;
        var i2 = 0;
        var n1 = nums1.Length;
        var n2 = nums2.Length;
        while(i1 < n1 && i2 < n2) {
            if(nums1[i1] < nums2[i2]) {
                nums.Add(nums1[i1]);
                ++i1;
            } else {
                nums.Add(nums2[i2]);
                ++i2;
            }
        }
        while(i1 < n1) {
            nums.Add(nums1[i1]);
            ++i1;
        }
        while(i2 < n2) {
            nums.Add(nums2[i2]);
            ++i2;
        }
        var n = nums.Count;
        if(n % 2 == 0) {
            return (double)(nums[n/2] + nums[n/2 - 1]) / 2.0;
        } else {
            return nums[n/2];
        }
    }
}