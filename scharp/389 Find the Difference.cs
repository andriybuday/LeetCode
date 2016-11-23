public class Solution {
    public char FindTheDifference(string s, string t) {
        var a = new int[26];
        foreach(var tc in t)
            a[tc - 'a']++;
        foreach(var sc in s)
            a[sc - 'a']--;
        for(int i = 0; i < 26; ++i)
            if(a[i] > 0)
                return (char)('a' + i);
        return 'a';
    }
}