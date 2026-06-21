using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using System.IO;
using D365RiskAnalyzer.Models;
using System.Data;

namespace D365RiskAnalyzer.Data
{
    public class Database
    {

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection("Data Source=app.db");
        }

        public static void Initialize()
        {
            using var connection = GetConnection();
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS Assessments (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            CompanyName TEXT,
            ProjectName TEXT,
            RiskScore INTEGER,
            RiskLevel TEXT,
            CreatedDate TEXT
            );
            ";

            command.ExecuteNonQuery();


        }


        public static void SaveAssessment(Assessment a)
        {
            using var connection = GetConnection();
            connection.Open();

            var command = connection.CreateCommand();

            command.CommandText =
            @"
            INSERT INTO Assessments (CompanyName, ProjectName, RiskScore, RiskLevel, CreatedDate)
            VALUES ($company, $project, $score, $level, $date)
            ";

            command.Parameters.AddWithValue("$company", a.CompanyName);
            command.Parameters.AddWithValue("$project", a.ProjectName);
            command.Parameters.AddWithValue("$score", a.RiskScore);
            command.Parameters.AddWithValue("$level", a.RiskLevel);
            command.Parameters.AddWithValue("$date", a.CreatedDate.ToString("yyyy-MM-dd HH:mm"));

            command.ExecuteNonQuery();
        }



        public static DataTable GetAssessments()
        {
            using var connection = GetConnection();
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Assessments ORDER BY Id DESC";

            var reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }




        public static int GetTotalAssessments()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Assessments";

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static int GetHighCount()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM Assessments WHERE RiskLevel = 'HIGH'";

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static double GetAverageRisk()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT AVG(RiskScore) FROM Assessments";

            var result = cmd.ExecuteScalar();

            return result == DBNull.Value ? 0 : Convert.ToDouble(result);
        }


        public static void DeleteAssessment(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Assessments WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }




    }
}

