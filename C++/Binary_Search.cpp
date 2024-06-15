#include <iostream>
#include <vector>
#include <sstream>

int binary_search(const std::vector<int>& arr, int target) {
    int left = 0, right = arr.size() - 1;
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
    std::cout << "Enter sorted array elements separated by space: ";
    std::string input;
    std::getline(std::cin, input);
    std::istringstream stream(input);
    std::vector<int> arr((std::istream_iterator<int>(stream)), std::istream_iterator<int>());
    
    std::cout << "Enter the target value: ";
    int target;
    std::cin >> target;
    
    int result = binary_search(arr, target);
    std::cout << "Index of " << target << ": " << result << std::endl;
    return 0;
}
