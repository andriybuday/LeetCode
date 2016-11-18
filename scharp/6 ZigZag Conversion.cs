public class Solution {
    public string Convert(string s, int numRows) {
        var n = numRows;
        if(n == 1) return s;
        var skip = 2 * n - 2;
        var sb = new StringBuilder();
        for (int i = 0; i < n; ++i) {
            for(int j = 0; j <= s.Length + skip; j += skip) {
                var l = j - i;
                var r = j + i;
                if(l < s.Length && l >= 0) {
                    sb.Append(s[l]);
                }
                if (i != 0 && i != n - 1 && r < s.Length) {
                    sb.Append(s[r]);
                }
            }
        }
        return sb.ToString();
    }
}