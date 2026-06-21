namespace D365RiskAnalyzer
{
    partial class AssessmentForm
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
            chkSponsor = new CheckBox();
            chkScope = new CheckBox();
            chkKeyUsers = new CheckBox();
            chkSteering = new CheckBox();
            chkPlan = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            chkDataOwners = new CheckBox();
            chkTestMigration = new CheckBox();
            chkMigration = new CheckBox();
            chkLegacy = new CheckBox();
            chkDataClean = new CheckBox();
            label3 = new Label();
            chkTestEnv = new CheckBox();
            chkDefect = new CheckBox();
            chkRegression = new CheckBox();
            chkUAT = new CheckBox();
            chkUnitTest = new CheckBox();
            label4 = new Label();
            chkGoLive = new CheckBox();
            chkTraining = new CheckBox();
            chkRollback = new CheckBox();
            chkSupport = new CheckBox();
            chkCutover = new CheckBox();
            btnCalculate = new Button();
            txtCompanyName = new TextBox();
            txtProjectName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnClose2 = new Button();
            SuspendLayout();
            // 
            // chkSponsor
            // 
            chkSponsor.AutoSize = true;
            chkSponsor.Location = new Point(36, 73);
            chkSponsor.Name = "chkSponsor";
            chkSponsor.Size = new Size(215, 24);
            chkSponsor.TabIndex = 0;
            chkSponsor.Text = "Executive Sponsor Assigned";
            chkSponsor.UseVisualStyleBackColor = true;
            // 
            // chkScope
            // 
            chkScope.AutoSize = true;
            chkScope.Location = new Point(36, 121);
            chkScope.Name = "chkScope";
            chkScope.Size = new Size(129, 24);
            chkScope.TabIndex = 1;
            chkScope.Text = "Scope Defined";
            chkScope.UseVisualStyleBackColor = true;
            // 
            // chkKeyUsers
            // 
            chkKeyUsers.AutoSize = true;
            chkKeyUsers.Location = new Point(36, 169);
            chkKeyUsers.Name = "chkKeyUsers";
            chkKeyUsers.Size = new Size(158, 24);
            chkKeyUsers.TabIndex = 2;
            chkKeyUsers.Text = "Key Users Assigned";
            chkKeyUsers.UseVisualStyleBackColor = true;
            // 
            // chkSteering
            // 
            chkSteering.AutoSize = true;
            chkSteering.Location = new Point(36, 217);
            chkSteering.Name = "chkSteering";
            chkSteering.Size = new Size(204, 24);
            chkSteering.TabIndex = 3;
            chkSteering.Text = "Steering Committee Exists";
            chkSteering.UseVisualStyleBackColor = true;
            // 
            // chkPlan
            // 
            chkPlan.AutoSize = true;
            chkPlan.Location = new Point(36, 265);
            chkPlan.Name = "chkPlan";
            chkPlan.Size = new Size(179, 24);
            chkPlan.TabIndex = 4;
            chkPlan.Text = "Project Plan Approved";
            chkPlan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 5;
            label1.Text = "Governance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(271, 30);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 11;
            label2.Text = "Data Migration";
            // 
            // chkDataOwners
            // 
            chkDataOwners.AutoSize = true;
            chkDataOwners.Location = new Point(271, 265);
            chkDataOwners.Name = "chkDataOwners";
            chkDataOwners.Size = new Size(173, 24);
            chkDataOwners.TabIndex = 10;
            chkDataOwners.Text = "Data Owners Defined";
            chkDataOwners.UseVisualStyleBackColor = true;
            // 
            // chkTestMigration
            // 
            chkTestMigration.AutoSize = true;
            chkTestMigration.Location = new Point(271, 217);
            chkTestMigration.Name = "chkTestMigration";
            chkTestMigration.Size = new Size(166, 24);
            chkTestMigration.TabIndex = 9;
            chkTestMigration.Text = "Test Migration Done";
            chkTestMigration.UseVisualStyleBackColor = true;
            // 
            // chkMigration
            // 
            chkMigration.AutoSize = true;
            chkMigration.Location = new Point(271, 169);
            chkMigration.Name = "chkMigration";
            chkMigration.Size = new Size(200, 24);
            chkMigration.TabIndex = 8;
            chkMigration.Text = "Migration Strategy Ready";
            chkMigration.UseVisualStyleBackColor = true;
            // 
            // chkLegacy
            // 
            chkLegacy.AutoSize = true;
            chkLegacy.Location = new Point(271, 121);
            chkLegacy.Name = "chkLegacy";
            chkLegacy.Size = new Size(193, 24);
            chkLegacy.TabIndex = 7;
            chkLegacy.Text = "Legacy System Analyzed";
            chkLegacy.UseVisualStyleBackColor = true;
            // 
            // chkDataClean
            // 
            chkDataClean.AutoSize = true;
            chkDataClean.Location = new Point(271, 73);
            chkDataClean.Name = "chkDataClean";
            chkDataClean.Size = new Size(171, 24);
            chkDataClean.TabIndex = 6;
            chkDataClean.Text = "Data Cleansing Done";
            chkDataClean.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(511, 30);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 17;
            label3.Text = "Testing";
            // 
            // chkTestEnv
            // 
            chkTestEnv.AutoSize = true;
            chkTestEnv.Location = new Point(511, 265);
            chkTestEnv.Name = "chkTestEnv";
            chkTestEnv.Size = new Size(189, 24);
            chkTestEnv.TabIndex = 16;
            chkTestEnv.Text = "Test Environment Ready";
            chkTestEnv.UseVisualStyleBackColor = true;
            // 
            // chkDefect
            // 
            chkDefect.AutoSize = true;
            chkDefect.Location = new Point(511, 217);
            chkDefect.Name = "chkDefect";
            chkDefect.Size = new Size(185, 24);
            chkDefect.TabIndex = 15;
            chkDefect.Text = "Defect Process Defined";
            chkDefect.UseVisualStyleBackColor = true;
            // 
            // chkRegression
            // 
            chkRegression.AutoSize = true;
            chkRegression.Location = new Point(511, 169);
            chkRegression.Name = "chkRegression";
            chkRegression.Size = new Size(199, 24);
            chkRegression.TabIndex = 14;
            chkRegression.Text = "Regression Testing Ready";
            chkRegression.UseVisualStyleBackColor = true;
            // 
            // chkUAT
            // 
            chkUAT.AutoSize = true;
            chkUAT.Location = new Point(511, 121);
            chkUAT.Name = "chkUAT";
            chkUAT.Size = new Size(135, 24);
            chkUAT.TabIndex = 13;
            chkUAT.Text = "UAT Plan Ready";
            chkUAT.UseVisualStyleBackColor = true;
            // 
            // chkUnitTest
            // 
            chkUnitTest.AutoSize = true;
            chkUnitTest.Location = new Point(511, 73);
            chkUnitTest.Name = "chkUnitTest";
            chkUnitTest.Size = new Size(165, 24);
            chkUnitTest.TabIndex = 12;
            chkUnitTest.Text = "Unit Test Plan Ready";
            chkUnitTest.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(749, 30);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 23;
            label4.Text = "Go-Live";
            // 
            // chkGoLive
            // 
            chkGoLive.AutoSize = true;
            chkGoLive.Location = new Point(749, 265);
            chkGoLive.Name = "chkGoLive";
            chkGoLive.Size = new Size(189, 24);
            chkGoLive.TabIndex = 22;
            chkGoLive.Text = "Go-Live Checklist Ready";
            chkGoLive.UseVisualStyleBackColor = true;
            // 
            // chkTraining
            // 
            chkTraining.AutoSize = true;
            chkTraining.Location = new Point(749, 217);
            chkTraining.Name = "chkTraining";
            chkTraining.Size = new Size(162, 24);
            chkTraining.TabIndex = 21;
            chkTraining.Text = "Training Completed";
            chkTraining.UseVisualStyleBackColor = true;
            // 
            // chkRollback
            // 
            chkRollback.AutoSize = true;
            chkRollback.Location = new Point(749, 169);
            chkRollback.Name = "chkRollback";
            chkRollback.Size = new Size(160, 24);
            chkRollback.TabIndex = 20;
            chkRollback.Text = "Rollback Plan Exists";
            chkRollback.UseVisualStyleBackColor = true;
            // 
            // chkSupport
            // 
            chkSupport.AutoSize = true;
            chkSupport.Location = new Point(749, 121);
            chkSupport.Name = "chkSupport";
            chkSupport.Size = new Size(188, 24);
            chkSupport.TabIndex = 19;
            chkSupport.Text = "Support Team Assigned";
            chkSupport.UseVisualStyleBackColor = true;
            // 
            // chkCutover
            // 
            chkCutover.AutoSize = true;
            chkCutover.Location = new Point(749, 73);
            chkCutover.Name = "chkCutover";
            chkCutover.Size = new Size(159, 24);
            chkCutover.TabIndex = 18;
            chkCutover.Text = "Cutover Plan Ready";
            chkCutover.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCalculate.Location = new Point(749, 396);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(189, 82);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Calculate Risk";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(171, 372);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(293, 27);
            txtCompanyName.TabIndex = 25;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(171, 427);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(293, 27);
            txtProjectName.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 372);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 27;
            label5.Text = "Company Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 427);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 28;
            label6.Text = "Project Name:";
            // 
            // btnClose2
            // 
            btnClose2.Location = new Point(36, 476);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(94, 29);
            btnClose2.TabIndex = 29;
            btnClose2.Text = "CLOSE";
            btnClose2.UseVisualStyleBackColor = true;
            btnClose2.Click += btnExit_Click;
            // 
            // AssessmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 517);
            Controls.Add(btnClose2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtProjectName);
            Controls.Add(txtCompanyName);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(chkGoLive);
            Controls.Add(chkTraining);
            Controls.Add(chkRollback);
            Controls.Add(chkSupport);
            Controls.Add(chkCutover);
            Controls.Add(label3);
            Controls.Add(chkTestEnv);
            Controls.Add(chkDefect);
            Controls.Add(chkRegression);
            Controls.Add(chkUAT);
            Controls.Add(chkUnitTest);
            Controls.Add(label2);
            Controls.Add(chkDataOwners);
            Controls.Add(chkTestMigration);
            Controls.Add(chkMigration);
            Controls.Add(chkLegacy);
            Controls.Add(chkDataClean);
            Controls.Add(label1);
            Controls.Add(chkPlan);
            Controls.Add(chkSteering);
            Controls.Add(chkKeyUsers);
            Controls.Add(chkScope);
            Controls.Add(chkSponsor);
            Name = "AssessmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Project Assessment";
            Load += AssessmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkSponsor;
        private CheckBox chkScope;
        private CheckBox chkKeyUsers;
        private CheckBox chkSteering;
        private CheckBox chkPlan;
        private Label label1;
        private Label label2;
        private CheckBox chkDataOwners;
        private CheckBox chkTestMigration;
        private CheckBox chkMigration;
        private CheckBox chkLegacy;
        private CheckBox chkDataClean;
        private Label label3;
        private CheckBox chkTestEnv;
        private CheckBox chkDefect;
        private CheckBox chkRegression;
        private CheckBox chkUAT;
        private CheckBox chkUnitTest;
        private Label label4;
        private CheckBox chkGoLive;
        private CheckBox chkTraining;
        private CheckBox chkRollback;
        private CheckBox chkSupport;
        private CheckBox chkCutover;
        private Button btnCalculate;
        private TextBox txtCompanyName;
        private TextBox txtProjectName;
        private Label label5;
        private Label label6;
        private Button btnClose2;
    }
}