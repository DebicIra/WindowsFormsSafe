namespace WindowsFormsSafe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityHRDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityHRDataSet = new WindowsFormsSafe.UniversityHRDataSet();
            this.departmentTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.departmentTableAdapter();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.disciplineTableAdapter();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.documentTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.employeeTableAdapter();
            this.employeeDisciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDisciplineTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.employeeDisciplineTableAdapter();
            this.governmentAwardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.governmentAwardsTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.governmentAwardsTableAdapter();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new WindowsFormsSafe.UniversityHRDataSetTableAdapters.vacationTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отпускаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиДисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.госНаградыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСХранимымиПроцедурамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1 = new FastReport.Report();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityHRDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityHRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDisciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.governmentAwardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // universityHRDataSetBindingSource
            // 
            this.universityHRDataSetBindingSource.DataSource = this.universityHRDataSet;
            this.universityHRDataSetBindingSource.Position = 0;
            // 
            // universityHRDataSet
            // 
            this.universityHRDataSet.DataSetName = "UniversityHRDataSet";
            this.universityHRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "discipline";
            this.disciplineBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "document";
            this.documentBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDisciplineBindingSource
            // 
            this.employeeDisciplineBindingSource.DataMember = "employeeDiscipline";
            this.employeeDisciplineBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // employeeDisciplineTableAdapter
            // 
            this.employeeDisciplineTableAdapter.ClearBeforeFill = true;
            // 
            // governmentAwardsBindingSource
            // 
            this.governmentAwardsBindingSource.DataMember = "governmentAwards";
            this.governmentAwardsBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // governmentAwardsTableAdapter
            // 
            this.governmentAwardsTableAdapter.ClearBeforeFill = true;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "vacation";
            this.vacationBindingSource.DataSource = this.universityHRDataSetBindingSource;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem,
            this.работаСХранимымиПроцедурамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.кафедрыToolStripMenuItem,
            this.дисциплиныToolStripMenuItem,
            this.отпускаToolStripMenuItem,
            this.сотрудникиДисциплиныToolStripMenuItem,
            this.госНаградыToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.документыToolStripMenuItem.Text = "Документы";
            this.документыToolStripMenuItem.Click += new System.EventHandler(this.документыToolStripMenuItem_Click);
            // 
            // кафедрыToolStripMenuItem
            // 
            this.кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            this.кафедрыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.кафедрыToolStripMenuItem.Text = "Кафедры";
            this.кафедрыToolStripMenuItem.Click += new System.EventHandler(this.кафедрыToolStripMenuItem_Click);
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            this.дисциплиныToolStripMenuItem.Click += new System.EventHandler(this.дисциплиныToolStripMenuItem_Click);
            // 
            // отпускаToolStripMenuItem
            // 
            this.отпускаToolStripMenuItem.Name = "отпускаToolStripMenuItem";
            this.отпускаToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.отпускаToolStripMenuItem.Text = "Отпуска";
            this.отпускаToolStripMenuItem.Click += new System.EventHandler(this.отпускаToolStripMenuItem_Click);
            // 
            // сотрудникиДисциплиныToolStripMenuItem
            // 
            this.сотрудникиДисциплиныToolStripMenuItem.Name = "сотрудникиДисциплиныToolStripMenuItem";
            this.сотрудникиДисциплиныToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.сотрудникиДисциплиныToolStripMenuItem.Text = "Сотрудники-Дисциплины";
            this.сотрудникиДисциплиныToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиДисциплиныToolStripMenuItem_Click);
            // 
            // госНаградыToolStripMenuItem
            // 
            this.госНаградыToolStripMenuItem.Name = "госНаградыToolStripMenuItem";
            this.госНаградыToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.госНаградыToolStripMenuItem.Text = "Гос. Награды";
            this.госНаградыToolStripMenuItem.Click += new System.EventHandler(this.госНаградыToolStripMenuItem_Click);
            // 
            // работаСХранимымиПроцедурамиToolStripMenuItem
            // 
            this.работаСХранимымиПроцедурамиToolStripMenuItem.Name = "работаСХранимымиПроцедурамиToolStripMenuItem";
            this.работаСХранимымиПроцедурамиToolStripMenuItem.Size = new System.Drawing.Size(214, 20);
            this.работаСХранимымиПроцедурамиToolStripMenuItem.Text = "Работа с хранимыми процедурами";
            this.работаСХранимымиПроцедурамиToolStripMenuItem.Click += new System.EventHandler(this.работаСХранимымиПроцедурамиToolStripMenuItem_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отчет по сотрудникам";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 118);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityHRDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityHRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDisciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.governmentAwardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource universityHRDataSetBindingSource;
        private UniversityHRDataSet universityHRDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private UniversityHRDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private UniversityHRDataSetTableAdapters.disciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private UniversityHRDataSetTableAdapters.documentTableAdapter documentTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private UniversityHRDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeDisciplineBindingSource;
        private UniversityHRDataSetTableAdapters.employeeDisciplineTableAdapter employeeDisciplineTableAdapter;
        private System.Windows.Forms.BindingSource governmentAwardsBindingSource;
        private UniversityHRDataSetTableAdapters.governmentAwardsTableAdapter governmentAwardsTableAdapter;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private UniversityHRDataSetTableAdapters.vacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отпускаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиДисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem госНаградыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСХранимымиПроцедурамиToolStripMenuItem;
        public FastReport.Report report1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

