class Solution {
public:
    bool isPalindrome(int x) {
        if(x < 0) return false;
        int y = x;
        int z = 0;
        while(x) {
            z *= 10;
            z += (x % 10);
            x /= 10;
        }
        return z == y;
    }
};