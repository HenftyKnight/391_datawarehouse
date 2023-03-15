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

                bool joinInstructor = columns.Contains("instructor_dimension.name") || columns.Contains("instructor_dimension.gender");
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
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            //CHANGE CONNECTION STRING 
            SqlConnection con = new SqlConnection("Data Source=ANDROMEDA;Initial Catalog=DATAWAREHOUSE;Integrated Security=True");
            con.Open();

            XmlNodeList dateNode = xmlDocument.SelectNodes("//date");
            foreach (XmlNode node in dateNode)
            {

                int year = int.Parse(node.SelectSingleNode("year").InnerText);
                string semester = (node.SelectSingleNode("semester").InnerText);

                string checkSql = "SELECT COUNT(*) from date_dimension where year = '" + year +"' and semester = '" + semester + "'"; 
                
                SqlCommand check_command = new SqlCommand(checkSql, con);
                int count = (int) check_command.ExecuteScalar();
                if (count == 0) 
                {             
                    string sql = "INSERT INTO date_dimension (year, semester) VALUES (@param1, @param2)";
                    SqlCommand command = new SqlCommand(sql, con);

                    command.Parameters.AddWithValue("@param1", year);
                    command.Parameters.AddWithValue("@param2", semester);

                    command.ExecuteNonQuery();
                }
            }

            XmlNodeList instructorNode = xmlDocument.SelectNodes("//instructor");
            foreach (XmlNode node in instructorNode)
            {
               
                string name = (node.SelectSingleNode("name").InnerText);
                string department = node.SelectSingleNode("department").InnerText;
                string gender = node.SelectSingleNode("gender").InnerText;

                string checkSql = "SELECT COUNT(*) from instructor_dimension where name = '" + name +"' and department = '" + department + "' and gender = '"+ gender +"'"; 
                
                SqlCommand check_command = new SqlCommand(checkSql, con);
                int count = (int) check_command.ExecuteScalar();
                if (count == 0) 
                { 

                    string sql = "INSERT INTO instructor_dimension (name, department, gender) VALUES (@param1, @param2, @param3)";
                    SqlCommand command = new SqlCommand(sql, con);

                    command.Parameters.AddWithValue("@param1", name);
                    command.Parameters.AddWithValue("@param2", department);
                    command.Parameters.AddWithValue("@param3", gender);

                    command.ExecuteNonQuery();
                }
            }


            XmlNodeList courseNode = xmlDocument.SelectNodes("//course");
            foreach (XmlNode node in courseNode)
            {
                string course_name = node.SelectSingleNode("course_name").InnerText;
                string dept_name = node.SelectSingleNode("course_department").InnerText;
                
                string checkSql = "SELECT COUNT(*) from courses_dimension where course_name = '" + course_name +"' and course_department = '" + dept_name + "'"; 
                
                SqlCommand check_command = new SqlCommand(checkSql, con);
                int count = (int) check_command.ExecuteScalar();
                if (count == 0) 
                { 
                    string sql = "INSERT INTO courses_dimension (course_name, course_department) VALUES (@param1, @param2)";
                    SqlCommand command = new SqlCommand(sql, con);

                    command.Parameters.AddWithValue("@param1", course_name);
                    command.Parameters.AddWithValue("@param2", dept_name);

                    command.ExecuteNonQuery();
                }

            }


            //MAKE SURE THE NODE IS "entry" OR CHANGE STRING BELOW
            XmlNodeList nodes = xmlDocument.SelectNodes("//entry");
            foreach (XmlNode node in nodes)
            {
                int instructor_id = int.Parse(node.SelectSingleNode("instructor_id").InnerText);
                int course_id = int.Parse(node.SelectSingleNode("course_id").InnerText);
                int date_id = int.Parse(node.SelectSingleNode("date_id").InnerText);
                int num = int.Parse(node.SelectSingleNode("number_of_courses").InnerText);

                string checkSql = "SELECT COUNT(*) from courses_fact where instructor_id = '" + instructor_id +"' and course_id = '" + course_id + "' and date_id = '" + date_id + "'"; 
                
                SqlCommand check_command = new SqlCommand(checkSql, con);
                int count = (int) check_command.ExecuteScalar();
                if (count == 0) 
                { 
            
                    string sql = "INSERT INTO courses_fact (course_id, date_id,instructor_id,  number_of_courses) VALUES (@param1, @param2, @param3, @param4)";
                    SqlCommand command = new SqlCommand(sql, con);

                    command.Parameters.AddWithValue("@param1", course_id);
                    command.Parameters.AddWithValue("@param2", date_id);
                    command.Parameters.AddWithValue("@param3", instructor_id);
                    command.Parameters.AddWithValue("@param4", num);

                    command.ExecuteNonQuery();
                }
            }
            
            con.Close();
            MessageBox.Show("Entries have been added to the database.");
            
            PopulateComboBox(coursesComboBox, "SELECT DISTINCT course_name FROM courses_dimension ORDER BY course_name ASC");
            PopulateComboBox(departmentComboBox, "SELECT DISTINCT course_department FROM courses_dimension ORDER BY course_department ASC");
            //departmentComboBox.Items.Add("courses_dimension.course_name");
            PopulateComboBox(instructorComboBox, "SELECT DISTINCT name FROM instructor_dimension ORDER BY name ASC");
            PopulateComboBox(dateComboBox, "SELECT DISTINCT year FROM date_dimension ORDER BY year ASC");
            PopulateComboBox(semsterComboBox, "SELECT DISTINCT semester FROM date_dimension ORDER BY semester ASC");
            PopulateComboBox(genderComboBox, "SELECT DISTINCT gender FROM instructor_dimension ORDER BY gender ASC");

        }

        private void search_Load_2(object sender, EventArgs e)
        {

        }
    }
}
