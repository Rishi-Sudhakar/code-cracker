function knapsack(capacity, weights, values, n) {
    let dp = new Array(n + 1).fill().map(() => new Array(capacity + 1).fill(0));

    for (let i = 1; i <= n; i++) {
        for (let w = 1; w <= capacity; w++) {
            if (weights[i - 1] <= w) {
                dp[i][w] = Math.max(values[i - 1] + dp[i - 1][w - weights[i - 1]], dp[i - 1][w]);
            } else {
                dp[i][w] = dp[i - 1][w];
            }
        }
    }

    return dp[n][capacity];
}

let values = [60, 100, 120];
let weights = [10, 20, 30];
let capacity = 50;
let n = values.length;

console.log(`Maximum value in knapsack: ${knapsack(capacity, weights, values, n)}`);
