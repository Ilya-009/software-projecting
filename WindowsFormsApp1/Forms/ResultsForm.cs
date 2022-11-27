using msvload.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WordRemmember.Forms
{
    public partial class ResultsForm : Form
    {
        private List<ReadDataModel> results = new List<ReadDataModel>();
        int correct=0, incorrect = 0;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(List<ReadDataModel> results)
        {
            this.results = results;
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            CloseBtn.Click += (s, a) => {
                Dispose();

                Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Name == "MainForm").WindowState = FormWindowState.Normal;
            };

            MinimizeBtn.Click += (s, a) => { WindowState = FormWindowState.Minimized; };

            int rowId = 0;
            foreach (var res in results)
            {
                ResultsGridView.Rows.Add(new object[] { res.Key, res.UserInput, res.Answer });

                if (!res.IsCorrect)
                {
                    ResultsGridView.Rows[rowId].DefaultCellStyle.BackColor = Color.Red;
                    ResultsGridView.Rows[rowId].DefaultCellStyle.ForeColor = Color.White;
                    incorrect++;
                }
                else
                {
                    ResultsGridView.Rows[rowId].DefaultCellStyle.BackColor = Color.Green;
                    ResultsGridView.Rows[rowId].DefaultCellStyle.ForeColor = Color.White;
                    correct++;
                }
                rowId++;
            }

            ResultsGridView.ClearSelection();
            IncorrectCount.Text = incorrect.ToString();
            correctCount.Text = correct.ToString();
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

    }
}
