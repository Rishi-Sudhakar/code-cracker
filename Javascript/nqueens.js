function solveNQueens(n) {
    let solutions = [];
    let cols = new Set(), diagonals1 = new Set(), diagonals2 = new Set();
    backtrack(0);
    return solutions;

    function backtrack(row, current = []) {
        if (row === n) {
            solutions.push(current.map(c => '.'.repeat(c) + 'Q' + '.'.repeat(n - c - 1)));
            return;
        }
        for (let col = 0; col < n; col++) {
            if (cols.has(col) || diagonals1.has(row + col) || diagonals2.has(row - col)) continue;
            cols.add(col);
            diagonals1.add(row + col);
            diagonals2.add(row - col);
            backtrack(row + 1, [...current, col]);
            cols.delete(col);
            diagonals1.delete(row + col);
            diagonals2.delete(row - col);
        }
    }
}

let n = 4;
let solutions = solveNQueens(n);
console.log(`Solutions for ${n}-Queens problem:`, solutions);
