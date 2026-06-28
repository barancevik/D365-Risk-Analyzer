using D365RiskAnalyzer.Data;
using D365RiskAnalyzer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D365RiskAnalyzer
{
    public partial class AssessmentForm : Form
    {
        public AssessmentForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProjectName.Text))
            {
                MessageBox.Show("Project Name is required!");
                return;
            }

            int score = 0;
            List<string> riskDetails = new List<string>();

            // GOVERNANCE
            if (!chkSponsor.Checked)
            {
                score += 25;
                riskDetails.Add("Executive Sponsor not assigned");
            }

            if (!chkScope.Checked)
            {
                score += 20;
                riskDetails.Add("Scope not defined");
            }

            if (!chkKeyUsers.Checked)
            {
                score += 15;
                riskDetails.Add("Key Users not assigned");
            }

            if (!chkSteering.Checked)
            {
                score += 15;
                riskDetails.Add("Steering Committee missing");
            }

            if (!chkPlan.Checked)
            {
                score += 10;
                riskDetails.Add("Project Plan not approved");
            }

            // DATA MIGRATION
            if (!chkDataClean.Checked)
            {
                score += 20;
                riskDetails.Add("Data not cleaned");
            }

            if (!chkLegacy.Checked)
            {
                score += 15;
                riskDetails.Add("Legacy system not analyzed");
            }

            if (!chkMigration.Checked)
            {
                score += 20;
                riskDetails.Add("Migration plan missing");
            }

            if (!chkTestMigration.Checked)
            {
                score += 15;
                riskDetails.Add("Migration not tested");
            }

            if (!chkDataOwners.Checked)
            {
                score += 10;
                riskDetails.Add("Data owners not defined");
            }

            // TESTING
            if (!chkUnitTest.Checked)
            {
                score += 15;
                riskDetails.Add("Unit testing missing");
            }

            if (!chkUAT.Checked)
            {
                score += 15;
                riskDetails.Add("UAT not completed");
            }

            if (!chkRegression.Checked)
            {
                score += 10;
                riskDetails.Add("Regression testing missing");
            }

            if (!chkDefect.Checked)
            {
                score += 10;
                riskDetails.Add("Defect management missing");
            }

            if (!chkTestEnv.Checked)
            {
                score += 10;
                riskDetails.Add("Test environment not ready");
            }

            // GO LIVE
            if (!chkCutover.Checked)
            {
                score += 20;
                riskDetails.Add("Cutover plan missing");
            }

            if (!chkSupport.Checked)
            {
                score += 15;
                riskDetails.Add("Support team not assigned");
            }

            if (!chkRollback.Checked)
            {
                score += 15;
                riskDetails.Add("Rollback plan missing");
            }

            if (!chkTraining.Checked)
            {
                score += 10;
                riskDetails.Add("Training not completed");
            }

            if (!chkGoLive.Checked)
            {
                score += 20;
                riskDetails.Add("Go-live readiness not confirmed");
            }

            // LEVEL
            string level;

            if (score <= 30) level = "LOW";
            else if (score <= 60) level = "MEDIUM";
            else level = "HIGH";

            MessageBox.Show($"Risk Score: {score}\nRisk Level: {level}");

            // DATABASE SAVE
            var assessment = new Assessment
            {
                CompanyName = txtCompanyName.Text,
                ProjectName = txtProjectName.Text,
                RiskScore = score,
                RiskLevel = level,
                CreatedDate = DateTime.Now
            };

            Database.SaveAssessment(assessment);

            // RESULT FORM
            var resultForm = new ResultForm(
                txtCompanyName.Text,
                txtProjectName.Text,
                score,
                level,
                riskDetails
            );

            resultForm.ShowDialog();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssessmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
