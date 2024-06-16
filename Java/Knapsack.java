import java.util.Scanner;

public class Knapsack {
    public static int knapsack(int[] weights, int[] values, int capacity) {
        int n = weights.length;
        int[][] dp = new int[n + 1][capacity + 1];

        for (int i = 1; i <= n; i++) {
            for (int w = 1; w <= capacity; w++) {
                if (weights[i - 1] <= w) {
                    dp[i][w] = Math.max(dp[i - 1][w], dp[i - 1][w - weights[i - 1]] + values[i - 1]);
                } else {
                    dp[i][w] = dp[i - 1][w];
                }
            }
        }
        return dp[n][capacity];
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter weights separated by space: ");
        String[] weightInput = scanner.nextLine().split(" ");
        int[] weights = new int[weightInput.length];
        for (int i = 0; i < weightInput.length; i++) {
            weights[i] = Integer.parseInt(weightInput[i]);
        }

        System.out.println("Enter values separated by space: ");
        String[] valueInput = scanner.nextLine().split(" ");
        int[] values = new int[valueInput.length];
        for (int i = 0; i < valueInput.length; i++) {
            values[i] = Integer.parseInt(valueInput[i]);
        }

        System.out.print("Enter the capacity of the knapsack: ");
        int capacity = scanner.nextInt();

        System.out.println("Maximum value in knapsack: " + knapsack(weights, values, capacity));
    }
}
