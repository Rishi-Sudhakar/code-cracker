using System;

class LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (s == null || s.Length < 1) return "";
        
        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandAroundCenter(s, i, i);
            int len2 = ExpandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        
        return s.Substring(start, end - start + 1);
    }
    
    private int ExpandAroundCenter(string s, int left, int right)
    {
        int L = left, R = right;
        while (L >= 0 && R < s.Length && s[L] == s[R])
        {
            L--;
            R++;
        }
        return R - L - 1;
    }

    public static void Main()
    {
        LongestPalindromicSubstring lps = new LongestPalindromicSubstring();
        string s = "babad";
        Console.WriteLine("Longest palindromic substring of " + s + ": " + lps.LongestPalindrome(s));
    }
}
