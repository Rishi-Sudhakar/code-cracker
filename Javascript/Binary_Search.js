function binarySearch(arr, target) {
    let left = 0;
    let right = arr.length - 1;
    while (left <= right) {
        const mid = Math.floor((left + right) / 2);
        if (arr[mid] === target) {
            return mid;
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }
    return -1;
}

const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.question('Enter sorted array elements separated by space: ', (arrInput) => {
    const arr = arrInput.split(' ').map(Number);
    readline.question('Enter the target value: ', (targetInput) => {
        const target = Number(targetInput);
        const result = binarySearch(arr, target);
        console.log(`Index of ${target}: ${result}`);
        readline.close();
    });
});
