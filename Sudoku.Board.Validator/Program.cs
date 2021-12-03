using System;

namespace Sudoku.Board.Validator
{
    class Program
    {
        static void Main(string[] args)
        {

            var testObj = new SudokuBoardValidator();

            var sudoku = new char[,]
            {
                { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };
            Console.WriteLine("The given Sudoko board is {0}.", ToValidationString(testObj.IsValidSudoku(sudoku)));
            Console.ReadKey();
        }

        private static string ToValidationString(bool isValidSudoku)
        {
            return isValidSudoku ? "valid" : "invalid";
        }
    }
}
