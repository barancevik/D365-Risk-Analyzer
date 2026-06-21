using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using D365RiskAnalyzer.Data;

namespace D365RiskAnalyzer
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            cmbRiskFilter.SelectedIndex = 0; // ALL

            LoadData();



        }

        private void LoadData()
        {
            dgvHistory.DataSource = Database.GetAssessments();

            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string filter = cmbRiskFilter.SelectedItem.ToString();
            string search = txtSearch.Text.ToLower();

            DataTable data = Database.GetAssessments();

            // 🔴 Risk filtreleme
            if (filter != "ALL")
            {
                data = FilterByRisk(data, filter);
            }

            // 🔍 Company search
            if (!string.IsNullOrWhiteSpace(search))
            {
                data = SearchByCompany(data, search);
            }

            dgvHistory.DataSource = data;


        }


        private DataTable FilterByRisk(DataTable dt, string level)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"RiskLevel = '{level}'";
            return dv.ToTable();
        }

        private DataTable SearchByCompany(DataTable dt, string text)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"CompanyName LIKE '%{text}%'";
            return dv.ToTable();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtSearch.Clear();
            cmbRiskFilter.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHistory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row!");
                return;
            }

            var row = dgvHistory.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells["Id"].Value);

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                Database.DeleteAssessment(id);

                MessageBox.Show("Deleted successfully!");

                LoadData(); // grid'i yenile
            }
        }
    }
}
