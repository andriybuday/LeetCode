public class Solution {
    public int MinMoves(int[] nums) {
        var a = nums;
        if(a == null || a.Length == 0 || a.Length == 1)
            return 0;
        Array.Sort(a);
        var max = a[a.Length-1];
        var sameCount = 1;
        var min = a[0];
        var lastMax = max;
        var sum = 0;
        for(int i = a.Length - 2; i >= 0; --i) {
            if(lastMax == a[i]) {
                sameCount++;
            } else {
                sum += sameCount * (lastMax - min);
                lastMax = a[i];
                sameCount = 1;
            }
        }
        return sum;
    }
}