public class Solution {
    public int[] CountBits(int num) {
        var r = new int[num + 1];
        var pow2 = 1;
        var j = 0;
        for(int i = 1; i <= num; ++i) {
            if(i == pow2) {
                pow2 *= 2;
                j = 0;
            }
            r[i] = r[j] + 1;
            j++;
        }
        
        return r;
    }
}