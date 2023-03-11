namespace datawarehouse_courses
{
    partial class search
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.olapGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.courseDepartmentComboBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.Label();
            this.semsterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.coursesComboBox = new System.Windows.Forms.ComboBox();
            this.instructorComboBox = new System.Windows.Forms.ComboBox();
            this.olapGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.courseDepartmentComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // olapGroupBox
            // 
            this.olapGroupBox.Controls.Add(this.resultsDataGridView);
            this.olapGroupBox.Controls.Add(this.courseDepartmentComboBox);
            this.olapGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.olapGroupBox.Location = new System.Drawing.Point(12, 12);
            this.olapGroupBox.Name = "olapGroupBox";
            this.olapGroupBox.Size = new System.Drawing.Size(1043, 525);
            this.olapGroupBox.TabIndex = 0;
            this.olapGroupBox.TabStop = false;
            this.olapGroupBox.Text = "Search Operation";
            // 
            // resultsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.resultsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultsDataGridView.Location = new System.Drawing.Point(26, 224);
            this.resultsDataGridView.Name = "resultsDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.resultsDataGridView.RowTemplate.Height = 25;
            this.resultsDataGridView.Size = new System.Drawing.Size(954, 289);
            this.resultsDataGridView.TabIndex = 8;
            this.resultsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultsDataGridView_CellContentClick);
            // 
            // courseDepartmentComboBox
            // 
            this.courseDepartmentComboBox.Controls.Add(this.label6);
            this.courseDepartmentComboBox.Controls.Add(this.genderComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.resetButton);
            this.courseDepartmentComboBox.Controls.Add(this.executeButton);
            this.courseDepartmentComboBox.Controls.Add(this.label5);
            this.courseDepartmentComboBox.Controls.Add(this.mComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.label4);
            this.courseDepartmentComboBox.Controls.Add(this.departmentComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.Semester);
            this.courseDepartmentComboBox.Controls.Add(this.semsterComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.label3);
            this.courseDepartmentComboBox.Controls.Add(this.label2);
            this.courseDepartmentComboBox.Controls.Add(this.label1);
            this.courseDepartmentComboBox.Controls.Add(this.dateComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.coursesComboBox);
            this.courseDepartmentComboBox.Controls.Add(this.instructorComboBox);
            this.courseDepartmentComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.courseDepartmentComboBox.Location = new System.Drawing.Point(26, 38);
            this.courseDepartmentComboBox.Name = "courseDepartmentComboBox";
            this.courseDepartmentComboBox.Size = new System.Drawing.Size(954, 168);
            this.courseDepartmentComboBox.TabIndex = 6;
            this.courseDepartmentComboBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(320, 139);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.genderComboBox.Size = new System.Drawing.Size(149, 23);
            this.genderComboBox.TabIndex = 14;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(818, 126);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.executeButton.Location = new System.Drawing.Point(818, 97);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(120, 23);
            this.executeButton.TabIndex = 7;
            this.executeButton.Text = "Search";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Parameters";
            // 
            // mComboBox
            // 
            this.mComboBox.FormattingEnabled = true;
            this.mComboBox.Location = new System.Drawing.Point(6, 39);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(276, 23);
            this.mComboBox.TabIndex = 12;
            this.mComboBox.SelectedIndexChanged += new System.EventHandler(this.mComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Course Department";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(517, 37);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(173, 23);
            this.departmentComboBox.TabIndex = 10;
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(517, 72);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(55, 15);
            this.Semester.TabIndex = 8;
            this.Semester.Text = "Semester";
            // 
            // semsterComboBox
            // 
            this.semsterComboBox.FormattingEnabled = true;
            this.semsterComboBox.Location = new System.Drawing.Point(517, 90);
            this.semsterComboBox.Name = "semsterComboBox";
            this.semsterComboBox.Size = new System.Drawing.Size(173, 23);
            this.semsterComboBox.TabIndex = 7;
            this.semsterComboBox.SelectedIndexChanged += new System.EventHandler(this.measureComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Instructors";
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(320, 90);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(149, 23);
            this.dateComboBox.TabIndex = 2;
            // 
            // coursesComboBox
            // 
            this.coursesComboBox.FormattingEnabled = true;
            this.coursesComboBox.Location = new System.Drawing.Point(320, 38);
            this.coursesComboBox.Name = "coursesComboBox";
            this.coursesComboBox.Size = new System.Drawing.Size(149, 23);
            this.coursesComboBox.TabIndex = 1;
            // 
            // instructorComboBox
            // 
            this.instructorComboBox.FormattingEnabled = true;
            this.instructorComboBox.Location = new System.Drawing.Point(744, 38);
            this.instructorComboBox.Name = "instructorComboBox";
            this.instructorComboBox.Size = new System.Drawing.Size(166, 23);
            this.instructorComboBox.TabIndex = 0;
            this.instructorComboBox.SelectedIndexChanged += new System.EventHandler(this.instructorComboBox_SelectedIndexChanged);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1099, 540);
            this.Controls.Add(this.olapGroupBox);
            this.Name = "search";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.search_Load);
            this.olapGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.courseDepartmentComboBox.ResumeLayout(false);
            this.courseDepartmentComboBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox olapGroupBox;
        private GroupBox courseDepartmentComboBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox dateComboBox;
        private ComboBox coursesComboBox;
        private ComboBox instructorComboBox;
        private Button executeButton;
        private DataGridView resultsDataGridView;
        private Label Semester;
        private ComboBox semsterComboBox;
        private ComboBox departmentComboBox;
        private Label label4;
        private ComboBox mComboBox;
        private Button resetButton;
        private Label label5;
        private Label label6;
        private ComboBox genderComboBox;
    }
}