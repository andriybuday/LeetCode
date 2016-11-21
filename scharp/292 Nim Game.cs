public class Solution {
    public bool CanWinNim(int n) {
        // win:
        // 1-3
        // 5-7
        // ...
        return n % 4 != 0;
    }
}