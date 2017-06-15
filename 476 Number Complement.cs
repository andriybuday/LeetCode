public class Solution {
    public int FindComplement(int num) {
        var n = (Int64)num;
        var pivot = (Int64)(Math.Pow(2, 32));
        while ((pivot & n) == 0)
        {
            pivot = pivot >> 1;
        }
        Int64 res = 0;
        while (pivot > 0)
        {
            res = res | (pivot ^ (pivot & n));
            pivot = pivot >> 1;
        }
        return (int)res;
    }
}