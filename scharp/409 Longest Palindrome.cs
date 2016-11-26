public class Solution {
    public int LongestPalindrome(string s) {
        var a = new bool[256];
        var len = 0;
        foreach(var c in s){
            var i = c - 0;
            if(a[i]) {
                a[i] = false;
                len += 2;
            } else {
                a[i] = true;
            }
        }
        var anyLeft = false;
        foreach(var x in a)
            anyLeft = x || anyLeft;
        
        return anyLeft ? len + 1 : len;
    }
}