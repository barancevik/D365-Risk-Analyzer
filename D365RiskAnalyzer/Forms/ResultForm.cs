using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.IO;



namespace D365RiskAnalyzer
{
    public partial class ResultForm : Form
    {
        List<string> riskDetails;

        public ResultForm(string company, string project, int score, string level, List<string> riskDetails)
        {
            InitializeComponent();

            this.riskDetails = riskDetails;

            lblCompany.Text = "Company: " + company;
            lblProject.Text = "Project: " + project;
            lblScore.Text = "Risk Score: " + score.ToString();
            lblLevel.Text = "Risk Level: " + level;

            if (level == "LOW")
            {
                lblLevel.ForeColor = Color.Green;
                lblAdvice.Text = "Project is SAFE. You can proceed normally.";
            }
            else if (level == "MEDIUM")
            {
                lblLevel.ForeColor = Color.Orange;
                lblAdvice.Text = "Moderate risks detected. Review key areas.";
            }
            else
            {
                lblLevel.ForeColor = Color.Red;
                lblAdvice.Text = "HIGH RISK! Strong mitigation required before go-live.";
            }

            this.BackColor = Color.WhiteSmoke;
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);

            var fontTitle = new XFont("Arial", 20);
            var font = new XFont("Arial", 12);

            int y = 40;

            // BAŞLIK
            gfx.DrawString("D365 Risk Assessment Report", fontTitle, XBrushes.Black,
                new XRect(0, y, page.Width, page.Height),
                XStringFormats.TopCenter);

            y += 60;

            // COMPANY
            gfx.DrawString(lblCompany.Text, font, XBrushes.Black, 40, y); y += 30;

            // PROJECT
            gfx.DrawString(lblProject.Text, font, XBrushes.Black, 40, y); y += 30;

            // SCORE
            gfx.DrawString(lblScore.Text, font, XBrushes.Black, 40, y); y += 30;

            // LEVEL
            gfx.DrawString(lblLevel.Text, font, XBrushes.Black, 40, y); y += 30;

            // ADVICE
            gfx.DrawString("Recommendation:", font, XBrushes.Black, 40, y); y += 20;
            gfx.DrawString(lblAdvice.Text, font, XBrushes.Black, 40, y); y += 40;

            // RISK BREAKDOWN
            gfx.DrawString("RISK BREAKDOWN:", font, XBrushes.Black, 40, y);
            y += 25;

            // 🔥 BURASI ASIL YENİ KISIM
            if (riskDetails != null && riskDetails.Count > 0)
            {
                foreach (var item in riskDetails)
                {
                    gfx.DrawString("- " + item, font, XBrushes.Black, 40, y);
                    y += 20;
                }
            }
            else
            {
                gfx.DrawString("No risks detected.", font, XBrushes.Black, 40, y);
                y += 20;
            }

            // DOSYAYI KAYDET
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "D365_Risk_Report.pdf"
            );

            document.Save(path);

            MessageBox.Show("PDF created successfully!\n" + path);


            document.Save(path);

            MessageBox.Show("PDF created successfully!\n" + path);


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    




    }
}
