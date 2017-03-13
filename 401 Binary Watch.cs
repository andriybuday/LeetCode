public class Solution {
    public IList<string> ReadBinaryWatch(int num) {
        var bitCache = new int[60];
        for(var i = 0; i < 60; ++i) {
            var n = i;
            var count = 0;
            while(n > 0) {
                if((n & 1) == 1) count++;
                n >>= 1;
            }
            bitCache[i] = count;
        }

        var result = new List<string>();
        for(var i = 0; i <= 11; ++i)
            for(var j = 0; j <= 59; ++j)
                if(bitCache[i] + bitCache[j] == num)
                    result.Add(string.Format("{0}:{1:D2}", i, j));
        return result;
    }
}
