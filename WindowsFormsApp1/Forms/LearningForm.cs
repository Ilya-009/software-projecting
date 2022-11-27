using msvload.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace WordRemmember.Forms
{
    public partial class LearningForm : Form
    {
        private List<ReadDataModel> data = new List<ReadDataModel>();
        private List<ReadDataModel> results = new List<ReadDataModel>();//correct ans
        private TestingSettings TestingSettings { get; set; } = new TestingSettings(false, 0, false);
        private bool isTesing;
        private Random random = new Random();
        
        private int currErrors = 0;
        private int id = 0;

        public LearningForm()
        {
            InitializeComponent();
        }

        //constructor for practice mode
        public LearningForm(List<ReadDataModel> data)
        {
            this.data = data;
            isTesing = true;
            InitializeComponent();
        }

        //constructor for testing mode
        public LearningForm(List<ReadDataModel> data, TestingSettings TestingSettings)
        {
            this.data = data;
            this.TestingSettings = TestingSettings;
            InitializeComponent();
        }


        private void LearningForm_Load(object sender, EventArgs e)
        {
            if (!TestingSettings.DefaultOrder)
            {
                id = RandomVal();
            }

            Question.Text = data.ElementAt(id).Key;

            CloseBtn.Click += (s, a) => Dispose();

            MinimizeBtn.Click += (s, a) => { WindowState = FormWindowState.Minimized; };

            MaximizeBtn.Click += (s, a) =>
            {
                WindowState = WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };

            AnswerInput.KeyDown += (s, a) =>
            {
                if (a.KeyCode == Keys.Enter)
                {
                    nextQuestBtn_Click(s, e);
                }
            };

        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MainPanel.Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        private void nextQuestBtn_Click(object sender, EventArgs e)
        {
            string userInput = AnswerInput.Text.Trim();
            ReadDataModel dataModel = data.ElementAt(id);

            if (userInput == string.Empty)
            {
                MessageBox.Show(
                    $"Error occured, see information below \n You must write not less than 5 symbols!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string userInputValue = userInput.Trim().ToLower().Replace(" ", string.Empty);
            string answerValue = data.ElementAt(id).Answer.Trim().ToLower().Replace(" ", string.Empty);

            //check for correct answer
            if(userInputValue == answerValue)
            {
                results.Add(new ReadDataModel(dataModel.Key, dataModel.Answer, userInput ,true));//if correct

                if (!isTesing)
                {
                    MessageBox.Show(
                        $"Your answer is correct",
                        "Well done!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                currErrors = 0;
            }
            else
            {
                if (TestingSettings.HintCount != 0 && currErrors < TestingSettings.HintCount)
                {
                    currErrors++;

                    MessageBox.Show(
                        $"Answer starts with letter(s) {getFirstWordChars(data.ElementAt(id).Answer, (byte)currErrors)}",
                        "Hint",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    AnswerInput.Clear();
                    return;
                }

                currErrors = 0;
                results.Add(new ReadDataModel(dataModel.Key, dataModel.Answer, userInput, false));
            }

            if (data.Count - 1 == 0)
            {
                if (MessageBox.Show("Learning process finished, would you like to see your results?",
                        "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    Dispose();

                    Application.OpenForms
                        .Cast<Form>()
                        .FirstOrDefault(f => f.Name == "MainForm")
                        .WindowState = FormWindowState.Normal;
                    return;
                }

                //if user clicked YES
                ResultsForm resultsForm = new ResultsForm(results);
                Dispose();
                resultsForm.Show();
                resultsForm.Activate();
                return;
            }

            data.RemoveAt(id);

            //check for the last question
            if (data.Count == 1)
            {
                nextQuestBtn.Text = "FINISH";   
            }

            AnswerInput.Clear();

            if (!TestingSettings.DefaultOrder)
            {
                id = RandomVal();
            }
            Question.Text = data.ElementAt(id).Key;
        }

        private int RandomVal()
        {
            return random.Next(0, data.Count);
        }

        private string getFirstWordChars(string input, byte count)
        {
            return input.Substring(0, count + 1);
        }
    }
}
