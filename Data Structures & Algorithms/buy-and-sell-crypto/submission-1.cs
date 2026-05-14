public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for(int i = 1; i < prices.Length; i++){
            int tmpProfit = prices[i] - prices.Take(i).Min();
            if(tmpProfit > maxProfit){
                maxProfit = tmpProfit;
            }
        }
        return maxProfit;

    }
}
