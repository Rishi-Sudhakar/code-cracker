using System;

class NQueens
{
    private const int N = 4;

    bool IsSafe(int[,] board, int row, int col)
    {
        int i, j;

        for (i = 0; i < col; i++)
            if (board[row, i] == 1)
                return false;

        for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            if (board[i, j] == 1)
                return false;

        for (i = row, j = col; j >= 0 && i < N; i++, j--)
            if (board[i, j] == 1)
                return false;

        return true;
    }

    bool SolveNQueensUtil(int[,] board, int col)
    {
        if (col >= N)
            return true;

        for (int i = 0; i < N; i++)
        {
            if (IsSafe(board, i, col))
            {
                board[i, col] = 1;

                if (SolveNQueensUtil(board, col + 1))
                    return true;

                board[i, col] = 0;
            }
        }

        return false;
    }

    bool SolveNQueens()
    {
        int[,] board = { {0, 0, 0, 0},
                         {0, 0, 0, 0},
                         {0, 0, 0, 0},
                         {0, 0, 0, 0} };

        if (SolveNQueensUtil(board, 0) == false)
        {
            Console.WriteLine("Solution does not exist");
            return false;
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(" " + board[i, j] + " ");
            Console.WriteLine();
        }

        return true;
    }

    public static void Main()
    {
        NQueens nq = new NQueens();
        nq.SolveNQueens();
    }
}
