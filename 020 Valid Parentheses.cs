public class Solution {
    public bool IsValid(string s) {
        var closing = new HashSet<char>(){')', ']', '}'};
        var opening = new Dictionary<char, char>();
        opening.Add(')', '(');
        opening.Add(']', '[');
        opening.Add('}', '{');
        var stack = new Stack<char>();
        foreach(char c in s) {
            if(closing.Contains(c)) {
                if(stack.Count() == 0)return false;
                var c1 = stack.Pop();
                if(c1 != opening[c]) return false;
            } else {
                stack.Push(c);
            }
        }
        return stack.Count() == 0;
    }
}