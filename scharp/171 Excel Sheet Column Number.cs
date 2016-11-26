public class Solution {
    public int TitleToNumber(string s) {
        var sum = 0;
        var m = 0;
        for(int i = s.Length - 1; i >= 0; --i) {
            sum += (s[i] - 'A' + 1) * (int)Math.Pow(26, m);
            m++;
        }
        return sum;
    }
}