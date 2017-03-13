public class Solution {
    public int IslandPerimeter(int[,] grid) {
        var n = grid.GetLength(0);
        var m = grid.GetLength(1);
        int counter = 0;
        for(int i = 0; i < n; ++i) {
            for(int j = 0; j < m; ++j) {
                if(grid[i, j] == 1) {
                    //up
                    if (i == 0 || grid[i-1, j] == 0) counter++;
                    //down
                    if (i == n-1 || grid[i+1, j] == 0) counter++;
                    //left
                    if (j == 0 || grid[i, j-1] == 0) counter++;
                    //right
                    if (j == m-1 || grid[i, j+1] == 0) counter++;
                }
            }
        }
        return counter;
    }
}