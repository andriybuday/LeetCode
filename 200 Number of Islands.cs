public class Solution {
    public int NumIslands(char[,] grid) {
        var counter = 0;
        var n = grid.GetLength(0);
        var m = grid.GetLength(1);
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < m; ++j) {
                if(grid[i,j] == '1') {
                    counter++;
                    MakeAllConnectedZero(grid, i, j);
                }
            }
        }
        return counter;
    }
    private void MakeAllConnectedZero(char[,] grid, int i, int j) {
        var n = grid.GetLength(0);
        var m = grid.GetLength(1);
        if(i < 0 || j < 0 || i >= n || j >= m) {
            return;
        }
        if(grid[i,j] == '1') {
            grid[i,j] = '0';
            MakeAllConnectedZero(grid, i + 1, j);
            MakeAllConnectedZero(grid, i - 1, j);
            MakeAllConnectedZero(grid, i, j + 1);
            MakeAllConnectedZero(grid, i, j - 1);
        }
    }
}