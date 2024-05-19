using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSafe
{
    public partial class Form2 : Form
    {
        SqlConnection myConnection = new SqlConnection("user id=SUSLIK-PC\\кирилл;" +
                                       "password=;server=SUSLIK-PC\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=UniversityHR; " +
                                       "connection timeout=10");
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.universityHRDataSet.department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.employeeTableAdapter.Update(this.universityHRDataSet.employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            //dt = dataGridView1.DataSource as DataTable;
            //ds.Tables.Add(dt);
            //var da = new DataAdapter;

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            sda = new SqlDataAdapter("select * from department", myConnection);
            var dtDep = new DataTable();
            sda.Fill(dtDep);


            //DataGridViewComboBoxColumn colFilterType = new DataGridViewComboBoxColumn();
            //colFilterType.HeaderText = "Bank";
            //colFilterType.DataSource = dtDep;
            //colFilterType.ValueMember = "id";
            //colFilterType.DataPropertyName = "id";
            //colFilterType.DisplayMember = "name";
            //colFilterType.ValueType = typeof(int);
            //dataGridView1.Columns.Add(colFilterType);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {


                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                    comboBoxCell.DataSource = dtDep; // Установите DataSource вашего DataTable
                    comboBoxCell.ValueMember = "id"; // Укажите колонку, которая будет использоваться для Value
                    comboBoxCell.DisplayMember = "name"; // Укажите колонку, которая будет отображаться в комбобоксе
                    row.Cells[8] = comboBoxCell;
                    //comboBoxCell.ReadOnly = true;

                }
            }
        }
    }
}
