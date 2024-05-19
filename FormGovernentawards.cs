﻿using System;
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
    }
}