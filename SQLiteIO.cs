using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LogPlayerDB
{
    internal class SQLiteIO
    {
        public SQLiteIO(string _DBName,
           Action<object> output = null,
           string _command = "select 'Успешно';")
        {
            string _source = "Data Source=" + _DBName + ";";
            string _cache = "Cache=Shared;";
            string _mode = "Mode=ReadWriteCreate;";
            SQLiteConnection myConnection = new SQLiteConnection(_source + _cache + _mode);
            SQLiteCommand myQuery = new SQLiteCommand(_command, myConnection);
            myConnection.Open();
            try { 
            var dr = myQuery.ExecuteReader();
            string result = string.Empty;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var Name = dr.GetString(1);
                    var Age = dr.GetInt32(2);

                    result += Name.ToString() + " \t " + Age.ToString() + "\n";
                }
            }
            output?.Invoke(result);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
