public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        for(int j = n-1; j >= 0; --j) {
            for(int i = 0; i < n; ++i) {
                if(numbers[i] + numbers[j] == target)
                    return new int[] {i + 1, j + 1};
                if(numbers[i] + numbers[j] > target)
                    break;
            }
        }
        return null;
    }
}