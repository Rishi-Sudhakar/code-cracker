using System;

class MergeSort
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void MergeSortFunc(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSortFunc(arr, left, mid);
            MergeSortFunc(arr, mid + 1, right);

            Merge(arr, left, mid, right);
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

        MergeSortFunc(arr, 0, n - 1);

        Console.Write("Sorted array: ");
        foreach (var num in arr)
            Console.Write($"{num} ");
        Console.WriteLine();
    }
}
