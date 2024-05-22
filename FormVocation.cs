using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsSafe
{
    public partial class FormVocation : Form
    {
        public FormVocation()
        {
            InitializeComponent();
        }

        private void FormVocation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.universityHRDataSet.vacation);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacationBindingSource.EndEdit();
            this.vacationTableAdapter.Update(this.universityHRDataSet.vacation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vacationBindingSource.Filter = "vacationEndDate='" + textBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.vacationBindingSource.Filter = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgvTransformer.ExportToExcel(dataGridView1);
        }
    }
}
