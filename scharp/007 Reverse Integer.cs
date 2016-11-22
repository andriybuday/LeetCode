public class Solution {
    public int Reverse(int x) {
        var ans = 0;
        var pos = x > 0;
        x = pos ? x : -x;
        while(x > 0) {
            var r = x % 10;
            x /= 10;
            // handle overflow situation
            if ((Int32.MaxValue - r) / 10 < ans) return 0;
            ans = ans * 10 + r;
        }
        return pos ? ans : -ans;
    }
}