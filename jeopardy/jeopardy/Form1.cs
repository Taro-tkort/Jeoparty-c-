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

        //ButtonArray specs
        private Button[,] buttons;
        private int numCategories = 6;
        private int numQuestions = 5;
        private int baseHeight = 50;
        private int baseWidth = 50;
        private int baseScore = 100;
        private int globalBuffer = 100;


        private questionSet currentQuestionSet = new questionSet();

        public Form1()
        {
            buttons = new Button[numCategories, numQuestions];
            InitializeComponent();
            //generates in a horizontal manner
            for (int rows = 1; rows <= numCategories; rows++)
            {
                GenerateButtons(baseScore, numQuestions, baseWidth, baseHeight, rows - 1);
            }
            this.SizeChanged += gameboard_SizeChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void GenerateButtons(int baseScore, int numQuestions, int width, int height, int category)
        {
            int xpos = 50*category;
            int ypos = 50;
            int score = baseScore;

            for (int i = 0; i < numQuestions; i++)
            {
                buttons[category,i] = new Button();
                buttons[category,i].Size = new Size(width, height);
                buttons[category,i].Location = new Point(xpos, ypos);
                gameboard.Controls.Add(buttons[category, i]);
                buttons[category, i].Click += new System.EventHandler(ClickButton);
                buttons[category, i].Text = score.ToString();

                questionSet tmp = getQuestionSets(path, category, i); // A-ok does not crash atall
                buttons[category, i].Tag = new buttonData { row = i, pts = score, QA = tmp };
                buttons[category, i].BackColor = Color.Beige;

                //ready for next loop
                score = 100 * (i + 2);
                ypos += baseHeight;
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

        private void gameboard_SizeChanged(object sender, EventArgs e)
        {
            int newHeight = this.Height - globalBuffer*2;
            int newWidth = this.Width - globalBuffer*2;
            int buttonH = newHeight / numQuestions;
            int buttonW = newWidth / numCategories;
            int sPointX = 0 + globalBuffer;
            int sPointY = 0 + globalBuffer;
            gameboard.Size = new Size(this.Width, this.Height);
            qboard.Size = new Size(this.Width, this.Height);

            for (int y = 0; y < numCategories; y++)
            {
                sPointY = globalBuffer;
                for (int x = 0; x < numQuestions; x++)
                {
                    buttons[y,x].Size = new Size(buttonW, buttonH);
                    buttons[y,x].Location = new Point(sPointX,sPointY);
                    sPointY += buttonH;
                }
                sPointX += buttonW;
            }
            //Filthy boiler plate
            label1.Location = new Point(globalBuffer, 50);
            label2.Location = new Point(buttonW * 1 + globalBuffer, 50);
            label3.Location = new Point(buttonW * 2 + globalBuffer, 50);
            label4.Location = new Point(buttonW * 3 + globalBuffer, 50);
            label5.Location = new Point(buttonW * 4 + globalBuffer, 50);
            label6.Location = new Point(buttonW * 5 + globalBuffer, 50);
        }
    }
}
