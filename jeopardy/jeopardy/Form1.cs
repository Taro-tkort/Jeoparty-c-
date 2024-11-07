using System.CodeDom.Compiler;
using System.Drawing.Drawing2D;
namespace jeopardy
{
    public partial class Form1 : Form
    {
        private bool answerMode = false;

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                GenerateButton(100 * i, 6, 40, 50 * i, 50, 100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton(int val, int num, int xstart, int ystart, int height, int width)
        {
            int xpos = xstart;
            int ypos = ystart;

            Button[] buttons = new Button[num];
            for (int i = 0; i < num; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new Size(width, height);
                buttons[i].Location = new Point(xpos, ypos);
                gameboard.Controls.Add(buttons[i]);
                xpos += width;
                buttons[i].Click += new System.EventHandler(ClickButton);
                buttons[i].Text = val.ToString();
                buttons[i].Tag = val;
                buttons[i].BackColor = Color.Beige;
            }
        }

        private void ClickButton(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int scoreGiven = (int)button.Tag;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Black;
            MessageBox.Show(scoreGiven.ToString());
            qboard.Visible = true;
            answerMode = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (answerMode)
            {

            }
            else { 
            
            }

        }
    }
}
