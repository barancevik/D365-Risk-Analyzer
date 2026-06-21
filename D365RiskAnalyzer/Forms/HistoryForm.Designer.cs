namespace D365RiskAnalyzer
{
    partial class HistoryForm
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
            dgvHistory = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            cmbRiskFilter = new ComboBox();
            pnlBottom = new Panel();
            btnClose = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(12, 138);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(787, 368);
            dgvHistory.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(324, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(641, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 46);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbRiskFilter
            // 
            cmbRiskFilter.FormattingEnabled = true;
            cmbRiskFilter.Items.AddRange(new object[] { "ALL", "LOW", "MEDIUM", "HIGH" });
            cmbRiskFilter.Location = new Point(12, 28);
            cmbRiskFilter.Name = "cmbRiskFilter";
            cmbRiskFilter.Size = new Size(243, 28);
            cmbRiskFilter.TabIndex = 3;
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(btnDelete);
            pnlBottom.Controls.Add(btnClose);
            pnlBottom.Controls.Add(btnRefresh);
            pnlBottom.Location = new Point(12, 526);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(787, 52);
            pnlBottom.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(653, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(134, 52);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 52);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(161, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 52);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 590);
            Controls.Add(pnlBottom);
            Controls.Add(cmbRiskFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvHistory);
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHistory;
        private TextBox txtSearch;
        private Button btnSearch;
        private ComboBox cmbRiskFilter;
        private Panel pnlBottom;
        private Button btnClose;
        private Button btnRefresh;
        private Button btnDelete;
    }
}