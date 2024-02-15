using Engine.Contracts;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Processors
{
    public class DisplayProcessor
    {
        private const string PLAYER_ONE_NAME = "G060";
        private const string PLAYER_ONE_FILL_TYPE = "X";
        private const string PLAYER_TWO_NAME = "P360";
        private const string PLAYER_TWO_FILL_TYPE = "O";
        private const int GAME_OVER = 1;
        private const int GAME_NOT_OVER = -1;
        private const int GAME_DRAW = 0;
        private BoardProcessor boardProcessor;
        private ICell[] cells;
        private Player playerOne;
        private Player playerTwo;

        private bool isPlayerOneTurn;

        public DisplayProcessor(ICell[] cells)
        {
            this.cells = cells;
            boardProcessor = new BoardProcessor();
            this.playerOne = new Player(PLAYER_ONE_NAME, PLAYER_ONE_FILL_TYPE);
            this.playerTwo = new Player(PLAYER_TWO_NAME, PLAYER_TWO_FILL_TYPE);

            this.isPlayerOneTurn = true;
        }

        public bool MakeTurn(ICell cell, out string winner)
        {
            BoardCellType boardCellType = BoardCellType.PlayerOne;
            string fillType = playerOne.FillType;
            if (!isPlayerOneTurn)
            {
                boardCellType = BoardCellType.PlayerTwo;
                fillType = playerTwo.FillType;
            }
            boardProcessor.AddCell(cell.Row, cell.Col, boardCellType);
            cell.AddText(fillType);
            
            int result = IsGameOver();
            if (result == GAME_OVER)
            {
                winner = GetCurentPlayerName();
            }
            else
            {
                winner = null;
            }

            isPlayerOneTurn = !isPlayerOneTurn;
            return result != GAME_NOT_OVER;
        }
        public string GetCurentPlayerName()
        {
            return isPlayerOneTurn
                ? playerOne.Name
                : playerTwo.Name;
        }

        private int IsGameOver()
        {
            for (int row = 0; row < BoardProcessor.ROW_COUNT; row++)
            {
                if (boardProcessor.CheckRow(row))
                {
                    return GAME_OVER;
                }
            }

            for (int col = 0; col < BoardProcessor.COL_COUNT; col++)
            {
                if (boardProcessor.CheckCol(col))
                {
                    return GAME_OVER;
                }
            }

            if (boardProcessor.CheckFirstDiagonal())
            {
                return GAME_OVER;
            }

            if (boardProcessor.CheckSecondDiagonal())
            {
                return GAME_OVER;
            }

            if (boardProcessor.IsDraw())
            {
                return GAME_DRAW;
            }

            return GAME_NOT_OVER;
        }

        public void ResetGame()
        {
            foreach (ICell cell in this.cells)
            {
                cell.Reset();
            }
            boardProcessor.Reset();

            isPlayerOneTurn = true;
        }
    }
}
