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
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
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
            //sda = new SqlDataAdapter("select * from department", myConnection);
            //var dtDep = new DataTable();
            //sda.Fill(dtDep);


            //DataGridViewComboBoxColumn colFilterType = new DataGridViewComboBoxColumn();
            //colFilterType.HeaderText = "Bank";
            //colFilterType.DataSource = dtDep;
            //colFilterType.ValueMember = "id";
            //colFilterType.DataPropertyName = "id";
            //colFilterType.DisplayMember = "name";
            //colFilterType.ValueType = typeof(int);
            //dataGridView1.Columns.Add(colFilterType);

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {


            //        DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            //        comboBoxCell.DataSource = dtDep; // Установите DataSource вашего DataTable
            //        comboBoxCell.ValueMember = "id"; // Укажите колонку, которая будет использоваться для Value
            //        comboBoxCell.DisplayMember = "name"; // Укажите колонку, которая будет отображаться в комбобоксе
            //        row.Cells[8] = comboBoxCell;
            //        //comboBoxCell.ReadOnly = true;

            //    }
            //}
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.employeeTableAdapter.Update(this.universityHRDataSet.employee);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int i = this.employeeBindingSource.Find("fullname", textBox1.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.universityHRDataSet.employee as DataTable);
                dv.RowFilter = string.Format("fullname LIKE '{0}*'", this.textBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.employeeBindingSource.Find("fullname", dv[0]["fullname"]);
                }
                dv.Dispose();
                this.employeeBindingSource.Position = i;
            }
            this.employeeBindingSource.Position = i;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.employeeBindingSource.Filter = "degree='" + textBox2.Text + "'";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.employeeBindingSource.Filter = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (textBox2.Text == "Фильтр по степени")
            {
                textBox2.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
                textBox2.Text = "Фильтр по степени";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            RemoveText(sender, e);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            AddText(sender, e);
        }
    }
}
