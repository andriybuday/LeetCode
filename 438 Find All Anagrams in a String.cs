public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        if(s.Length < p.Length) {
            return new List<int>();
        }
        var result = new List<int>();
        var a = new int[256];
        for(var i = 0; i < p.Length; ++i){
            a[p[i] - 0]++;
            a[s[i] - 0]--;
        }
        if(IsOk(a)) {
            result.Add(0);
        }   
        var start = 0;
        var end = p.Length-1;
        while(end < s.Length - 1) {
            a[s[start] - 0]++;
            a[s[end + 1] - 0]--;
            if(IsOk(a)) {
                result.Add(start+1);
            }   
            start++;
            end++;
        }
        return result;
    }
    private bool IsOk(int[] a){
        foreach(var x in a)
            if(x != 0)
                return false;
        return true;
    }
}