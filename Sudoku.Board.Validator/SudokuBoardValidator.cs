namespace Sudoku.Board.Validator
{
    public class SudokuBoardValidator
    {
        public bool IsValidSudoku(char[,] board)
        {
            var result = true;
            for (var i = 0; i < 9; ++i)
            {
                if (!IsValidRowAndColumn(board, i))
                {
                    result = false;
                    break;
                }
                if (i % 3 == 0)
                {
                    if (!IsSubMatrixElementsUnique(board, i))
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private bool IsValidRowAndColumn(char[,] board, int index)
        {

            var rowBoolArray = new bool[9];
            var colBoolArray = new bool[9];
            for (var i = 0; i < 9; ++i)
            {
                if (!SetUniqueValue(board[i, index], ref rowBoolArray) ||
                    !SetUniqueValue(board[index, i], ref colBoolArray)) return false;
            }

            return true;
        }

        private bool SetUniqueValue(char curChar, ref bool[] boolArray)
        {
            if (curChar == '.')
                return true;
            var num = int.Parse(curChar.ToString()) - 1;
            if (boolArray[num])
            {
                return false;
            }
            boolArray[num] = true;
            return true;
        }

        private bool IsSubMatrixElementsUnique(char[,] board, int index)
        {
            var bool0Array = new bool[9];
            var bool3Array = new bool[9];
            var bool6Array = new bool[9];

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    //0,3,6 are the fixed sub matrix columns
                    if (!SetUniqueValue(board[index + i, j + 0], ref bool0Array) ||
                        !SetUniqueValue(board[index + i, j + 3], ref bool3Array) ||
                        !SetUniqueValue(board[index + i, j + 6], ref bool6Array)) return false;
                }

            }
            return true;
        }
    }
}