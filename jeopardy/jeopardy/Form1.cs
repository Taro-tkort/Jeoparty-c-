using System.CodeDom.Compiler;
using System.Drawing.Drawing2D;
using System.IO;
namespace jeopardy
{
    public partial class Form1 : Form
    {
        private bool questionMode = false;
        static string path = "C:\\Tissemenn\\projects\\Jeoparty-c-\\jeopardy\\jeopardy\\Q.csv";
        static string picturePath = "C:\\Tissemenn\\projects\\Jeoparty-c-\\jeopardy\\jeopardy\\resources\\";

        private questionSet currentQuestionSet = new questionSet();

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                GenerateButton(100 * i, 6, 40, 50 * i, 50, 100, i - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton(int val, int num, int xstart, int ystart, int height, int width, int shelf)
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
                //buttons[i].Tag = val;
                questionSet tmp = getQuestionSets(path, i, shelf); // A-ok does not crash atall
                buttons[i].Tag = new buttonData { row = i, pts = val, QA = tmp };
                buttons[i].BackColor = Color.Beige;
            }
        }

        //Show approtpiate question screen upon clicking
        private void ClickButton(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonData data = button.Tag as buttonData;
            int scoreGiven = data.pts;
            int row = data.row;
            currentQuestionSet.question = data.QA.question.ToString();
            currentQuestionSet.answer = data.QA.answer.ToString();
            currentQuestionSet.qpic = picturePath + data.QA.qpic.ToString() + ".jpg";
            currentQuestionSet.apic = picturePath + data.QA.apic.ToString() + ".jpg";
            //MessageBox.Show(currentQuestionSet.qpic);
            //questionSet QA = data.QA;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Black;
            questionLabel.Text = currentQuestionSet.question;
            pictureBox1.Image = Image.FromFile(currentQuestionSet.qpic);
            qboard.Visible = true;
            questionMode = true;
        }

        //Reveal Answer and close Dialouge
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //questionSet QA = data.QA;
            if (questionMode)
            {
                questionLabel.Text = currentQuestionSet.answer;
                questionMode = false;
                pictureBox1.Image = Image.FromFile(currentQuestionSet.apic);
            }
            else
            {
                questionMode = true;
                qboard.Visible = false;
            }

        }

        private void minigames_Click(object sender, EventArgs e)
        {
            FormMinesweeper fm = new FormMinesweeper();
            fm.ShowDialog();
        }
    }
}
