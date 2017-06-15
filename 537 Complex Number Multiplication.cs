public class Solution {
    public class Complex {
        public int a;
        public int b;
        public static Complex Parse(string s) {
            var complex = s.Replace("i", "").Split('+');
            return new Complex {a = int.Parse(complex[0]), b = int.Parse(complex[1])};
        }
    }
    public string ComplexNumberMultiply(string a, string b) {
        var x = Complex.Parse(a);
        var y = Complex.Parse(b);
        var za = x.a * y.a - x.b * y.b;
        var zb = x.a * y.b + x.b * y.a;
        return $"{za}+{zb}i";
    }
}