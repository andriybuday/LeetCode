public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var a = new int[rowIndex + 1];
        a[0] = 1;
        for(int k = 1; k <= rowIndex; ++k) {
            var prev = 1;
            for(int i = 1; i < k+1; ++i) {
                var tmp = a[i];
                a[i] = a[i] + prev;
                prev = tmp;
            }
        }
        
        return a.ToList();
    }
}