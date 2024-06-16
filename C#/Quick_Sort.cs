using System;

class QuickSort
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }

        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }

    static void QuickSortFunc(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSortFunc(arr, low, pi - 1);
            QuickSortFunc(arr, pi + 1, high);
        }
    }

    public static void Main()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        Console.Write("Enter array elements: ");
        for (int i = 0; i < n; ++i)
            arr[i] = Convert.ToInt32(Console.ReadLine());

        QuickSortFunc(arr, 0, n - 1);

        Console.Write("Sorted array: ");
        foreach (var num in arr)
            Console.Write($"{num} ");
        Console.WriteLine();
    }
}
