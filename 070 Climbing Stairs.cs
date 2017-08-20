public class Solution {
    public int ClimbStairs(int n) {
        var prevPrev = 0;
        var prev = 1;
        for(int i = 1; i <= n; ++i) {
            var x = prev;
            prev = prev + prevPrev;
            prevPrev = x;
        }
        return prev;
    }
}