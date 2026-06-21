using System;
using System.Windows.Forms;
using D365RiskAnalyzer.Data;


namespace D365RiskAnalyzer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Database.Initialize();
            Application.Run(new MainForm());


        }
    }
}