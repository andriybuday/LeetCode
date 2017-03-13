public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if(g == null || s == null || s.Length == 0) {
            return 0;
        }
        Array.Sort(g);
        Array.Sort(s);
        var counter = 0;
        var j = 0;
        for(int i = 0; i < g.Length; ++i) {
            while(j < s.Length && g[i] > s[j]) {
                j++;
            }
            if (j < s.Length && g[i] <= s[j]) {
                j++;
                counter++;
            }
        }
        return counter;
    }
}