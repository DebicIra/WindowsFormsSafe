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
    public partial class FormDocument : Form
    {
        public FormDocument()
        {
            InitializeComponent();
        }

        private void FormDocument_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.universityHRDataSet.document);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentBindingSource.EndEdit();
            this.documentTableAdapter.Update(this.universityHRDataSet.document);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = this.documentBindingSource.Find("type", textBox1.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.universityHRDataSet.document as DataTable);
                dv.RowFilter = string.Format("type LIKE '{0}*'", this.textBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.documentBindingSource.Find("type", dv[0]["type"]);
                }
                dv.Dispose();
                this.documentBindingSource.Position = i;
            }
            this.documentBindingSource.Position = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documentBindingSource.Filter = "type='" + textBox2.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.documentBindingSource.Filter = "";
        }
    }
}
