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
    public partial class FormEmployeeDiscipline : Form
    {
        public FormEmployeeDiscipline()
        {
            InitializeComponent();
        }

        private void FormEmployeeDiscipline_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.universityHRDataSet.discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employeeDiscipline". При необходимости она может быть перемещена или удалена.
            this.employeeDisciplineTableAdapter.Fill(this.universityHRDataSet.employeeDiscipline);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeDisciplineBindingSource.EndEdit();
            this.employeeDisciplineTableAdapter.Update(this.universityHRDataSet.employeeDiscipline);
        }
    }
}
