function longestPalindrome(s) {
    if (s === null || s.length < 1) return '';

    let start = 0, end = 0;
    for (let i = 0; i < s.length; i++) {
        let len1 = expandAroundCenter(s, i, i);
        let len2 = expandAroundCenter(s, i, i + 1);
        let len = Math.max(len1, len2);
        if (len > end - start) {
            start = i - Math.floor((len - 1) / 2);
            end = i + Math.floor(len / 2);
        }
    }
    return s.substring(start, end + 1);
}

function expandAroundCenter(s, left, right) {
    let L = left, R = right;
    while (L >= 0 && R < s.length && s.charAt(L) === s.charAt(R)) {
        L--;
        R++;
    }
    return R - L - 1;
}

let s = 'babad';
console.log(`Longest palindromic substring of ${s}: ${longestPalindrome(s)}`);
