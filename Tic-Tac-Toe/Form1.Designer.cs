namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cell1 = new Tic_Tac_Toe.Cell();
            this.cell2 = new Tic_Tac_Toe.Cell();
            this.cell3 = new Tic_Tac_Toe.Cell();
            this.cell4 = new Tic_Tac_Toe.Cell();
            this.cell5 = new Tic_Tac_Toe.Cell();
            this.cell6 = new Tic_Tac_Toe.Cell();
            this.cell7 = new Tic_Tac_Toe.Cell();
            this.cell8 = new Tic_Tac_Toe.Cell();
            this.cell9 = new Tic_Tac_Toe.Cell();
            this.CurentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cell1
            // 
            this.cell1.Col = 0;
            this.cell1.Location = new System.Drawing.Point(7, 82);
            this.cell1.Name = "cell1";
            this.cell1.Row = 0;
            this.cell1.Size = new System.Drawing.Size(71, 67);
            this.cell1.TabIndex = 0;
            this.cell1.TabStop = false;
            this.cell1.UseVisualStyleBackColor = true;
            this.cell1.Click += new System.EventHandler(this.CellClick);
            // 
            // cell2
            // 
            this.cell2.Col = 1;
            this.cell2.Location = new System.Drawing.Point(84, 82);
            this.cell2.Name = "cell2";
            this.cell2.Row = 0;
            this.cell2.Size = new System.Drawing.Size(71, 67);
            this.cell2.TabIndex = 0;
            this.cell2.TabStop = false;
            this.cell2.UseVisualStyleBackColor = true;
            this.cell2.Click += new System.EventHandler(this.CellClick);
            // 
            // cell3
            // 
            this.cell3.Col = 2;
            this.cell3.Location = new System.Drawing.Point(161, 155);
            this.cell3.Name = "cell3";
            this.cell3.Row = 1;
            this.cell3.Size = new System.Drawing.Size(71, 67);
            this.cell3.TabIndex = 0;
            this.cell3.TabStop = false;
            this.cell3.UseVisualStyleBackColor = true;
            this.cell3.Click += new System.EventHandler(this.CellClick);
            // 
            // cell4
            // 
            this.cell4.Col = 0;
            this.cell4.Location = new System.Drawing.Point(7, 155);
            this.cell4.Name = "cell4";
            this.cell4.Row = 1;
            this.cell4.Size = new System.Drawing.Size(71, 66);
            this.cell4.TabIndex = 1;
            this.cell4.TabStop = false;
            this.cell4.UseVisualStyleBackColor = true;
            this.cell4.Click += new System.EventHandler(this.CellClick);
            // 
            // cell5
            // 
            this.cell5.Col = 2;
            this.cell5.Location = new System.Drawing.Point(161, 82);
            this.cell5.Name = "cell5";
            this.cell5.Row = 0;
            this.cell5.Size = new System.Drawing.Size(71, 67);
            this.cell5.TabIndex = 0;
            this.cell5.TabStop = false;
            this.cell5.UseVisualStyleBackColor = true;
            this.cell5.Click += new System.EventHandler(this.CellClick);
            // 
            // cell6
            // 
            this.cell6.Col = 1;
            this.cell6.Location = new System.Drawing.Point(84, 155);
            this.cell6.Name = "cell6";
            this.cell6.Row = 1;
            this.cell6.Size = new System.Drawing.Size(71, 66);
            this.cell6.TabIndex = 1;
            this.cell6.TabStop = false;
            this.cell6.UseVisualStyleBackColor = true;
            this.cell6.Click += new System.EventHandler(this.CellClick);
            // 
            // cell7
            // 
            this.cell7.Col = 2;
            this.cell7.Location = new System.Drawing.Point(161, 228);
            this.cell7.Name = "cell7";
            this.cell7.Row = 2;
            this.cell7.Size = new System.Drawing.Size(71, 67);
            this.cell7.TabIndex = 0;
            this.cell7.TabStop = false;
            this.cell7.UseVisualStyleBackColor = true;
            this.cell7.Click += new System.EventHandler(this.CellClick);
            // 
            // cell8
            // 
            this.cell8.Col = 0;
            this.cell8.Location = new System.Drawing.Point(7, 228);
            this.cell8.Name = "cell8";
            this.cell8.Row = 2;
            this.cell8.Size = new System.Drawing.Size(71, 66);
            this.cell8.TabIndex = 1;
            this.cell8.TabStop = false;
            this.cell8.UseVisualStyleBackColor = true;
            this.cell8.Click += new System.EventHandler(this.CellClick);
            // 
            // cell9
            // 
            this.cell9.Col = 1;
            this.cell9.Location = new System.Drawing.Point(84, 228);
            this.cell9.Name = "cell9";
            this.cell9.Row = 2;
            this.cell9.Size = new System.Drawing.Size(71, 66);
            this.cell9.TabIndex = 1;
            this.cell9.TabStop = false;
            this.cell9.UseVisualStyleBackColor = true;
            this.cell9.Click += new System.EventHandler(this.CellClick);
            // 
            // CurentPlayer
            // 
            this.CurentPlayer.AutoSize = true;
            this.CurentPlayer.Location = new System.Drawing.Point(12, 9);
            this.CurentPlayer.Name = "CurentPlayer";
            this.CurentPlayer.Size = new System.Drawing.Size(0, 13);
            this.CurentPlayer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 304);
            this.Controls.Add(this.CurentPlayer);
            this.Controls.Add(this.cell9);
            this.Controls.Add(this.cell8);
            this.Controls.Add(this.cell6);
            this.Controls.Add(this.cell7);
            this.Controls.Add(this.cell4);
            this.Controls.Add(this.cell3);
            this.Controls.Add(this.cell5);
            this.Controls.Add(this.cell2);
            this.Controls.Add(this.cell1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cell cell1;
        private Cell cell2;
        private Cell cell3;
        private Cell cell4;
        private Cell cell5;
        private Cell cell6;
        private Cell cell7;
        private Cell cell8;
        private Cell cell9;
        private System.Windows.Forms.Label CurentPlayer;
    }
}

