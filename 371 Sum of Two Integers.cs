public class Solution {
    public int GetSum(int a, int b) {
        var sum = a;
        var carry = b;
        while(carry != 0) {
            var tmpSum = sum;
            sum ^= carry;
            carry = (tmpSum & carry) << 1;
        }
        return sum;
    }
}