public class Solution {
    public int MaxRotateFunction(int[] A) {
        if(A.Length == 0) return 0;
        var n = A.Length;
        var F = 0;
        var sum = 0;
        for(var i = 0; i < n; ++i) {
            F += i * A[i];
            sum += A[i];
        }
        var max = F;
        for(var i = n-1; i >= 0; --i) {
            F = F + sum - n * A[i];
            if(F > max) {
                max = F;
            }
        }
        return max;
    }
}