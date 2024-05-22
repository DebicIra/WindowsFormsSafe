using CrystalDecisions.ReportAppServer.DataDefModel;
using FastReport;
using FastReport.Data;
using FastReport.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        private void employeeReport()
        {
            //report1.Design();            
            report1.Load(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Content/reports/" + "employee.frx");
            report1.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.universityHRDataSet.vacation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.governmentAwards". При необходимости она может быть перемещена или удалена.
            this.governmentAwardsTableAdapter.Fill(this.universityHRDataSet.governmentAwards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employeeDiscipline". При необходимости она может быть перемещена или удалена.
            this.employeeDisciplineTableAdapter.Fill(this.universityHRDataSet.employeeDiscipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.universityHRDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.universityHRDataSet.document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.universityHRDataSet.discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "universityHRDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.universityHRDataSet.department);

        }

        private void сотрудникиДисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm7 = new FormEmployeeDiscipline();
            myForm7.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
        }

        private void документыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocument myForm3 = new FormDocument();
            myForm3.Show();
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment myForm4 = new FormDepartment();
            myForm4.Show();
        }

        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiscipline myForm5 = new FormDiscipline();
            myForm5.Show();
        }

        private void отпускаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm6 = new FormVocation();
            myForm6.Show();
        }

        private void госНаградыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm8 = new FormGovernentawards();
            myForm8.Show();
        }


        private void работаСХранимымиПроцедурамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm9 = new professorDepartmentProc();
            myForm9.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report1.Load(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Content/reports/" + "employee.frx");
            FastReport.Export.OoXML.Excel2007Export export = new FastReport.Export.OoXML.Excel2007Export();
            using (export)
            {
                if (export.ShowDialog())
                    export.Export(report1, @"result.xlsx");
            }
        }
    }
}
