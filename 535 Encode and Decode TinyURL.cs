public class Codec {
    private static string baseUrl = "http://tinyurl.com/";
    private Dictionary<string, string> keyValues = new Dictionary<string, string>(); 

    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        var key = longUrl.Length.ToString() + longUrl.GetHashCode().ToString();
        keyValues.Add(key, longUrl);
        return baseUrl + key;
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        var key = shortUrl.Split('/').Last();
        var result = "";
        keyValues.TryGetValue(key, out result);
        return result;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));