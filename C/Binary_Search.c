#include <stdio.h>
#include <stdlib.h>

int binary_search(int arr[], int size, int target) {
    int left = 0, right = size - 1;
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

int main() {
    int size;
    printf("Enter number of elements in array: ");
    scanf("%d", &size);
    
    int* arr = (int*) malloc(size * sizeof(int));
    printf("Enter sorted array elements: ");
    for (int i = 0; i < size; i++) {
        scanf("%d", &arr[i]);
    }
    
    int target;
    printf("Enter the target value: ");
    scanf("%d", &target);
    
    int result = binary_search(arr, size, target);
    printf("Index of %d: %d\n", target, result);
    
    free(arr);
    return 0;
}
