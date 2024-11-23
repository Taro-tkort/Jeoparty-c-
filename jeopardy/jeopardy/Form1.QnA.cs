namespace jeopardy
{
    public class questionSet
    {
        public string question;
        public string answer;
        public string qpic;
        public string apic;
    }
    public class buttonData
    {
        public int row;
        public int pts;
        public required questionSet QA;
    }

    partial class Form1
    {
         private questionSet getQuestionSets(string path, int row, int shelf)
        {
            questionSet tmp = new questionSet();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    if (values[0] == row.ToString() && values[1] == shelf.ToString()) //supahjanky
                    {
                        tmp.question = values[2];
                        tmp.answer = values[3];
                        tmp.qpic = values[4];
                        tmp.apic = values[5];

                        break;
                    }
                }
            }
            //MessageBox.Show(tmp.question.ToString());
            //MessageBox.Show(tmp.answer.ToString());
            return tmp;
        }
    }
}