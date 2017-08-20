public class Solution {
    public IList<string> LetterCombinations(string digits) {
        if(string.IsNullOrEmpty(digits)){
            return new List<string>();
        }
        var d = new Dictionary<char, List<char>>();
        d.Add('0', new List<char>{});
        d.Add('1', new List<char>{});
        d.Add('2', new List<char>{'a', 'b', 'c'});
        d.Add('3', new List<char>{'d', 'e', 'f'});
        d.Add('4', new List<char>{'g', 'h', 'i'});
        d.Add('5', new List<char>{'j', 'k', 'l'});
        d.Add('6', new List<char>{'m', 'n', 'o'});
        d.Add('7', new List<char>{'p', 'q', 'r', 's'});
        d.Add('8', new List<char>{'t', 'u', 'v'});
        d.Add('9', new List<char>{'w', 'x', 'y', 'z'});
        var result = new List<string>() {""};
        for(int i = 0; i < digits.Length; ++i) {
            result = GetCombinations(result, d[digits[i]]);
        }
        return result;
    }
    
    private List<string> GetCombinations(List<string> x, List<char> letters) {
        var result = new List<string>();
        
        for(int j = 0; j < letters.Count; ++j) {
            for(int i = 0; i < x.Count; ++i) {
                result.Add(x[i] + letters[j]);
            }
        }

        return result;
    }
}