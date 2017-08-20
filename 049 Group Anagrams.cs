public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var d = new Dictionary<string, IList<string>>();
        var sS = new string[strs.Length];
        for(var i = 0; i < strs.Length; ++i) {
            var s = strs[i].ToCharArray();
            Array.Sort(s);
            var str = new string(s);
            sS[i] = str;
            d[str] = new List<string>();
        }
        for(var i = 0; i < strs.Length; ++i) {
            d[sS[i]].Add(strs[i]);
        }
        return d.Values.ToList();
    }
}