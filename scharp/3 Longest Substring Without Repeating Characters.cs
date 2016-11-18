public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var used = new bool[256];
        var len = 0;
        var j = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            while (j < s.Length && !used[s[j]])
            {
                used[s[j]] = true;
                j++;
            }
            len = Math.Max(len, j - i);
            used[s[i]] = false;
        }

        return len;
    }
}