using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Linq.Expressions;

namespace LogPlayerDB
{
    public partial class Form1 : Form
    {
        Action<object> output;
        string my_query;
        string name="";
        int age=1;
        public Form1() 
        {

            InitializeComponent();
            my_query = "CREATE TABLE IF NOT EXISTS Charasters (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                              "Name TEXT(1, 15) UNIQUE NOT NULL," +
                              "Age INTEGER(0, 150) NOT NULL CHECK(Age > 0));";
            output = getOutput;
            SQLiteIO test = new SQLiteIO("Charaster.db", output, my_query);
        }
        private void getOutput(object _text)
        {
            l_output.Text = _text.ToString();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {   
            Regex rName = new Regex(@"((\s|^)([A-Z|a-z]|[А-Я|а-я])+\D(\s|$))");
            Regex rAge = new Regex(@"(\d{1,3})");
            MatchCollection matchFindName = rName.Matches(NameBox.Text);
            MatchCollection matchFindAge = rAge.Matches(AgeBox.Text);
            name = matchFindName[0].Value;
            try
            {
                name = matchFindName[0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Имя неуказанно или указано неверно");
                name = @"<<none>>";
            }
            age = int.Parse(matchFindAge[0].Value);
            my_query = "INSERT INTO Charasters(Name,Age) VALUES('" + name.ToString() + "','" + age.ToString() + "');" +
                       "SELECT * FROM Charasters;";
            output = getOutput;
            SQLiteIO test = new SQLiteIO("Charaster.db", output, my_query);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            my_query = "DELETE FROM Charasters;";
            output = getOutput;
            SQLiteIO test = new SQLiteIO("Charaster.db", output, my_query);
        }
    }
}
