function mergeSort(arr) {
    if (arr.length <= 1) {
        return arr;
    }

    const mid = Math.floor(arr.length / 2);
    const left = mergeSort(arr.slice(0, mid));
    const right = mergeSort(arr.slice(mid));

    return merge(left, right);
}

function merge(left, right) {
    let result = [];
    let i = 0, j = 0;

    while (i < left.length && j < right.length) {
        if (left[i] < right[j]) {
            result.push(left[i++]);
        } else {
            result.push(right[j++]);
        }
    }

    while (i < left.length) {
        result.push(left[i++]);
    }

    while (j < right.length) {
        result.push(right[j++]);
    }

    return result;
}

let arr = [12, 11, 13, 5, 6, 7];
let sortedArr = mergeSort(arr);
console.log(`Sorted array: ${sortedArr}`);
