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
    }
}
