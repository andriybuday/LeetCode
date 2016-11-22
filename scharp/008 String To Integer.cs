public class Solution {
    public int MyAtoi(string s) {
        if(s == null || s == "") {
            return 0;
        }
        var n = s.Length;
        var res = 0;
        var INT_MAX10 = 214748364;
        var INT_MAX = 2147483647;
        var INT_MIN = -2147483648;
        var pos = true;
        
        var i = 0;
        // skip trailing spaces
        while(i < n && s[i] == ' ') {
            ++i;
        }
        // check if first char is minus
        if(i < n && s[i] == '-') {
            pos = false;
            ++i;
        } else if(i < n && s[i] == '+') {
            ++i;
        }
        // do the calc
        while(i < n && Char.IsDigit(s[i])) {
            var next = s[i]-'0';
            if(res > INT_MAX10) {
                return pos ? INT_MAX : INT_MIN;
            }
            if(res == INT_MAX10) {
                if(pos && next >= 7) return INT_MAX;
                if(!pos && next >= 8) return INT_MIN;
            }
            res *= 10;
            res += next;
            ++i;
        }
        
        return pos ? res : -res;
    }
}