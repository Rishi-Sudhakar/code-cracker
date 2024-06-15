using System;

public class BinarySearchExample {
    public static int BinarySearch(int[] arr, int target) {
        int left = 0, right = arr.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    public static void Main() {
        Console.WriteLine("Enter sorted array elements separated by space: ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.WriteLine("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());
        
        int result = BinarySearch(arr, target);
        Console.WriteLine($"Index of {target}: {result}");
    }
}
