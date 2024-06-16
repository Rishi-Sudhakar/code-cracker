#include <iostream>
#include <vector>

class LongestPalindromicSubstring {
public:
    std::string longestPalindrome(std::string s) {
        if (s.empty()) return "";
        
        int n = s.size();
        int start = 0, maxLength = 1;
        std::vector<std::vector<bool>> dp(n, std::vector<bool>(n, false));

        for (int i = 0; i < n; ++i)
            dp[i][i] = true;

        for (int i = 0; i < n - 1; ++i) {
            if (s[i] == s[i + 1]) {
                dp[i][i + 1] = true;
                start = i;
                maxLength = 2;
            }
        }

        for (int len = 3; len <= n; ++len) {
            for (int i = 0; i < n - len + 1; ++i) {
                int j = i + len - 1;
                if (s[i] == s[j] && dp[i + 1][j - 1]) {
                    dp[i][j] = true;
                    start = i;
                    maxLength = len;
                }
            }
        }

        return s.substr(start, maxLength);
    }
};

int main() {
    LongestPalindromicSubstring lps;
    std::string s = "babad";
    std::cout << "Longest palindromic substring of " << s << ": " << lps.longestPalindrome(s) << "\n";

    return 0;
}
