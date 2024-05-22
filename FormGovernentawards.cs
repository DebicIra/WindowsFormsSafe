using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSafe
{
    public partial class FormGovernentawards : Form
    {
        public FormGovernentawards()
        {
            InitializeComponent();
        }

        private void FormGovernentawards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.governmentAwards". При необходимости она может быть перемещена или удалена.
            this.governmentAwardsTableAdapter.Fill(this.universityHRDataSet.governmentAwards);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.governmentAwardsBindingSource.EndEdit();
            this.governmentAwardsTableAdapter.Update(this.universityHRDataSet.governmentAwards);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = this.governmentAwardsBindingSource.Find("name", textBox1.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.universityHRDataSet.governmentAwards as DataTable);
                dv.RowFilter = string.Format("name LIKE '{0}*'", this.textBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.governmentAwardsBindingSource.Find("name", dv[0]["name"]);
                }
                dv.Dispose();
                this.governmentAwardsBindingSource.Position = i;
            }
            this.governmentAwardsBindingSource.Position = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.governmentAwardsBindingSource.Filter = "awardDate='" + textBox2.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.governmentAwardsBindingSource.Filter = "";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgvTransformer.ExportToExcel(dataGridView1);
        }
    }
}
