#include <iostream>
#include <vector>

class NQueens {
public:
    const int N = 4;

    bool isSafe(std::vector<std::vector<int>>& board, int row, int col) {
        int i, j;

        for (i = 0; i < col; ++i)
            if (board[row][i])
                return false;

        for (i = row, j = col; i >= 0 && j >= 0; --i, --j)
            if (board[i][j])
                return false;

        for (i = row, j = col; j >= 0 && i < N; ++i, --j)
            if (board[i][j])
                return false;

        return true;
    }

    bool solveNQueensUtil(std::vector<std::vector<int>>& board, int col) {
        if (col >= N)
            return true;

        for (int i = 0; i < N; ++i) {
            if (isSafe(board, i, col)) {
                board[i][col] = 1;

                if (solveNQueensUtil(board, col + 1))
                    return true;

                board[i][col] = 0;
            }
        }

        return false;
    }

    void solveNQueens() {
        std::vector<std::vector<int>> board(N, std::vector<int>(N, 0));

        if (!solveNQueensUtil(board, 0)) {
            std::cout << "Solution does not exist\n";
            return;
        }

        std::cout << "Solution for " << N << "-Queens problem:\n";
        for (int i = 0; i < N; ++i) {
            for (int j = 0; j < N; ++j)
                std::cout << board[i][j] << " ";
            std::cout << "\n";
        }
    }
};

int main() {
    NQueens nq;
    nq.solveNQueens();

    return 0;
}
