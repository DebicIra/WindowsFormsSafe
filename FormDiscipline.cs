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
    public partial class FormDiscipline : Form
    {
        public FormDiscipline()
        {
            InitializeComponent();
        }

        private void FormDiscipline_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.universityHRDataSet.discipline);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplineBindingSource.EndEdit();
            this.disciplineTableAdapter.Update(this.universityHRDataSet.discipline);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = this.disciplineBindingSource.Find("name", textBox1.Text);
            if (i == -1)
            {
                DataView dv = new DataView(this.universityHRDataSet.discipline as DataTable);
                dv.RowFilter = string.Format("name LIKE '{0}*'", this.textBox1.Text);
                if (dv.Count != 0)
                {
                    i = this.disciplineBindingSource.Find("name", dv[0]["name"]);
                }
                dv.Dispose();
                this.disciplineBindingSource.Position = i;
            }
            this.disciplineBindingSource.Position = i;
        }
    }
}
