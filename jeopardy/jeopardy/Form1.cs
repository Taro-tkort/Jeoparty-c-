using System.CodeDom.Compiler;
using System.Drawing.Drawing2D;
using System.IO;
namespace jeopardy
{
    public partial class Form1 : Form
    {
        private bool questionMode = false;
        static string path = "C:\\Tissemenn\\projects\\Jeoparty-c-\\jeopardy\\jeopardy\\Q.csv";

        private questionSet currentQuestionSet = new questionSet();

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                GenerateButton(100 * i, 7, 40, 50 * i, 50, 100, i-1);
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
                buttons[i].Tag = new buttonData{row = i, pts = val, QA = tmp};
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
            //questionSet QA = data.QA;
            button.BackColor = Color.Black;
            button.ForeColor = Color.Black;
            questionLabel.Text = currentQuestionSet.question;
            qboard.Visible = true;
            questionMode = true;
        }

        //Reveal Answer and close Dialouge
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //questionSet QA = data.QA;
            if (questionMode) {
                questionLabel.Text = currentQuestionSet.answer;
                questionMode = false;
            } else { 
                questionMode = true;
                qboard.Visible = false;
            }

        }
    }
}
