public class Solution {
    public string ReverseString(string s) {
        var sb = new StringBuilder();
        for(int i = s.Length - 1; i >= 0; --i)
            sb.Append(s[i]);
        return sb.ToString();
    }
}