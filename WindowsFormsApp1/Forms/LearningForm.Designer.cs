namespace WordRemmember.Forms
{
    partial class LearningForm
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
            this.Question = new System.Windows.Forms.Label();
            this.MinimizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MaximizeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.AnswerInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.nextQuestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Question.Location = new System.Drawing.Point(12, 49);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(114, 29);
            this.Question.TabIndex = 5;
            this.Question.Text = "Question";
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
            this.MinimizeBtn.TabIndex = 4;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.UseTransparentBackground = true;
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
            this.MaximizeBtn.TabIndex = 5;
            this.MaximizeBtn.TabStop = false;
            this.MaximizeBtn.UseTransparentBackground = true;
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
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.UseTransparentBackground = true;
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
            this.MainPanel.Size = new System.Drawing.Size(1170, 33);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            // 
            // AnswerInput
            // 
            this.AnswerInput.Animated = true;
            this.AnswerInput.BorderColor = System.Drawing.Color.White;
            this.AnswerInput.BorderRadius = 7;
            this.AnswerInput.BorderThickness = 3;
            this.AnswerInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerInput.DefaultText = "";
            this.AnswerInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AnswerInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AnswerInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerInput.DisabledState.Parent = this.AnswerInput;
            this.AnswerInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerInput.FocusedState.Parent = this.AnswerInput;
            this.AnswerInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AnswerInput.ForeColor = System.Drawing.Color.Black;
            this.AnswerInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.AnswerInput.HoverState.Parent = this.AnswerInput;
            this.AnswerInput.Location = new System.Drawing.Point(17, 97);
            this.AnswerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AnswerInput.Multiline = true;
            this.AnswerInput.Name = "AnswerInput";
            this.AnswerInput.PasswordChar = '\0';
            this.AnswerInput.PlaceholderText = "Write your answer here";
            this.AnswerInput.SelectedText = "";
            this.AnswerInput.ShadowDecoration.Parent = this.AnswerInput;
            this.AnswerInput.Size = new System.Drawing.Size(564, 218);
            this.AnswerInput.TabIndex = 1;
            // 
            // nextQuestBtn
            // 
            this.nextQuestBtn.Animated = true;
            this.nextQuestBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextQuestBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextQuestBtn.BorderRadius = 10;
            this.nextQuestBtn.BorderThickness = 3;
            this.nextQuestBtn.CheckedState.Parent = this.nextQuestBtn;
            this.nextQuestBtn.CustomImages.Parent = this.nextQuestBtn;
            this.nextQuestBtn.FillColor = System.Drawing.Color.Transparent;
            this.nextQuestBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nextQuestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextQuestBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextQuestBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.nextQuestBtn.HoverState.Parent = this.nextQuestBtn;
            this.nextQuestBtn.Location = new System.Drawing.Point(413, 365);
            this.nextQuestBtn.Name = "nextQuestBtn";
            this.nextQuestBtn.ShadowDecoration.Parent = this.nextQuestBtn;
            this.nextQuestBtn.Size = new System.Drawing.Size(168, 53);
            this.nextQuestBtn.TabIndex = 2;
            this.nextQuestBtn.Text = "NEXT QUESTION";
            this.nextQuestBtn.Click += new System.EventHandler(this.nextQuestBtn_Click);
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 441);
            this.Controls.Add(this.nextQuestBtn);
            this.Controls.Add(this.AnswerInput);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 441);
            this.Name = "LearningForm";
            this.Text = "LearningForm";
            this.Load += new System.EventHandler(this.LearningForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private Guna.UI2.WinForms.Guna2CircleButton MinimizeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MaximizeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton CloseBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel MainPanel;
        private Guna.UI2.WinForms.Guna2TextBox AnswerInput;
        private Guna.UI2.WinForms.Guna2Button nextQuestBtn;
    }
}