public class Solution {
    public int AddDigits(int num) {
        if(num <= 0) return num;
        var r = num - (num / 9) * 9;
        return r == 0 ? 9 : r;
    }
}