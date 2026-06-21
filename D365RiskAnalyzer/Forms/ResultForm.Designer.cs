namespace D365RiskAnalyzer
{
    partial class ResultForm
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
            lblCompany = new Label();
            lblProject = new Label();
            lblScore = new Label();
            lblLevel = new Label();
            lblAdvice = new Label();
            pnlResult = new Panel();
            btnExportPdf = new Button();
            btnClose4 = new Button();
            SuspendLayout();
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(29, 53);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(75, 20);
            lblCompany.TabIndex = 0;
            lblCompany.Text = "Company:";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(29, 116);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(58, 20);
            lblProject.TabIndex = 1;
            lblProject.Text = "Project:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(29, 179);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(79, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Risk Score:";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(29, 242);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(76, 20);
            lblLevel.TabIndex = 3;
            lblLevel.Text = "Risk Level:";
            // 
            // lblAdvice
            // 
            lblAdvice.AutoSize = true;
            lblAdvice.Location = new Point(29, 294);
            lblAdvice.Name = "lblAdvice";
            lblAdvice.Size = new Size(130, 20);
            lblAdvice.TabIndex = 4;
            lblAdvice.Text = "Recommendation:";
            // 
            // pnlResult
            // 
            pnlResult.Location = new Point(209, 53);
            pnlResult.Name = "pnlResult";
            pnlResult.Size = new Size(641, 261);
            pnlResult.TabIndex = 5;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportPdf.Location = new Point(686, 368);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(164, 49);
            btnExportPdf.TabIndex = 6;
            btnExportPdf.Text = "Export PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnClose4
            // 
            btnClose4.Location = new Point(29, 368);
            btnClose4.Name = "btnClose4";
            btnClose4.Size = new Size(94, 29);
            btnClose4.TabIndex = 7;
            btnClose4.Text = "CLOSE";
            btnClose4.UseVisualStyleBackColor = true;
            btnClose4.Click += BtnClose_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(862, 446);
            Controls.Add(btnClose4);
            Controls.Add(btnExportPdf);
            Controls.Add(pnlResult);
            Controls.Add(lblAdvice);
            Controls.Add(lblLevel);
            Controls.Add(lblScore);
            Controls.Add(lblProject);
            Controls.Add(lblCompany);
            Name = "ResultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Risk Analysis Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompany;
        private Label lblProject;
        private Label lblScore;
        private Label lblLevel;
        private Label lblAdvice;
        private Panel pnlResult;
        private Button btnExportPdf;
        private Button btnClose4;
    }
}