

namespace D365RiskAnalyzer
{
    partial class MainForm
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
            pnlTop = new Panel();
            lblHighCount = new Label();
            lblTitle = new Label();
            lblMediumCount = new Label();
            lblLowCount = new Label();
            pnlMenu = new Panel();
            btnExit = new Button();
            btnHistory = new Button();
            btnNewAssessment = new Button();
            pnlMain = new Panel();
            lblAverageRisk = new Label();
            lblHighRisk = new Label();
            lblTotalAssessments = new Label();
            pnlTop.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.DarkBlue;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(982, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblHighCount
            // 
            lblHighCount.AutoSize = true;
            lblHighCount.BackColor = Color.Red;
            lblHighCount.Location = new Point(590, 193);
            lblHighCount.Name = "lblHighCount";
            lblHighCount.Size = new Size(60, 20);
            lblHighCount.TabIndex = 5;
            lblHighCount.Text = "HIGH: 0";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = SystemColors.ControlLightLight;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "D365 Risk Analyzer";
            // 
            // lblMediumCount
            // 
            lblMediumCount.AutoSize = true;
            lblMediumCount.BackColor = Color.Orange;
            lblMediumCount.Location = new Point(331, 193);
            lblMediumCount.Name = "lblMediumCount";
            lblMediumCount.Size = new Size(83, 20);
            lblMediumCount.TabIndex = 4;
            lblMediumCount.Text = "MEDIUM: 0";
            // 
            // lblLowCount
            // 
            lblLowCount.AutoSize = true;
            lblLowCount.BackColor = Color.LightGreen;
            lblLowCount.Location = new Point(98, 193);
            lblLowCount.Name = "lblLowCount";
            lblLowCount.Size = new Size(55, 20);
            lblLowCount.TabIndex = 3;
            lblLowCount.Text = "LOW: 0";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.LightGray;
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(btnHistory);
            pnlMenu.Controls.Add(btnNewAssessment);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 60);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 493);
            pnlMenu.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 193);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 56);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(12, 112);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(169, 56);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnNewAssessment
            // 
            btnNewAssessment.Location = new Point(12, 29);
            btnNewAssessment.Name = "btnNewAssessment";
            btnNewAssessment.Size = new Size(169, 56);
            btnNewAssessment.TabIndex = 0;
            btnNewAssessment.Text = "New Assessment";
            btnNewAssessment.UseVisualStyleBackColor = true;
            btnNewAssessment.Click += btnNewAssessment_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblHighCount);
            pnlMain.Controls.Add(lblAverageRisk);
            pnlMain.Controls.Add(lblHighRisk);
            pnlMain.Controls.Add(lblMediumCount);
            pnlMain.Controls.Add(lblTotalAssessments);
            pnlMain.Controls.Add(lblLowCount);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(782, 493);
            pnlMain.TabIndex = 2;
            // 
            // lblAverageRisk
            // 
            lblAverageRisk.AutoSize = true;
            lblAverageRisk.Location = new Point(534, 65);
            lblAverageRisk.Name = "lblAverageRisk";
            lblAverageRisk.Size = new Size(150, 20);
            lblAverageRisk.TabIndex = 2;
            lblAverageRisk.Text = "Average Risk Score: 0";
            // 
            // lblHighRisk
            // 
            lblHighRisk.AutoSize = true;
            lblHighRisk.Location = new Point(305, 65);
            lblHighRisk.Name = "lblHighRisk";
            lblHighRisk.Size = new Size(142, 20);
            lblHighRisk.TabIndex = 1;
            lblHighRisk.Text = "High Risk Projects: 0";
            // 
            // lblTotalAssessments
            // 
            lblTotalAssessments.AutoSize = true;
            lblTotalAssessments.Location = new Point(54, 65);
            lblTotalAssessments.Name = "lblTotalAssessments";
            lblTotalAssessments.Size = new Size(143, 20);
            lblTotalAssessments.TabIndex = 0;
            lblTotalAssessments.Text = "Total Assessments: 0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTop);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "D365 Project Risk Analyzer";
            Load += MainForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private Panel pnlMenu;
        private Button btnExit;
        private Button btnHistory;
        private Button btnNewAssessment;
        private Panel pnlMain;
        private Label lblAverageRisk;
        private Label lblHighRisk;
        private Label lblTotalAssessments;
        private Label lblHighCount;
        private Label lblMediumCount;
        private Label lblLowCount;
    }
}