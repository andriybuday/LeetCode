public class Solution {
    public void SetZeroes(int[,] matrix) {
        var n = matrix.GetLength(0);
        var m = matrix.GetLength(1);
        var zN = new bool[n];
        var zM = new bool[m];
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < m; ++j) {
                if(matrix[i,j] == 0) {
                    zN[i] = true;
                    zM[j] = true;
                }
            }
        }
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < m; ++j) {
                if(zN[i] || zM[j]) {
                    matrix[i,j] = 0;
                }
            }
        }
    }
}