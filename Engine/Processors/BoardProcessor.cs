using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Processors
{
    public class BoardProcessor
    {
        public const int ROW_COUNT = 3;
        public const int COL_COUNT = 3;

        private int[][] board;

        public BoardProcessor()
        {
            board = GetBoard();
        }

        public void AddCell(int row, int col, BoardCellType cellType)
        {
            board[row][col] = (int)cellType;
        }

        public bool CheckRow(int row)
        {
            int firstCell = this.board[row][0];

            for (int col = 1; col < COL_COUNT; col++)
            {
                if(firstCell != this.board[row][col])
                {
                    return false;
                }
            }

            return firstCell != (int)BoardCellType.Empty;
        }

        public bool CheckCol(int col)
        {
            int firstCell = this.board[0][col];

            for (int row = 1; row < ROW_COUNT; row++)
            {
                if (firstCell != this.board[row][col])
                {
                    return false;
                }
            }

            return firstCell != (int)BoardCellType.Empty;
        }

        public bool CheckFirstDiagonal()
        {
            int firstCell = this.board[0][0];
            for (int i = 1; i < ROW_COUNT; i++)
            {
                if(firstCell != this.board[i][i])
                {
                    return false;
                }
            }

            return firstCell != (int)BoardCellType.Empty;
        }

        public bool CheckSecondDiagonal()
        {
            int row = 2;
            int col = 0;

            int firstCell = this.board[row][col];

            for (int i = 1; i < ROW_COUNT; i++)
            {
                if(firstCell != this.board[--row][++col])
                {
                    return false;
                }
            }

            return firstCell != (int)BoardCellType.Empty;
        }

        public bool IsDraw()
        {
            for (int row = 0; row < ROW_COUNT; row++)
            {
                for (int col = 0; col < COL_COUNT; col++)
                {
                    if(this.board[row][col] == (int)BoardCellType.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Reset()
        {
            board = GetBoard();
        }
        private int[][] GetBoard()
        {
            int[][] result = new int[ROW_COUNT][];
            for (int i = 0; i < ROW_COUNT; i++)
            {
                result[i] = new int[COL_COUNT];
            }

            return result;
        }
    }
}
