public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var a = new int[26];
        foreach(var c in magazine) {
            a[c-'a']++;
        }
        foreach(var c in ransomNote) {
            var i = c - 'a';
            a[i]--;
            if(a[i] < 0) {
                return false;
            }
        }
        return true;
    }
}