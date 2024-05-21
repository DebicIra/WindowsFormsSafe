using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSafe
{
    public class procedureRunner
    {
        public static void Runner(DataGridView dgv, string procedureName, Dictionary<TextBox, string> parameters = null)
        {
            SqlConnection connection = new SqlConnection("user id=SUSLIK-PC\\кирилл;" +
                                       "password=;server=SUSLIK-PC\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=UniversityHR; " +
                                       "connection timeout=10");

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parameters != null )
            {
                foreach (var par in parameters)
                {
                    cmd.Parameters.AddWithValue(par.Value, par.Key.Text.ToString());
                }
            }
            try
            {
                dgv.Columns.Clear();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<string[]> data = new List<string[]>();
                    data.Add(new string[reader.FieldCount]);
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                        if (reader.GetName(i) == "id")
                        {
                            //dataGridView1.Columns["id"].Visible = false;
                            dgv.Columns[0].Visible = false;
                        }
                    }
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                data[data.Count - 1][i] = reader[i].ToString();
                            }
                        }
                        foreach (var s in data)
                            dgv.Rows.Add(s);
                    }                    
                }
            }
            catch
            {
                throw;
            }
            connection.Close();
        }
    }
}
