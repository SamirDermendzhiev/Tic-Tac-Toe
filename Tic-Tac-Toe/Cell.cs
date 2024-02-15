using Engine.Contracts;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Cell : Button, ICell
    {
        public Cell()
        {
            InitializeComponent();
            this.TabStop = false;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public void AddText(string text)
        {
            this.Text = text;
            this.Enabled = false;
        }

        public void Reset()
        {
            this.Text = "";
            this.Enabled = true;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
