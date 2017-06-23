public class Solution {
    public int TrailingZeroes(int n) {
        if(n == 0) return 0;
        return n / 5 + TrailingZeroes(n / 5);
    }
}