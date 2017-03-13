public class Solution {
    public int RomanToInt(string s) {
        var twoLetters = new Dictionary<string, int>
        {
            {"CM", 900},
            {"CD", 400},
            {"XC", 90},
            {"XL", 40},
            {"IX", 9},
            {"IV", 4},
        };
        var oneLetters = new Dictionary<string, int>
        {
            {"M", 1000},
            {"D", 500},
            {"C", 100},
            {"L", 50},
            {"X", 10},
            {"V", 5},
            {"I", 1}
        };
        var result = 0;
        foreach(var tl in twoLetters) {
            var lenBefore = s.Length;
            s = s.Replace(tl.Key, "");
            var lenAfter = s.Length;
            var count = (lenBefore - lenAfter) / 2;
            result += count * tl.Value;
        }
        foreach(var ol in oneLetters) {
            var lenBefore = s.Length;
            s = s.Replace(ol.Key, "");
            var lenAfter = s.Length;
            var count = (lenBefore - lenAfter);
            result += count * ol.Value;
        }
        return result;
    }
}