public class Solution {
    public bool IsAnagram(string s, string t) {
        var a = new int[256];
        foreach(var c in s)a[c-0]++;
        foreach(var c in t)a[c-0]--;
        foreach(var v in a)
            if(v != 0) return false;
        return true;
    }
}