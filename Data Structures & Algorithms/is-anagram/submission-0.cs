public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length != t.Length) return false;
    
    Dictionary<char, int> freq = new Dictionary<char, int>();
    
    foreach (char c in s)
    {
        freq[c] = freq.GetValueOrDefault(c, 0) + 1;
    }
    
    foreach (char c in t)
    {
        freq[c] = freq.GetValueOrDefault(c, 0) - 1;
    }
    
    return freq.Values.All(count => count == 0);



    }
}
