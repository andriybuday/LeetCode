public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var n = s.Length;
        var h = new HashSet<string>(wordDict);
        
        var a = new bool[n + 1];
        a[0] = true;
        
        for(int i = 1; i <= n; ++i) {
            for(int start = i - 1; start >= 0; --start) {
                if(a[start]) {
                    var sub = s.Substring(start, i - start);
                    if(h.Contains(sub)) {
                        a[i] = true;
                    }    
                }
            }
        }
        
        return a[n];
    }
}