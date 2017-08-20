public class Solution {
    public int ThirdMax(int[] nums) {
        var a = new HashSet<int>(nums).ToArray();
        Array.Sort(a);
        var k = (a.Length < 3) ? a.Length-1 : a.Length-3;
        return a[k];
    }
}