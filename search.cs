using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace datawarehouse_courses
{
    public partial class search : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=ANDROMEDA;Initial Catalog=DATAWAREHOUSE;Integrated Security=True");
        public search()
        {
            InitializeComponent();

            PopulateComboBox(coursesComboBox, "SELECT DISTINCT course_name FROM courses_dimension ORDER BY course_name ASC");
            PopulateComboBox(departmentComboBox, "SELECT DISTINCT course_department FROM courses_dimension ORDER BY course_department ASC");
            departmentComboBox.Items.Add("courses_dimension.course_name");
            PopulateComboBox(instructorComboBox, "SELECT DISTINCT name FROM instructor_dimension ORDER BY name ASC");
            PopulateComboBox(dateComboBox, "SELECT DISTINCT year FROM date_dimension ORDER BY year ASC");
            PopulateComboBox(semsterComboBox, "SELECT DISTINCT semester FROM date_dimension ORDER BY semester ASC");
            
            mComboBox.Items.Add("Number of courses");
        }
        private void search_Load(object sender, EventArgs e)
        { }

        private void PopulateComboBox(ComboBox comboBox, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

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

                if (instructorComboBox.SelectedIndex > 0)
                {
                    columns.Add("instructor_dimension.name");
                    wheres.Add("instructor_dimension.name LIKE '%" + instructorComboBox.SelectedItem.ToString() + "%'");
                }

                if (coursesComboBox.SelectedIndex > 0)
                {
                    columns.Add("courses_dimension.course_name");
                    wheres.Add("courses_dimension.course_name LIKE '%" + coursesComboBox.SelectedItem.ToString() + "%'");
                }

                if (departmentComboBox.SelectedIndex > 0)
                {
                    columns.Add("courses_dimension.course_department");
                    wheres.Add("courses_dimension.course_department LIKE '%" + departmentComboBox.SelectedItem.ToString() + "%'");
                }

                if (dateComboBox.SelectedIndex > 0)
                {
                    columns.Add("date_dimension.year");
                    wheres.Add("date_dimension.year = '" + dateComboBox.SelectedItem.ToString() + "'");
                }

                if (semsterComboBox.SelectedIndex > 0)
                {
                    columns.Add("date_dimension.semester");
                    wheres.Add("date_dimension.semester LIKE '%" + semsterComboBox.SelectedItem.ToString() + "%'");
                }

                if (columns.Count == 0)
                {
                    MessageBox.Show("Please select at least one search option.");
                    return;
                }

                if (mComboBox.SelectedIndex != null)
                {
                    string selectedMeasure = mComboBox.SelectedItem.ToString();

                    if (selectedMeasure.Equals("Number of courses"))
                    {
                        measures.Add("SUM(number_of_courses)");
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
    }
    }
