public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        // Well, with LINQ this would be
        //return nums1.Intersect(nums2).ToArray();
        Array.Sort(nums1);
        Array.Sort(nums2);
        var l = new List<int>();
        var i = 0;
        var j = 0;
        var last = (nums1.Length > 0 && nums1[0] != int.MaxValue) ? int.MaxValue : int.MinValue;
        while(i < nums1.Length && j < nums2.Length) {
            var curr = nums1[i];
            if(curr == nums2[j] && curr != last) {
                l.Add(curr);
                last = curr;
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