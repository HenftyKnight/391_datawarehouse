using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.CodeDom.Compiler;
using System.Numerics;

namespace datawarehouse_courses
{
    public partial class search : Form

    {
        string filePath = "";

        private SqlConnection conn = new SqlConnection("Data Source=ANDROMEDA;Initial Catalog=DATAWAREHOUSE;Integrated Security=True");
        //private SqlConnection conn = new SqlConnection("Data Source=WAKA;Initial Catalog=WAREHOUSE;Integrated Security=True");

        public search()
        {
            InitializeComponent();

            PopulateComboBox(coursesComboBox, "SELECT DISTINCT course_name FROM courses_dimension ORDER BY course_name ASC");
            PopulateComboBox(departmentComboBox, "SELECT DISTINCT course_department FROM courses_dimension ORDER BY course_department ASC");
            //departmentComboBox.Items.Add("courses_dimension.course_name");
            PopulateComboBox(instructorComboBox, "SELECT DISTINCT name FROM instructor_dimension ORDER BY name ASC");
            PopulateComboBox(dateComboBox, "SELECT DISTINCT year FROM date_dimension ORDER BY year ASC");
            PopulateComboBox(semsterComboBox, "SELECT DISTINCT semester FROM date_dimension ORDER BY semester ASC");
            PopulateComboBox(genderComboBox, "SELECT DISTINCT gender FROM instructor_dimension ORDER BY gender ASC");

            mComboBox.Items.Add("");
            mComboBox.Items.Add("Number of courses");
        }
        private void search_Load(object sender, EventArgs e)
        { }

        private void PopulateComboBox(ComboBox comboBox, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.Clear();
            comboBox.Items.Add(" ");
            comboBox.Items.Add("Select all");

            foreach (DataRow row in dt.Rows)
            {
                comboBox.Items.Add(row[0].ToString());
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                List<string> columns = new List<string>();
                List<string> wheres = new List<string>();
                List<string> measures = new List<string>();



                if (coursesComboBox.SelectedIndex > 0)
                {
                    columns.Add("courses_dimension.course_name");
                    //if (coursesComboBox.SelectedItem.ToString() != "Select all")
                    if (!coursesComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("courses_dimension.course_name = '" + coursesComboBox.SelectedItem.ToString() + "'");
                    }
                    //columns.Add("courses_dimension.course_name");
                    //wheres.Add("courses_dimension.course_name LIKE '%" + coursesComboBox.SelectedItem.ToString() + "%'");
                }


                if (departmentComboBox.SelectedIndex > 0)
                {
                    columns.Add("courses_dimension.course_department");

                    if (!departmentComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("courses_dimension.course_department = '" + departmentComboBox.SelectedItem.ToString() + "'");
                    }
                }

                if (dateComboBox.SelectedIndex > 0)
                {
                    columns.Add("date_dimension.year");
                    if (!dateComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("date_dimension.year = '" + dateComboBox.SelectedItem.ToString() + "'");
                    }
                }

                if (instructorComboBox.SelectedIndex > 0)
                {

                    columns.Add("instructor_dimension.name");
                    if (!instructorComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("instructor_dimension.name  = '" + instructorComboBox.SelectedItem.ToString() + "'");
                    }

                }

                if (semsterComboBox.SelectedIndex > 0)
                {
                    columns.Add("date_dimension.semester");
                    if (!semsterComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("date_dimension.semester = '" + semsterComboBox.SelectedItem.ToString() + "'");
                    }
                }

                if (genderComboBox.SelectedIndex > 0)
                {
                    columns.Add("instructor_dimension.gender");
                    if (!genderComboBox.SelectedItem.ToString().Equals("Select all"))
                    {
                        wheres.Add("instructor_dimension.gender = '" + genderComboBox.SelectedItem.ToString() + "'");
                    }
                }
                if (columns.Count == 0)
                {
                    MessageBox.Show("Please select at least one search option.");
                    return;
                }

                if (mComboBox.SelectedIndex > 0)
                {
                    string selectedMeasure = mComboBox.SelectedItem.ToString();

                    if (selectedMeasure.Equals("Number of courses"))
                    {
                        measures.Add("SUM(number_of_courses) as Number_of_Courses");
                    }
                    else
                    {
                        measures.Add(selectedMeasure);
                    }
                }

                string column = string.Join(",", columns);
                string where = string.Join(" AND ", wheres);
                string measure = string.Join(",", measures);

                string query = $"SELECT {column}";

                if (!string.IsNullOrEmpty(measure))
                {
                    query += $", {measure}";
                }

                query += " FROM courses_fact ";

                bool joinInstructor = columns.Contains("instructor_dimension.name");
                bool joinDate = columns.Contains("date_dimension.year") || columns.Contains("date_dimension.semester");
                bool joinCourses = columns.Contains("courses_dimension.course_name") || columns.Contains("courses_dimension.course_department");

                if (joinInstructor)
                {
                    query += "INNER JOIN instructor_dimension ON courses_fact.instructor_id = instructor_dimension.instructor_id ";
                }

                if (joinDate)
                {
                    query += "INNER JOIN date_dimension ON courses_fact.date_id = date_dimension.date_id ";
                }

                if (joinCourses)
                {
                    query += "INNER JOIN courses_dimension ON courses_fact.course_id = courses_dimension.course_id ";
                }

                if (!string.IsNullOrEmpty(where))
                {
                    query += $"WHERE {where} ";
                }

                query += $"GROUP BY {column}";

                MessageBox.Show(query.ToString());

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                resultsDataGridView.DataSource = dt;

                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred while executing the query." + Ex.ToString());
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }


        private void measureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void search_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear all the combo boxes 

            coursesComboBox.SelectedIndex = -1;
            departmentComboBox.SelectedIndex = -1;
            instructorComboBox.SelectedIndex = -1;
            dateComboBox.SelectedIndex = -1;
            semsterComboBox.SelectedIndex = -1;
            mComboBox.SelectedIndex = -1;

            // Clear the data grid view
            resultsDataGridView.DataSource = null;
            resultsDataGridView.Rows.Clear();
            resultsDataGridView.Columns.Clear();
        }

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!departmentComboBox.SelectedItem.ToString().Equals("Select all"))
            {
                instructorComboBox.Items.Clear();
                PopulateComboBox(instructorComboBox, "SELECT DISTINCT name FROM instructor_dimension WHERE instructor_dimension.department = '" + departmentComboBox.SelectedItem.ToString() + "' ORDER BY name ASC");
            }
            else if (departmentComboBox.SelectedItem.ToString().Equals("Select all"))
            {
                instructorComboBox.Items.Clear();
                PopulateComboBox(instructorComboBox, "SELECT DISTINCT name FROM instructor_dimension ORDER BY name ASC");

            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "XML files (*.xml) |*.xml";
            fopen.FilterIndex = 1;
            fopen.RestoreDirectory = true;

            if (fopen.ShowDialog() == DialogResult.OK)
            {
                filePath = fopen.FileName;
                textBox1.Text = filePath.ToString();

            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANDROMEDA;Initial Catalog=DATAWAREHOUSE;Integrated Security=True";

            // Path to the XML file
            string xmlFilePath = "C:\\Users\\My Computer\\source\\repos\\datawarehouse_courses\\xml.xml";

            // Create a new DataSet and load the XML file into it
            DataSet xmlDataSet = new DataSet();
            xmlDataSet.ReadXml(xmlFilePath);

            // Create a new SqlConnection object and open the connection
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Create a new SqlDataAdapter and use it to fill a DataTable with the data from the dimension tables
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM date_dimension", connection);
            DataTable dateDimensionTable = new DataTable();
            adapter.Fill(dateDimensionTable);

            adapter = new SqlDataAdapter("SELECT * FROM instructor_dimension", connection);
            DataTable instructorDimensionTable = new DataTable();
            adapter.Fill(instructorDimensionTable);

            adapter = new SqlDataAdapter("SELECT * FROM courses_dimension", connection);
            DataTable coursesDimensionTable = new DataTable();
            adapter.Fill(coursesDimensionTable);

            // Create a new DataTable to hold the new records from the XML file
            DataTable newRecordsTable = xmlDataSet.Tables[0].Copy();

            // Set the primary key for the dimension tables
            DataColumn[] primaryKeyColumns = new DataColumn[3];
            primaryKeyColumns[0] = dateDimensionTable.Columns["date_id"];
            dateDimensionTable.PrimaryKey = primaryKeyColumns;

            primaryKeyColumns[0] = instructorDimensionTable.Columns["instructor_id"];
            instructorDimensionTable.PrimaryKey = primaryKeyColumns;

            primaryKeyColumns[0] = coursesDimensionTable.Columns["course_id"];
            coursesDimensionTable.PrimaryKey = primaryKeyColumns;


            // Loop through the new records and compare them to the existing records in the dimension tables
            foreach (DataRow newRecord in newRecordsTable.Rows)
            {
                DataRow existingRecord;

                // Check if the date dimension record already exists, otherwise insert it
                existingRecord = dateDimensionTable.Rows.Find(newRecord["date_id"]);
                if (existingRecord == null)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO date_dimension (date_id, year, semester) VALUES (@date_id, @year, @semester)", connection);
                    command.Parameters.AddWithValue("@date_id", newRecord["date_id"]);
                    command.Parameters.AddWithValue("@year", newRecord["year"]);
                    command.Parameters.AddWithValue("@semester", newRecord["semester"]);
                    command.ExecuteNonQuery();
                }

                // Check if the instructor dimension record already exists, otherwise insert it
                existingRecord = instructorDimensionTable.Rows.Find(newRecord["instructor_id"]);
                if (existingRecord == null)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO instructor_dimension (instructor_id, name, department, gender) VALUES (@instructor_id, @name, @department, @gender)", connection);
                    command.Parameters.AddWithValue("@instructor_id", newRecord["instructor_id"]);
                    command.Parameters.AddWithValue("@name", newRecord["instructor_name"]);
                    command.Parameters.AddWithValue("@department", newRecord["instructor_department"]);
                    command.Parameters.AddWithValue("@gender", newRecord["instructor_gender"]);
                    command.ExecuteNonQuery();
                }

                // Check if the course dimension record already exists, otherwise insert it
                existingRecord = coursesDimensionTable.Rows.Find(newRecord["course_id"]);
                if (existingRecord == null)
                {
                    SqlCommand command = new SqlCommand("INSERT INTO courses_dimension (course_id, course_name, course_department) VALUES (@course_id, @course_name, @course_department)", connection);
                    command.Parameters.AddWithValue("@course_id", newRecord["course_id"]);
                    command.Parameters.AddWithValue("@course_name", newRecord["course_name"]);
                    command.Parameters.AddWithValue("@course_department", newRecord["course_department"]);
                    // Complete the SQL command with the missing parameters and execute it
                    command.ExecuteNonQuery();
                }

                // Create a new SqlDataAdapter and use it to fill a DataTable with the data from the fact table
                SqlDataAdapter factAdapter = new SqlDataAdapter("SELECT * FROM courses_fact", connection);
                DataTable coursesFactTable = new DataTable();
                factAdapter.Fill(coursesFactTable);


                // Check if the record already exists in the courses_fact table, otherwise insert it
                SqlCommand selectCommand = new SqlCommand("SELECT COUNT(*) FROM courses_fact WHERE date_id=@date_id AND instructor_id=@instructor_id AND course_id=@course_id", connection);
                selectCommand.Parameters.AddWithValue("@date_id", newRecord["date_id"]);
                selectCommand.Parameters.AddWithValue("@instructor_id", newRecord["instructor_id"]);
                selectCommand.Parameters.AddWithValue("@course_id", newRecord["course_id"]);
                int count = Convert.ToInt32(selectCommand.ExecuteScalar());

                if (count == 0)
                {
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO courses_fact (date_id, instructor_id, course_id, students_enrolled, students_passed) VALUES (@date_id, @instructor_id, @course_id, @students_enrolled, @students_passed)", connection);
                    insertCommand.Parameters.AddWithValue("@date_id", newRecord["date_id"]);
                    insertCommand.Parameters.AddWithValue("@instructor_id", newRecord["instructor_id"]);
                    insertCommand.Parameters.AddWithValue("@course_id", newRecord["course_id"]);
                    insertCommand.Parameters.AddWithValue("@number_of_courses", newRecord["num_courses"]);
                    insertCommand.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
