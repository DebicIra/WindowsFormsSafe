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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.universityHRDataSet.department);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = this.departmentBindingSource.Find("name", textBox1.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.universityHRDataSet.department as DataTable);
                dv.RowFilter = string.Format("name LIKE '{0}*'", this.textBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.departmentBindingSource.Find("name", dv[0]["name"]);
                }
                dv.Dispose();
                this.departmentBindingSource.Position = i;
            }
            this.departmentBindingSource.Position = i;
        }
    }
}
