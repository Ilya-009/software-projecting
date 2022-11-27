using Guna.UI2.WinForms;
using msvload.Entities;
using msvload.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WordRemmember.Forms;

namespace WordRemmember
{
    public partial class MainForm : Form
    {
        private string _folder =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WordRemmember";
        
        List<ReadDataModel> data = new List<ReadDataModel>();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            MainMenuBtnActive(DashboardBtn);
            ChangeFormStyle(Properties.Settings.Default.IsDefaultStyle);

            //load already saved data
            if (!data.Any())
            {
                try
                {
                    data.AddRange(await ReadWrite.ReadData(Path.Combine(_folder, "data.txt")));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error occured(code: LD100), see information below \n {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            //set current date
            CurrentDate.Text = DateTime.Today.ToShortDateString();

            CloseBtn.Click += (s, a) => Application.Exit();

            MinimizeBtn.Click += (s, a) => { WindowState = FormWindowState.Minimized; };

            MaximizeBtn.Click += (s, a) =>
            {
                WindowState = WindowState == FormWindowState.Maximized
                    ? FormWindowState.Normal
                    : FormWindowState.Maximized;
            };


            // Words service handlers
            addWordsBtn.Click += (s, a) =>
            {
                addNewWords(addWordsTextbox.Text, addWordsTextbox);
                addWordsTextbox.Clear();
            };

            addNewWordsBtn.Click += (s, a) =>
            {
                addNewWords(addNewWordsTextbox.Text, addNewWordsTextbox);
            };

            addNewWordsTextbox.Click += (s, a) =>
            {
                addNewWordsTextbox.Text = string.Empty;
            };

            LearningSettingsBtn.Click += (s, a) =>
            {
                LearningSettingsBtn.FillColor = LearningSettingsPanel.Visible
                    ? Color.Transparent
                    : Color.FromArgb(0, 255, 204);
                LearningSettingsPanel.Visible = !LearningSettingsPanel.Visible;
            };

            resetLearningSettingsBtn.Click += (s, a) =>
            {
                notUseDefaultOrderCheck.Checked = false;
                useHintsCheck.Checked = false;
                hintCountVal.Value = 0;
                showAnswerCheck.Checked = false;
            };

            useHintsCheck.CheckedChanged += (s, a) =>
            {
                hintCountVal.Enabled = ((Guna2CustomCheckBox)s).Checked;
                hintCountVal.Value = 0;
            };

            LearningStartBtn.Click += async (s, a) =>
            {
                data.Clear();
                data.AddRange(await ReadWrite.ReadData(Path.Combine(_folder, "data.txt")));

                if (!data.Any())
                {
                    MessageBox.Show(
                        $"No data for operation found!\nInput data or report bug!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                TestingSettings testingSettings = new TestingSettings(
                    notUseDefaultOrderCheck.Checked, (int)hintCountVal.Value, showAnswerCheck.Checked);

                LearningForm learningForm = new LearningForm(data, testingSettings);

                learningForm.Show();
                learningForm.Activate();
                WindowState = FormWindowState.Minimized;
            };

            TestingStartBtn.Click += async (s, a) =>
            {
                data.Clear();
                data.AddRange(await ReadWrite.ReadData(Path.Combine(_folder, "data.txt")));

                if (!data.Any())
                {
                    MessageBox.Show(
                    $"No data for operation found!\nInput data or report bug!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                LearningForm learningForm = new LearningForm(data);
                WindowState = FormWindowState.Minimized;
                learningForm.ShowDialog();
            };

            DeleteAllWords.Click += (s, a) =>
            {
                if (MessageBox.Show("Вы действительно хотите удалить все добавленные вами слова??",
                    "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                try
                {
                    data.Clear();

                    string pathToDel = Path.Combine(_folder, "data.txt");

                    if (!File.Exists(pathToDel))
                    {
                        MessageBox.Show(
                            $"Error occured, see information below\n" +
                            $"No saved data found",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    File.Delete(pathToDel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error occured(code: LD100), see information below \n {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            };

            Article1Btn.Click += (s, a) =>
            {
                openLink("https://vk.com/@langfastofficial-foreign-lagguage-from-0");
            };

            Article2Btn.Click += (s, a) =>
            {
                openLink("https://vk.com/@langfastofficial-azy-angliiskoi-grammatiki");
            };


            Subscription.Click += (s, a) =>
            {
                openLink("https://vk.com/langfastofficial");
            };

            //Settings panel methods
            AppSettingsSaveBtn.Click += (s, a) =>
            {
                if (DefWindStyleCheck.Checked)
                {
                    ChangeFormStyle(true);
                    Properties.Settings.Default.IsDefaultStyle = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    if (MacOSSstyleCheck.Checked)
                    {
                        ChangeFormStyle(false);
                        Properties.Settings.Default.IsDefaultStyle = false;
                        Properties.Settings.Default.Save();
                    }
                }
            };
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MainPanel.Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                if (pos.Y < 32)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= ClientSize.Width - 16 && pos.Y >= ClientSize.Height - 16)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void ExecutePreset(string categName)
        {
            //execute handler for preset 1
            List<ReadDataModel> gotWords = ReadWrite.GetDataFromWeb(categName);

            if (gotWords == null)
            {
                MessageBox.Show(
                    $"Error occured(code: LD101), see information below \n" +
                    $"Error while getting data from server",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Вы бы хотели добавить эти слова в ваш список слов?",
            "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReadWrite.SetDataToFile(gotWords);
                data.AddRange(gotWords);
            }

            LearningForm learningForm = new LearningForm(gotWords);
            learningForm.ShowDialog();
        }

        private void openLink(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error occured, see information below \n {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MainMenuBtnActive_Click(object sender, EventArgs e)
        {
            MainMenuBtnActive((Guna2Button)sender);
            DisableMainPanelsExceptMain();

            string panelName = ((Guna2Button)sender).Name;

            //display relevant panel
            switch (panelName)
            {
                case "MyWordsBtn":
                    CustomWordsPanel.Visible = true;
                    break;

                case "AppSettingsBtn":
                    DefWindStyleCheck.Checked = Properties.Settings.Default.IsDefaultStyle;
                    MacOSSstyleCheck.Checked = !Properties.Settings.Default.IsDefaultStyle;
                    AppSettingsPanel.Visible = true;
                    break;

                case "PresetsBtn":
                    PresetsPanel.Visible = true;
                    break;

                case "ReferenceMaterialsBtn":
                    openLink("https://vk.com/@langfastofficial");
                    break;
            }
        }

        //handle active state of buttons in main side menu
        private void MainMenuBtnActive(Guna2Button button)
        {
            foreach (var gunaBtn in SideMenuBack.Controls.OfType<Guna2Button>())
            {
                gunaBtn.FillColor = Color.FromArgb(76, 86, 192);
                gunaBtn.ForeColor = Color.White;
            }

            button.FillColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void DisableMainPanelsExceptMain()
        {
            CustomWordsPanel.Visible = false;
            AppSettingsPanel.Visible = false;
            PresetsPanel.Visible = false;
        }

        private void addNewWords(string input, object textBox)
        {
            if (input == string.Empty)
            {
                MessageBox.Show(
                        $"Error occured, see information below \n You have written nothing in this field",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            input = input.Trim();

            if (input.Length < 5 || !input.Contains("-"))
            {
                MessageBox.Show(
                    $"Error occured, see information below \n You must write not less than 5 symbols!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string[] words = input.Split('\n');

            ReadWrite.SetDataToFile(Path.Combine(_folder, "data.txt"), words);

            MessageBox.Show(
                    $"Success, words have been successfully loaded!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            ((Guna2TextBox)textBox).Clear();
        }

        private void ChangeFormStyle(bool IsDefault)
        {
            FormBorderStyle = IsDefault ? FormBorderStyle.FixedSingle : FormBorderStyle.None;
            MainPanel.Visible = !IsDefault;
        }

        private void WordCateg1_Click(object sender, EventArgs e)
        {
            ExecutePreset( ((Guna2CustomGradientPanel)sender).Name );
        }

        private void TransportPreset_Click(object sender, EventArgs e)
        {
            string presetName = ((Guna2Panel)sender).Name;
            
            switch (presetName)
            {
                case "TransportPreset":
                    ExecutePreset("WordCateg1");
                    break;
                case "AppearancePreset":
                    ExecutePreset("WordCateg2");
                    break;
                case "AnimalsPreset":
                    ExecutePreset("WordCateg3");
                    break;
            }
        }
    }
}

