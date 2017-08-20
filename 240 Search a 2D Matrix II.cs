public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        var n = matrix.GetLength(0);
        var m = matrix.GetLength(1);
        if(n == 0 || m == 0) return false;
        var i = 0;
        var j = m-1;
        while(i < n && j >= 0) {
            if(matrix[i,j]==target)return true;
            else if(matrix[i,j] > target)j--;
            else if(matrix[i,j] < target)i++;
        }
        
        return false;
    }
}