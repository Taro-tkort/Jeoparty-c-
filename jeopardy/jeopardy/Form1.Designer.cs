namespace jeopardy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameboard = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            minigames = new Button();
            qboard = new Panel();
            questionLabel = new Label();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            gameboard.SuspendLayout();
            qboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameboard
            // 
            gameboard.BackColor = Color.Beige;
            gameboard.Controls.Add(label6);
            gameboard.Controls.Add(label5);
            gameboard.Controls.Add(label4);
            gameboard.Controls.Add(label3);
            gameboard.Controls.Add(label2);
            gameboard.Controls.Add(label1);
            gameboard.Controls.Add(minigames);
            gameboard.Location = new Point(0, 0);
            gameboard.Name = "gameboard";
            gameboard.Size = new Size(800, 700);
            gameboard.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(555, 20);
            label6.Name = "label6";
            label6.Size = new Size(43, 21);
            label6.TabIndex = 6;
            label6.Text = "GGG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(462, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 42);
            label5.TabIndex = 5;
            label5.Text = "EPIC\r\nGAMING";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(361, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 42);
            label4.TabIndex = 4;
            label4.Text = "Oscar eller\r\nPappa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(228, 20);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 3;
            label3.Text = "Racism";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 20);
            label2.Name = "label2";
            label2.Size = new Size(29, 21);
            label2.TabIndex = 2;
            label2.Text = "Jul";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 1;
            label1.Text = "Tilfeldig";
            // 
            // minigames
            // 
            minigames.Location = new Point(350, 627);
            minigames.Name = "minigames";
            minigames.Size = new Size(75, 23);
            minigames.TabIndex = 0;
            minigames.Text = "minigames";
            minigames.UseVisualStyleBackColor = true;
            minigames.Click += minigames_Click;
            // 
            // qboard
            // 
            qboard.BackColor = Color.CadetBlue;
            qboard.Controls.Add(questionLabel);
            qboard.Controls.Add(pictureBox1);
            qboard.Controls.Add(closeBtn);
            qboard.Location = new Point(0, 0);
            qboard.Name = "qboard";
            qboard.Size = new Size(800, 700);
            qboard.TabIndex = 0;
            qboard.Visible = false;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.Top;
            questionLabel.Font = new Font("Segoe UI", 20F);
            questionLabel.Location = new Point(105, 20);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(550, 173);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "tstststtstststtsts";
            questionLabel.TextAlign = ContentAlignment.TopCenter;
            questionLabel.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(105, 196);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 381);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(295, 600);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(150, 50);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "REVEAL";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(qboard);
            Controls.Add(gameboard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gameboard.ResumeLayout(false);
            gameboard.PerformLayout();
            qboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel gameboard;
        private Panel qboard;
        private Panel betboard;
        private Button closeBtn;
        private Label questionLabel;
        private Button minigames;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}
