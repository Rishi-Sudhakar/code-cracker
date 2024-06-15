def binary_search(arr, target):
    left, right = 0, len(arr) - 1
    while left <= right:
        mid = (left + right) // 2
        if arr[mid] == target:
            return mid
        elif arr[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return -1

if __name__ == "__main__":
    arr = list(map(int, input("Enter sorted array elements separated by space: ").split()))
    target = int(input("Enter the target value: "))
    result = binary_search(arr, target)
    print(f"Index of {target}: {result}")
