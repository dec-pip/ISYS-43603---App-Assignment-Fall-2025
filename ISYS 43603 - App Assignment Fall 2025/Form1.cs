using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISYS_43603___App_Assignment_Fall_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Test database connection and load initial data
            if (!Walton_DB.OpenConnection())
            {
                MessageBox.Show("Failed to connect to database. Please check your connection.", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Load all data when form loads
            LoadInstructors();
            LoadStudents();
            LoadClasses();
            LoadReportDropdowns();
        }

        #region Instructor Functionality

        private void LoadInstructors()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT INST_ID, NAME FROM INSTRUCTOR ORDER BY NAME";

                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    dgvInstructors.DataSource = dt;
                    dgvInstructors.Columns["INST_ID"].HeaderText = "Instructor ID";
                    dgvInstructors.Columns["NAME"].HeaderText = "Name";
                    dgvInstructors.Columns["INST_ID"].Width = 100;
                    dgvInstructors.Columns["NAME"].Width = 300;
                }
                else
                {
                    MessageBox.Show("Failed to load instructors data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading instructors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInstructors.Rows[e.RowIndex];
                txtInstID.Text = row.Cells["INST_ID"].Value?.ToString() ?? "";
                txtInstName.Text = row.Cells["NAME"].Value?.ToString()?.Trim() ?? "";
            }
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            if (ValidateInstructorInput())
            {
                try
                {
                    string sql = $"INSERT INTO INSTRUCTOR (INST_ID, NAME) VALUES ({txtInstID.Text}, '{Walton_DB.EscapeSqlString(txtInstName.Text)}')";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Instructor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInstructors();
                        LoadReportDropdowns();
                        ClearInstructorForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add instructor. Please check if the ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateInstructor_Click(object sender, EventArgs e)
        {
            if (ValidateInstructorInput())
            {
                try
                {
                    string sql = $"UPDATE INSTRUCTOR SET NAME = '{Walton_DB.EscapeSqlString(txtInstName.Text)}' WHERE INST_ID = {txtInstID.Text}";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Instructor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInstructors();
                        LoadReportDropdowns();
                        ClearInstructorForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update instructor. Please verify the instructor exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating instructor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearInstructor_Click(object sender, EventArgs e)
        {
            ClearInstructorForm();
        }

        private void ClearInstructorForm()
        {
            txtInstID.Clear();
            txtInstName.Clear();
        }

        private bool ValidateInstructorInput()
        {
            if (string.IsNullOrWhiteSpace(txtInstID.Text))
            {
                MessageBox.Show("Please enter an Instructor ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstID.Focus();
                return false;
            }

            if (!int.TryParse(txtInstID.Text, out _))
            {
                MessageBox.Show("Instructor ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtInstName.Text))
            {
                MessageBox.Show("Please enter an Instructor Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstName.Focus();
                return false;
            }

            // Note: Based on your PDF, INSTRUCTOR.NAME might be character(1) - please adjust if needed
            if (txtInstName.Text.Length > 50)  // Assuming reasonable length, adjust based on your schema
            {
                MessageBox.Show("Instructor name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInstName.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Student Functionality

        private void LoadStudents()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT STUDENT_ID, NAME, MAJOR, GRADE_LVL, AGE FROM STUDENT ORDER BY NAME";

                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    dgvStudents.DataSource = dt;
                    dgvStudents.Columns["STUDENT_ID"].HeaderText = "Student ID";
                    dgvStudents.Columns["NAME"].HeaderText = "Name";
                    dgvStudents.Columns["MAJOR"].HeaderText = "Major";
                    dgvStudents.Columns["GRADE_LVL"].HeaderText = "Grade Level";
                    dgvStudents.Columns["AGE"].HeaderText = "Age";

                    dgvStudents.Columns["STUDENT_ID"].Width = 80;
                    dgvStudents.Columns["NAME"].Width = 200;
                    dgvStudents.Columns["MAJOR"].Width = 80;
                    dgvStudents.Columns["GRADE_LVL"].Width = 100;
                    dgvStudents.Columns["AGE"].Width = 60;
                }
                else
                {
                    MessageBox.Show("Failed to load students data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["STUDENT_ID"].Value?.ToString() ?? "";
                txtStudentName.Text = row.Cells["NAME"].Value?.ToString()?.Trim() ?? "";
                txtMajor.Text = row.Cells["MAJOR"].Value?.ToString()?.Trim() ?? "";
                txtGradeLevel.Text = row.Cells["GRADE_LVL"].Value?.ToString()?.Trim() ?? "";
                txtAge.Text = row.Cells["AGE"].Value?.ToString() ?? "";
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                try
                {
                    string sql = $"INSERT INTO STUDENT (STUDENT_ID, NAME, MAJOR, GRADE_LVL, AGE) VALUES " +
                                $"({txtStudentID.Text}, '{Walton_DB.EscapeSqlString(txtStudentName.Text)}', " +
                                $"'{Walton_DB.EscapeSqlString(txtMajor.Text)}', '{Walton_DB.EscapeSqlString(txtGradeLevel.Text)}', {txtAge.Text})";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                        LoadReportDropdowns();
                        ClearStudentForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student. Please check if the ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (ValidateStudentInput())
            {
                try
                {
                    string sql = $"UPDATE STUDENT SET NAME = '{Walton_DB.EscapeSqlString(txtStudentName.Text)}', " +
                                $"MAJOR = '{Walton_DB.EscapeSqlString(txtMajor.Text)}', " +
                                $"GRADE_LVL = '{Walton_DB.EscapeSqlString(txtGradeLevel.Text)}', " +
                                $"AGE = {txtAge.Text} WHERE STUDENT_ID = {txtStudentID.Text}";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                        LoadReportDropdowns();
                        ClearStudentForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student. Please verify the student exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            ClearStudentForm();
        }

        private void ClearStudentForm()
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtMajor.Clear();
            txtGradeLevel.Clear();
            txtAge.Clear();
        }

        private bool ValidateStudentInput()
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please enter a Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            if (!int.TryParse(txtStudentID.Text, out _))
            {
                MessageBox.Show("Student ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter a Student Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }

            if (txtStudentName.Text.Length > 50)
            {
                MessageBox.Show("Student name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMajor.Text))
            {
                MessageBox.Show("Please enter a Major.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajor.Focus();
                return false;
            }

            if (txtMajor.Text.Length > 5)
            {
                MessageBox.Show("Major cannot exceed 5 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGradeLevel.Text))
            {
                MessageBox.Show("Please enter a Grade Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGradeLevel.Focus();
                return false;
            }

            if (txtGradeLevel.Text.Length > 2)
            {
                MessageBox.Show("Grade Level cannot exceed 2 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGradeLevel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please enter an Age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 1 || age > 150)
            {
                MessageBox.Show("Age must be a valid number between 1 and 150.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Class Functionality

        private void LoadClasses()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT c.CLASS_ID, c.MTG_TIME, c.ROOM, c.INST_ID, i.NAME as INSTRUCTOR_NAME 
                              FROM CLASS c 
                              LEFT JOIN INSTRUCTOR i ON c.INST_ID = i.INST_ID 
                              ORDER BY c.CLASS_ID";

                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    dgvClasses.DataSource = dt;
                    dgvClasses.Columns["CLASS_ID"].HeaderText = "Class ID";
                    dgvClasses.Columns["MTG_TIME"].HeaderText = "Meeting Time";
                    dgvClasses.Columns["ROOM"].HeaderText = "Room";
                    dgvClasses.Columns["INST_ID"].HeaderText = "Instructor ID";
                    dgvClasses.Columns["INSTRUCTOR_NAME"].HeaderText = "Instructor Name";

                    dgvClasses.Columns["CLASS_ID"].Width = 100;
                    dgvClasses.Columns["MTG_TIME"].Width = 100;
                    dgvClasses.Columns["ROOM"].Width = 80;
                    dgvClasses.Columns["INST_ID"].Width = 100;
                    dgvClasses.Columns["INSTRUCTOR_NAME"].Width = 200;
                }

                // Load instructor dropdown for class form
                LoadInstructorDropdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInstructorDropdown()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT INST_ID, NAME FROM INSTRUCTOR ORDER BY NAME";

                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    cmbInstructor.DisplayMember = "NAME";
                    cmbInstructor.ValueMember = "INST_ID";
                    cmbInstructor.DataSource = dt;
                    cmbInstructor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading instructor dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClasses.Rows[e.RowIndex];
                txtClassID.Text = row.Cells["CLASS_ID"].Value?.ToString()?.Trim() ?? "";
                txtMeetingTime.Text = row.Cells["MTG_TIME"].Value?.ToString()?.Trim() ?? "";
                txtRoom.Text = row.Cells["ROOM"].Value?.ToString()?.Trim() ?? "";

                var instId = row.Cells["INST_ID"].Value?.ToString();
                if (!string.IsNullOrEmpty(instId))
                {
                    cmbInstructor.SelectedValue = Convert.ToInt32(instId);
                }
                else
                {
                    cmbInstructor.SelectedIndex = -1;
                }
            }
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (ValidateClassInput())
            {
                try
                {
                    string sql = $"INSERT INTO CLASS (CLASS_ID, MTG_TIME, INST_ID, ROOM) VALUES " +
                                $"('{Walton_DB.EscapeSqlString(txtClassID.Text)}', '{Walton_DB.EscapeSqlString(txtMeetingTime.Text)}', " +
                                $"{cmbInstructor.SelectedValue}, '{Walton_DB.EscapeSqlString(txtRoom.Text)}')";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                        LoadReportDropdowns();
                        ClearClassForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add class. Please check if the Class ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (ValidateClassInput())
            {
                try
                {
                    string sql = $"UPDATE CLASS SET MTG_TIME = '{Walton_DB.EscapeSqlString(txtMeetingTime.Text)}', " +
                                $"INST_ID = {cmbInstructor.SelectedValue}, " +
                                $"ROOM = '{Walton_DB.EscapeSqlString(txtRoom.Text)}' " +
                                $"WHERE CLASS_ID = '{Walton_DB.EscapeSqlString(txtClassID.Text)}'";

                    if (Walton_DB.ExecSqlString(sql))
                    {
                        MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                        LoadReportDropdowns();
                        ClearClassForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update class. Please verify the class exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClearClass_Click(object sender, EventArgs e)
        {
            ClearClassForm();
        }

        private void ClearClassForm()
        {
            txtClassID.Clear();
            txtMeetingTime.Clear();
            txtRoom.Clear();
            cmbInstructor.SelectedIndex = -1;
        }

        private bool ValidateClassInput()
        {
            if (string.IsNullOrWhiteSpace(txtClassID.Text))
            {
                MessageBox.Show("Please enter a Class ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassID.Focus();
                return false;
            }

            if (txtClassID.Text.Length > 8)
            {
                MessageBox.Show("Class ID cannot exceed 8 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClassID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMeetingTime.Text))
            {
                MessageBox.Show("Please enter a Meeting Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeetingTime.Focus();
                return false;
            }

            if (txtMeetingTime.Text.Length > 5)
            {
                MessageBox.Show("Meeting Time cannot exceed 5 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeetingTime.Focus();
                return false;
            }

            if (cmbInstructor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Instructor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInstructor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRoom.Text))
            {
                MessageBox.Show("Please enter a Room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoom.Focus();
                return false;
            }

            if (txtRoom.Text.Length > 7)
            {
                MessageBox.Show("Room cannot exceed 7 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoom.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Reports Functionality

        private void LoadReportDropdowns()
        {
            try
            {
                // Load instructors for reports
                DataTable instructorDt = new DataTable();
                string instructorSql = "SELECT INST_ID, NAME FROM INSTRUCTOR ORDER BY NAME";
                if (Walton_DB.FillDataTable_ViaSql(ref instructorDt, instructorSql))
                {
                    cmbReportInstructor.DisplayMember = "NAME";
                    cmbReportInstructor.ValueMember = "INST_ID";
                    cmbReportInstructor.DataSource = instructorDt.Copy();
                    cmbReportInstructor.SelectedIndex = -1;
                }

                // Load students for reports
                DataTable studentDt = new DataTable();
                string studentSql = "SELECT STUDENT_ID, NAME FROM STUDENT ORDER BY NAME";
                if (Walton_DB.FillDataTable_ViaSql(ref studentDt, studentSql))
                {
                    cmbReportStudent.DisplayMember = "NAME";
                    cmbReportStudent.ValueMember = "STUDENT_ID";
                    cmbReportStudent.DataSource = studentDt.Copy();
                    cmbReportStudent.SelectedIndex = -1;
                }

                // Load classes for reports
                DataTable classDt = new DataTable();
                string classSql = @"SELECT c.CLASS_ID, c.CLASS_ID + ' - ' + ISNULL(i.NAME, 'No Instructor') as DISPLAY_NAME 
                                   FROM CLASS c 
                                   LEFT JOIN INSTRUCTOR i ON c.INST_ID = i.INST_ID 
                                   ORDER BY c.CLASS_ID";
                if (Walton_DB.FillDataTable_ViaSql(ref classDt, classSql))
                {
                    cmbReportClass.DisplayMember = "DISPLAY_NAME";
                    cmbReportClass.ValueMember = "CLASS_ID";
                    cmbReportClass.DataSource = classDt.Copy();
                    cmbReportClass.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report dropdowns: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbReportInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportInstructor.SelectedIndex != -1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string sql = $@"SELECT c.CLASS_ID, c.MTG_TIME, c.ROOM 
                                   FROM CLASS c 
                                   WHERE c.INST_ID = {cmbReportInstructor.SelectedValue}
                                   ORDER BY c.CLASS_ID";

                    if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                    {
                        dgvInstructorClasses.DataSource = dt;
                        dgvInstructorClasses.Columns["CLASS_ID"].HeaderText = "Class ID";
                        dgvInstructorClasses.Columns["MTG_TIME"].HeaderText = "Meeting Time";
                        dgvInstructorClasses.Columns["ROOM"].HeaderText = "Room";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading instructor classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbReportStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportStudent.SelectedIndex != -1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string sql = $@"SELECT c.CLASS_ID, c.MTG_TIME, c.ROOM, ISNULL(i.NAME, 'No Instructor') as INSTRUCTOR_NAME
                                   FROM ENROLL e
                                   INNER JOIN CLASS c ON e.CLASS_ID = c.CLASS_ID
                                   LEFT JOIN INSTRUCTOR i ON c.INST_ID = i.INST_ID
                                   WHERE e.STUDENT_ID = {cmbReportStudent.SelectedValue}
                                   ORDER BY c.CLASS_ID";

                    if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                    {
                        dgvStudentClasses.DataSource = dt;
                        dgvStudentClasses.Columns["CLASS_ID"].HeaderText = "Class ID";
                        dgvStudentClasses.Columns["MTG_TIME"].HeaderText = "Meeting Time";
                        dgvStudentClasses.Columns["ROOM"].HeaderText = "Room";
                        dgvStudentClasses.Columns["INSTRUCTOR_NAME"].HeaderText = "Instructor";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading student classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbReportClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportClass.SelectedIndex != -1)
            {
                try
                {
                    DataTable dt = new DataTable();
                    string sql = $@"SELECT s.STUDENT_ID, s.NAME, s.MAJOR, s.GRADE_LVL, s.AGE
                                   FROM ENROLL e
                                   INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID
                                   WHERE e.CLASS_ID = '{Walton_DB.EscapeSqlString(cmbReportClass.SelectedValue.ToString())}'
                                   ORDER BY s.NAME";

                    if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                    {
                        dgvClassStudents.DataSource = dt;
                        dgvClassStudents.Columns["STUDENT_ID"].HeaderText = "Student ID";
                        dgvClassStudents.Columns["NAME"].HeaderText = "Name";
                        dgvClassStudents.Columns["MAJOR"].HeaderText = "Major";
                        dgvClassStudents.Columns["GRADE_LVL"].HeaderText = "Grade Level";
                        dgvClassStudents.Columns["AGE"].HeaderText = "Age";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading class students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Enrollment Management

        private void btnManageEnrollments_Click(object sender, EventArgs e)
        {
            try
            {
                EnrollmentForm enrollmentForm = new EnrollmentForm();
                enrollmentForm.ShowDialog(this);

                // Refresh report data after enrollment changes
                LoadReportDropdowns();

                // Clear and refresh any currently displayed reports
                if (cmbReportInstructor.SelectedIndex != -1)
                    cmbReportInstructor_SelectedIndexChanged(null, null);
                if (cmbReportStudent.SelectedIndex != -1)
                    cmbReportStudent_SelectedIndexChanged(null, null);
                if (cmbReportClass.SelectedIndex != -1)
                    cmbReportClass_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening enrollment management: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Menu Event Handlers

        private void testDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseTestForm testForm = new DatabaseTestForm();
                testForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening database test form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manageEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnManageEnrollments_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit the Arkansas Student Management System?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }
    }
}