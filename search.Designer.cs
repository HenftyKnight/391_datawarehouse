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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            olapGroupBox = new GroupBox();
            loadBtn = new Button();
            findBtn = new Button();
            resultsDataGridView = new DataGridView();
            courseDepartmentComboBox = new GroupBox();
            label6 = new Label();
            genderComboBox = new ComboBox();
            resetButton = new Button();
            executeButton = new Button();
            label5 = new Label();
            mComboBox = new ComboBox();
            label4 = new Label();
            departmentComboBox = new ComboBox();
            Semester = new Label();
            semsterComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateComboBox = new ComboBox();
            coursesComboBox = new ComboBox();
            instructorComboBox = new ComboBox();
            textBox1 = new TextBox();
            olapGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            courseDepartmentComboBox.SuspendLayout();
            SuspendLayout();
            // 
            // olapGroupBox
            // 
            olapGroupBox.Controls.Add(loadBtn);
            olapGroupBox.Controls.Add(findBtn);
            olapGroupBox.Controls.Add(resultsDataGridView);
            olapGroupBox.Controls.Add(courseDepartmentComboBox);
            olapGroupBox.Controls.Add(textBox1);
            olapGroupBox.ForeColor = SystemColors.ControlLightLight;
            olapGroupBox.Location = new Point(14, 13);
            olapGroupBox.Margin = new Padding(3, 4, 3, 4);
            olapGroupBox.Name = "olapGroupBox";
            olapGroupBox.Padding = new Padding(3, 4, 3, 4);
            olapGroupBox.Size = new Size(1192, 667);
            olapGroupBox.TabIndex = 0;
            olapGroupBox.TabStop = false;
            olapGroupBox.Text = "Search Operation";
            // 
            // loadBtn
            // 
            loadBtn.ForeColor = SystemColors.ActiveCaptionText;
            loadBtn.Location = new Point(524, 32);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(86, 26);
            loadBtn.TabIndex = 11;
            loadBtn.Text = "Load File";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // findBtn
            // 
            findBtn.ForeColor = SystemColors.ActiveCaptionText;
            findBtn.Location = new Point(396, 32);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(86, 26);
            findBtn.TabIndex = 10;
            findBtn.Text = "Find FIle";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // resultsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            resultsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resultsDataGridView.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            resultsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            resultsDataGridView.GridColor = SystemColors.ActiveBorder;
            resultsDataGridView.Location = new Point(30, 284);
            resultsDataGridView.Margin = new Padding(3, 4, 3, 4);
            resultsDataGridView.Name = "resultsDataGridView";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            resultsDataGridView.RowHeadersWidth = 47;
            resultsDataGridView.RowTemplate.Height = 25;
            resultsDataGridView.Size = new Size(1090, 366);
            resultsDataGridView.TabIndex = 8;
            resultsDataGridView.CellContentClick += resultsDataGridView_CellContentClick;
            // 
            // courseDepartmentComboBox
            // 
            courseDepartmentComboBox.Controls.Add(label6);
            courseDepartmentComboBox.Controls.Add(genderComboBox);
            courseDepartmentComboBox.Controls.Add(resetButton);
            courseDepartmentComboBox.Controls.Add(executeButton);
            courseDepartmentComboBox.Controls.Add(label5);
            courseDepartmentComboBox.Controls.Add(mComboBox);
            courseDepartmentComboBox.Controls.Add(label4);
            courseDepartmentComboBox.Controls.Add(departmentComboBox);
            courseDepartmentComboBox.Controls.Add(Semester);
            courseDepartmentComboBox.Controls.Add(semsterComboBox);
            courseDepartmentComboBox.Controls.Add(label3);
            courseDepartmentComboBox.Controls.Add(label2);
            courseDepartmentComboBox.Controls.Add(label1);
            courseDepartmentComboBox.Controls.Add(dateComboBox);
            courseDepartmentComboBox.Controls.Add(coursesComboBox);
            courseDepartmentComboBox.Controls.Add(instructorComboBox);
            courseDepartmentComboBox.ForeColor = SystemColors.Control;
            courseDepartmentComboBox.Location = new Point(30, 65);
            courseDepartmentComboBox.Margin = new Padding(3, 4, 3, 4);
            courseDepartmentComboBox.Name = "courseDepartmentComboBox";
            courseDepartmentComboBox.Padding = new Padding(3, 4, 3, 4);
            courseDepartmentComboBox.Size = new Size(1090, 211);
            courseDepartmentComboBox.TabIndex = 6;
            courseDepartmentComboBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 153);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 15;
            label6.Text = "Gender";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(366, 176);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.RightToLeft = RightToLeft.No;
            genderComboBox.Size = new Size(170, 27);
            genderComboBox.TabIndex = 14;
            genderComboBox.SelectedIndexChanged += genderComboBox_SelectedIndexChanged;
            // 
            // resetButton
            // 
            resetButton.ForeColor = SystemColors.ActiveCaptionText;
            resetButton.Location = new Point(935, 160);
            resetButton.Margin = new Padding(3, 4, 3, 4);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(137, 29);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // executeButton
            // 
            executeButton.ForeColor = SystemColors.ActiveCaptionText;
            executeButton.Location = new Point(935, 123);
            executeButton.Margin = new Padding(3, 4, 3, 4);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(137, 29);
            executeButton.TabIndex = 7;
            executeButton.Text = "Search";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 27);
            label5.Name = "label5";
            label5.Size = new Size(122, 19);
            label5.TabIndex = 13;
            label5.Text = "Search Parameters";
            // 
            // mComboBox
            // 
            mComboBox.FormattingEnabled = true;
            mComboBox.Location = new Point(7, 49);
            mComboBox.Margin = new Padding(3, 4, 3, 4);
            mComboBox.Name = "mComboBox";
            mComboBox.Size = new Size(315, 27);
            mComboBox.TabIndex = 12;
            mComboBox.SelectedIndexChanged += mComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(591, 24);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 11;
            label4.Text = "Course Department";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(591, 47);
            departmentComboBox.Margin = new Padding(3, 4, 3, 4);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(197, 27);
            departmentComboBox.TabIndex = 10;
            departmentComboBox.SelectedIndexChanged += departmentComboBox_SelectedIndexChanged;
            // 
            // Semester
            // 
            Semester.AutoSize = true;
            Semester.Location = new Point(591, 91);
            Semester.Name = "Semester";
            Semester.Size = new Size(65, 19);
            Semester.TabIndex = 8;
            Semester.Text = "Semester";
            // 
            // semsterComboBox
            // 
            semsterComboBox.FormattingEnabled = true;
            semsterComboBox.Location = new Point(591, 114);
            semsterComboBox.Margin = new Padding(3, 4, 3, 4);
            semsterComboBox.Name = "semsterComboBox";
            semsterComboBox.Size = new Size(197, 27);
            semsterComboBox.TabIndex = 7;
            semsterComboBox.SelectedIndexChanged += measureComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 91);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 5;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 25);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 4;
            label2.Text = "Course Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(850, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 3;
            label1.Text = "Instructors";
            // 
            // dateComboBox
            // 
            dateComboBox.FormattingEnabled = true;
            dateComboBox.Location = new Point(366, 114);
            dateComboBox.Margin = new Padding(3, 4, 3, 4);
            dateComboBox.Name = "dateComboBox";
            dateComboBox.Size = new Size(170, 27);
            dateComboBox.TabIndex = 2;
            // 
            // coursesComboBox
            // 
            coursesComboBox.FormattingEnabled = true;
            coursesComboBox.Location = new Point(366, 48);
            coursesComboBox.Margin = new Padding(3, 4, 3, 4);
            coursesComboBox.Name = "coursesComboBox";
            coursesComboBox.Size = new Size(170, 27);
            coursesComboBox.TabIndex = 1;
            // 
            // instructorComboBox
            // 
            instructorComboBox.FormattingEnabled = true;
            instructorComboBox.Location = new Point(850, 48);
            instructorComboBox.Margin = new Padding(3, 4, 3, 4);
            instructorComboBox.Name = "instructorComboBox";
            instructorComboBox.Size = new Size(189, 27);
            instructorComboBox.TabIndex = 0;
            instructorComboBox.SelectedIndexChanged += instructorComboBox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 26);
            textBox1.TabIndex = 9;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1256, 684);
            Controls.Add(olapGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "search";
            Text = "Form1";
            Load += search_Load;
            olapGroupBox.ResumeLayout(false);
            olapGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            courseDepartmentComboBox.ResumeLayout(false);
            courseDepartmentComboBox.PerformLayout();
            ResumeLayout(false);
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
        private TextBox textBox1;
        private Button findBtn;
        private Button loadBtn;
    }
}