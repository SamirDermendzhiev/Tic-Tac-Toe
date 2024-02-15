using Engine.Processors;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private DisplayProcessor displayProcessor;

        public Form1()
        {
            InitializeComponent();

            Cell[] cells =
            {
                this.cell1,
                this.cell2,
                this.cell3,
                this.cell4,
                this.cell5,
                this.cell6,
                this.cell7,
                this.cell8,
                this.cell9
            };

            displayProcessor = new DisplayProcessor(cells);
            SetCurentPlayerName();
        }

        private void CellClick(object sender, System.EventArgs e)
        {
            Cell cell = (Cell)sender;
            if (displayProcessor.MakeTurn(cell, out string winner))
            {
                string message;
                if (winner == null)
                {
                    message = "Draw";
                }
                else
                {
                    message = "Winner: " + winner; 
                }
                MessageBox.Show(message);
                displayProcessor.ResetGame();
            }
            SetCurentPlayerName();
        }
        private void SetCurentPlayerName()
        {
            this.CurentPlayer.Text = displayProcessor.GetCurentPlayerName();
        }
    }
}
