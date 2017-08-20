public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0) return 0;
        var dp = new int[amount+1];
        var m = coins.Length;
        
        for(int i = 1; i <= amount; ++i) {
            var min = Int32.MaxValue;
            for(int j = 0; j < m; ++j) {
                var ind = i - coins[j];
                if(ind > 0 && dp[ind] < min && dp[ind] != 0) {
                    min = dp[ind];
                } else if(ind == 0 && dp[ind] < min) {
                    min = dp[ind];
                }
            }
            if(min < Int32.MaxValue) {
                dp[i] = 1 + min;
            }
        }
        
        return (dp[amount] > 0) ? dp[amount] : -1;
    }
}