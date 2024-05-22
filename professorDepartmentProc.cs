using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsSafe
{
    public partial class professorDepartmentProc : Form
    {
        SqlConnection connection = new SqlConnection("user id=SUSLIK-PC\\кирилл;" +
                                       "password=;server=SUSLIK-PC\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=UniversityHR; " +
                                       "connection timeout=10");       
        public professorDepartmentProc()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox1] = "@depName",
            };
            if (parametrs.First().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureONE", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void professorDepartmentProc_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox2] = "@depName",
            };
            if (parametrs.First().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureTWO", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox3] = "@depName",
                [textBox4] = "@gradeName",
            };
            if (parametrs.First().Key.Text != "" && parametrs.Last().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureTHREE", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
                parametrs.Last().Key.Text = "Введите значение!";
                parametrs.Last().Key.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            procedureRunner.Runner(dataGridView1, "ProcedureFOUR");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox5] = "@docType",
            };
            if (parametrs.First().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureFIVE", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox6] = "@discName",
            };
            if (parametrs.First().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureSIX", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var parametrs = new Dictionary<TextBox, string>()
            {
                [textBox7] = "@docType",
            };
            if (parametrs.First().Key.Text != "")
            {
                procedureRunner.Runner(dataGridView1, "ProcedureSEVEN", parametrs);
            }
            else
            {
                parametrs.First().Key.Text = "Введите значение!";
                parametrs.First().Key.ForeColor = Color.Red;
            }
        }
        private void RemoveText(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text == "Введите значение!")
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dgvTransformer.ExportToExcel(dataGridView1);
        }
    }
}
