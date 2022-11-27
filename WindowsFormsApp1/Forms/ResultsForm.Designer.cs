namespace WordRemmember.Forms
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaximizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncorrectCount = new System.Windows.Forms.Label();
            this.correctCount = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.CloseBtn);
            this.MainPanel.Controls.Add(this.MaximizeBtn);
            this.MainPanel.Controls.Add(this.MinimizeBtn);
            this.MainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.MainPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.MainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShadowDecoration.Parent = this.MainPanel;
            this.MainPanel.Size = new System.Drawing.Size(1048, 33);
            this.MainPanel.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Animated = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(93)))), ((int)(((byte)(86)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.Location = new System.Drawing.Point(5, 8);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(15, 15);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.UseTransparentBackground = true;
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Animated = true;
            this.MaximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBtn.CheckedState.Parent = this.MaximizeBtn;
            this.MaximizeBtn.CustomImages.Parent = this.MaximizeBtn;
            this.MaximizeBtn.Enabled = false;
            this.MaximizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(75)))));
            this.MaximizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBtn.ForeColor = System.Drawing.Color.White;
            this.MaximizeBtn.HoverState.Parent = this.MaximizeBtn;
            this.MaximizeBtn.Location = new System.Drawing.Point(47, 8);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MaximizeBtn.ShadowDecoration.Parent = this.MaximizeBtn;
            this.MaximizeBtn.Size = new System.Drawing.Size(15, 15);
            this.MaximizeBtn.TabIndex = 2;
            this.MaximizeBtn.UseTransparentBackground = true;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Animated = true;
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
            this.MinimizeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(53)))));
            this.MinimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.HoverState.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Location = new System.Drawing.Point(26, 8);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
            this.MinimizeBtn.Size = new System.Drawing.Size(15, 15);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(267, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your results";
            // 
            // ResultsGridView
            // 
            this.ResultsGridView.AllowUserToAddRows = false;
            this.ResultsGridView.AllowUserToDeleteRows = false;
            this.ResultsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ResultsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ResultsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ResultsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ResultsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultsGridView.ColumnHeadersHeight = 30;
            this.ResultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.UserAnswer,
            this.CorrectAnswer});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ResultsGridView.EnableHeadersVisualStyles = false;
            this.ResultsGridView.GridColor = System.Drawing.Color.White;
            this.ResultsGridView.Location = new System.Drawing.Point(12, 110);
            this.ResultsGridView.Name = "ResultsGridView";
            this.ResultsGridView.ReadOnly = true;
            this.ResultsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.ResultsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ResultsGridView.RowTemplate.Height = 30;
            this.ResultsGridView.RowTemplate.ReadOnly = true;
            this.ResultsGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultsGridView.Size = new System.Drawing.Size(691, 376);
            this.ResultsGridView.TabIndex = 0;
            this.ResultsGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ResultsGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ResultsGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ResultsGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ResultsGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ResultsGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ResultsGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ResultsGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultsGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ResultsGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.ResultsGridView.ThemeStyle.ReadOnly = true;
            this.ResultsGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ResultsGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultsGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ResultsGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.ResultsGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // UserAnswer
            // 
            this.UserAnswer.HeaderText = "Your answer";
            this.UserAnswer.Name = "UserAnswer";
            this.UserAnswer.ReadOnly = true;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.HeaderText = "Correct answer";
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.ReadOnly = true;
            // 
            // IncorrectCount
            // 
            this.IncorrectCount.AutoSize = true;
            this.IncorrectCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncorrectCount.ForeColor = System.Drawing.Color.Red;
            this.IncorrectCount.Location = new System.Drawing.Point(49, 64);
            this.IncorrectCount.Name = "IncorrectCount";
            this.IncorrectCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncorrectCount.Size = new System.Drawing.Size(24, 25);
            this.IncorrectCount.TabIndex = 7;
            this.IncorrectCount.Text = "0";
            // 
            // correctCount
            // 
            this.correctCount.AutoSize = true;
            this.correctCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.correctCount.Location = new System.Drawing.Point(620, 64);
            this.correctCount.Name = "correctCount";
            this.correctCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.correctCount.Size = new System.Drawing.Size(24, 25);
            this.correctCount.TabIndex = 7;
            this.correctCount.Text = "0";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(715, 506);
            this.Controls.Add(this.correctCount);
            this.Controls.Add(this.IncorrectCount);
            this.Controls.Add(this.ResultsGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel MainPanel;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MaximizeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ResultsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
        private System.Windows.Forms.Label IncorrectCount;
        private System.Windows.Forms.Label correctCount;
    }
}