namespace jeopardy
{
    partial class minesweeper
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b1 = new Button();
            panel1 = new Panel();
            button11 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(10, 17);
            b1.Name = "b1";
            b1.Size = new Size(28, 27);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button11);
            panel1.Controls.Add(b1);
            panel1.Location = new Point(16, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 438);
            panel1.TabIndex = 1;
            // 
            // button11
            // 
            button11.Location = new Point(384, 17);
            button11.Name = "button11";
            button11.Size = new Size(28, 27);
            button11.TabIndex = 11;
            button11.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(447, 457);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

            bool minesweeperOver = false;
            Minefield minefield = new Minefield();
            minefield.dimension.x = 5;
            minefield.dimension.y = 5;
            minefield.startpos.x = 10;
            minefield.startpos.y = 10;
            genMinefield(minefield);
        }

        #endregion

        private Button b1;
        private Panel panel1;
        private Button button11;
    }
}
