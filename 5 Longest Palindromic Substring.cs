public class Solution {
    public string LongestPalindrome(string s) {
        var n = s.Length;
        if(n < 2) return s;
        var maxLen = 0;
        var maxStart = 0;
        for(int i = 0; i < n; ++i) {
            var ind1 = i-maxLen;
            var ind2 = i-maxLen-1;
             if(ind2 >= 0 && IsPalindrome(s, ind2, i)) {
                maxStart = ind2;
                maxLen += 2;
            }
            else if(ind1 >= 0 && IsPalindrome(s, ind1, i)) {
                maxStart = ind1;
                maxLen += 1;
            }
        }
        return s.Substring(maxStart, maxLen);
    }
    private bool IsPalindrome(string s, int i, int j) {
        while(i < j && s[i] == s[j]) {
            i++;
            j--;
        }
        return (i >= j);
    }
}