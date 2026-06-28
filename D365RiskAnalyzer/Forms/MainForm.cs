using D365RiskAnalyzer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace D365RiskAnalyzer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnNewAssessment_Click(object sender, EventArgs e)
        {

            AssessmentForm form = new AssessmentForm();
            form.ShowDialog();



        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm();
            form.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
        private void LoadDashboard()
        {
            lblTotalAssessments.Text =
        "Total: " + Database.GetTotalAssessments();

            lblHighRisk.Text =
                "High Risk: " + Database.GetHighCount();

            lblAverageRisk.Text =
                "Avg Risk: " + Database.GetAverageRisk();
        }
    }
}
