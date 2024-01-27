using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FruitSwap
{
    public partial class Highscores : Form
    {
        private readonly Main main;

        // Using a class for ease in structuring data
        public class HighscoreData
        {
            public string Name { get; set; }
            public int Score { get; set; }

            public HighscoreData(string name, int score)
            {
                Name = name;
                Score = score;
            }

            public override string ToString()
            {
                return $"{Name}: {Score}";
            }
        }

        List<string> highscores = new List<string>();

        public Highscores(Main mainform)
        {
            InitializeComponent();
            main = mainform;
            lbHighscores.DataSource = highscores;
        }

        // Database logic
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Clear any present data
            lbHighscores.DataSource = null;
            highscores.Clear();

            // Build DB Connection
            string connstr = "server=localhost;uid=root;pwd=;database=fruithighscore";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstr;
            conn.Open();

            // Insert new highscore into DB
            string sql = $"INSERT INTO highscores (name, score) VALUES (?name, ?score)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add("?name", MySqlDbType.Text).Value = txtName.Text;
            cmd.Parameters.Add("?score", MySqlDbType.Int64).Value = main.score;
            cmd.ExecuteNonQuery();
            btnSubmit.Enabled = false;

            // Get all highscores in DB
            sql = "SELECT * FROM highscores";
            cmd.CommandText = sql;
            MySqlDataReader reader = cmd.ExecuteReader();

            // Display data in listbox
            while (reader.Read())
            {
                highscores.Add(new HighscoreData((string)reader["name"], (int)reader["score"]).ToString());
            }

            lbHighscores.DataSource = highscores;
            conn.Close();
        }
    }
}
