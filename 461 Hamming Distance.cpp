class Solution {
public:
    int hammingDistance(int x, int y) {
        int z = x ^ y;
        int c = 0;
        while(z) {
            c += z%2;
            z /= 2;
        }
        return c;
    }
};