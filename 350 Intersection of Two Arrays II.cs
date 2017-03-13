public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        var l = new List<int>();
        var i = 0;
        var j = 0;
        while(i < nums1.Length && j < nums2.Length) {
            var curr = nums1[i];
            if(curr == nums2[j]) {
                l.Add(curr);
                i++;
                j++;
            } else if(curr < nums2[j]) {
                i++;
            } else {
                j++;
            }
        }
        return l.ToArray();
    }
}