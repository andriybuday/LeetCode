public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var h = new HashSet<int>();
        foreach(var n in nums)
            if(h.Contains(n))
                return true;
            else
                h.Add(n);
        return false;
    }
}