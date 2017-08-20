public class Solution {
    public int StrStr(string h, string n) {
        for(var i = 0; i <= h.Length - n.Length; ++i) {
            var allMatch = true;
            for(var j = 0; j < n.Length; ++j) {
                if(h[i+j] != n[j]) {
                    allMatch = false;
                    break;
                }
            }
            if(allMatch) {
                return i;
            }
        }
        
        return -1;
    }
}