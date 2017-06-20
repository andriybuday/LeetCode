public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;
        var min = prices[0];
        var win = 0;
        for(var i = 1; i < prices.Length; ++i) {
            var d = prices[i] - min;
            if(d > win) {
                win = d;
            }
            if(prices[i] < min) {
                min = prices[i];
            }
        }
        return win;
    }
}	