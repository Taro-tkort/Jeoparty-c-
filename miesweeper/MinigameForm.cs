using System;
using System.Windows.Forms;

namespace MinigameForm
{
    public partial class MinigameForm : Form
    {
        public MinigameForm()
        {
            InitializeComponent();
        }
        private void genMinefield(Minefield field)
        {
            int xpos = field.startpos.x;
            int ypos = field.startpos.y;

            Button[,] buttonMines = new Button[field.dimension.x,field.dimension.y];
            for (int y = 0; y < field.dimension.y; y++) {
                for (int x = 0; x <= field.dimension.x; x++) {
                    buttonMines[x,y] = new Button();
                    buttonMines[x,y].Size = new Size(field.dimension.x, field.dimension.y);
                    buttonMines[x,y].Location = new Point(xpos, ypos);
                    Controls.Add(buttonMines[x,y]);
                    xpos += field.dimension.x;
                    buttonMines[x,y].Click += new System.EventHandler(ClickMine);
                    buttonMines[x,y].Text = "";
                    buttonMines[x,y].Tag = field.gameBoard[x,y]; //11 equals mine
                    buttonMines[x,y].BackColor = Color.Gray;
                }
            }
        }

        //Show approtpiate question screen upon clicking
        private void ClickMine(Object sender, EventArgs e)
        {
            Button mine = (Button)sender;
            int mineinfo = (int)mine.Tag;
            //questionSet QA = data.QA;
            mine.BackColor = Color.White;
            mine.ForeColor = Color.White;
            if (mineinfo != 11) {
                mine.Text = mineinfo.ToString();
            } else {
                mine.Text = "*";
                mine.ForeColor = Color.Red;
                mine.BackColor = Color.Red;
            }
        }
    }
    public class Minefield()
    {
        public struct Dimension
        {
            public int x;
            public int y;
        }
        public Dimension dimension;
        public struct Startpos
        {
            public int x;
            public int y;
        }
        public Startpos startpos;
        public int[,] gameBoard;

        public int[,] GenerateGameBoard(Dimension dims)
        {
            Random rnd = new Random();
            int allotedMines = dims.x * dims.y;
            int totTitles = dims.x * dims.y;
            int[,] field = new int[dims.x, dims.y];

            while (allotedMines > 0)
            {
                for (int i = 0; i <= dims.x; i++)
                {
                    for (int j = 0; j <= dims.y; j++)
                    {
                        if (rnd.Next(1, 50) == 17)
                        {
                            field[i, j] = 11;
                            allotedMines--;
                        }
                    }
                }
            }
            return field;
        }
    }
}