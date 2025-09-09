using System;
using System.Data;
using System.Windows.Forms;

namespace ISYS_43603___App_Assignment_Fall_2025
{
    public partial class EnrollmentForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbStudent;
        private ComboBox cmbClass;
        private Button btnEnroll;
        private Button btnUnenroll;
        private Button btnClose;
        private DataGridView dgvEnrollments;
        private Label lblStudent;
        private Label lblClass;
        private GroupBox grpEnrollment;
        private GroupBox grpCurrentEnrollments;

        public EnrollmentForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.cmbStudent = new ComboBox();
            this.cmbClass = new ComboBox();
            this.btnEnroll = new Button();
            this.btnUnenroll = new Button();
            this.btnClose = new Button();
            this.dgvEnrollments = new DataGridView();
            this.lblStudent = new Label();
            this.lblClass = new Label();
            this.grpEnrollment = new GroupBox();
            this.grpCurrentEnrollments = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).BeginInit();
            this.grpEnrollment.SuspendLayout();
            this.grpCurrentEnrollments.SuspendLayout();
            this.SuspendLayout();

            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpEnrollment);
            this.Controls.Add(this.grpCurrentEnrollments);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnrollmentForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Student Enrollment Management";
            this.Load += new EventHandler(this.EnrollmentForm_Load);

            // 
            // grpEnrollment
            // 
            this.grpEnrollment.Controls.Add(this.lblStudent);
            this.grpEnrollment.Controls.Add(this.cmbStudent);
            this.grpEnrollment.Controls.Add(this.lblClass);
            this.grpEnrollment.Controls.Add(this.cmbClass);
            this.grpEnrollment.Controls.Add(this.btnEnroll);
            this.grpEnrollment.Controls.Add(this.btnUnenroll);
            this.grpEnrollment.Location = new System.Drawing.Point(20, 20);
            this.grpEnrollment.Name = "grpEnrollment";
            this.grpEnrollment.Size = new System.Drawing.Size(760, 150);
            this.grpEnrollment.TabIndex = 0;
            this.grpEnrollment.TabStop = false;
            this.grpEnrollment.Text = "Manage Enrollments";

            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(20, 30);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(47, 13);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student:";

            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(80, 27);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(300, 21);
            this.cmbStudent.TabIndex = 1;

            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(20, 70);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 13);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "Class:";

            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(80, 67);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(300, 21);
            this.cmbClass.TabIndex = 3;

            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(80, 110);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(100, 30);
            this.btnEnroll.TabIndex = 4;
            this.btnEnroll.Text = "Enroll Student";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new EventHandler(this.btnEnroll_Click);

            // 
            // btnUnenroll
            // 
            this.btnUnenroll.Location = new System.Drawing.Point(200, 110);
            this.btnUnenroll.Name = "btnUnenroll";
            this.btnUnenroll.Size = new System.Drawing.Size(100, 30);
            this.btnUnenroll.TabIndex = 5;
            this.btnUnenroll.Text = "Unenroll Student";
            this.btnUnenroll.UseVisualStyleBackColor = true;
            this.btnUnenroll.Click += new EventHandler(this.btnUnenroll_Click);

            // 
            // grpCurrentEnrollments
            // 
            this.grpCurrentEnrollments.Controls.Add(this.dgvEnrollments);
            this.grpCurrentEnrollments.Location = new System.Drawing.Point(20, 190);
            this.grpCurrentEnrollments.Name = "grpCurrentEnrollments";
            this.grpCurrentEnrollments.Size = new System.Drawing.Size(760, 350);
            this.grpCurrentEnrollments.TabIndex = 1;
            this.grpCurrentEnrollments.TabStop = false;
            this.grpCurrentEnrollments.Text = "Current Enrollments";

            // 
            // dgvEnrollments
            // 
            this.dgvEnrollments.AllowUserToAddRows = false;
            this.dgvEnrollments.AllowUserToDeleteRows = false;
            this.dgvEnrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrollments.Location = new System.Drawing.Point(20, 25);
            this.dgvEnrollments.Name = "dgvEnrollments";
            this.dgvEnrollments.ReadOnly = true;
            this.dgvEnrollments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnrollments.Size = new System.Drawing.Size(720, 310);
            this.dgvEnrollments.TabIndex = 0;

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 560);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Finish initialization
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrollments)).EndInit();
            this.grpEnrollment.ResumeLayout(false);
            this.grpEnrollment.PerformLayout();
            this.grpCurrentEnrollments.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadDropdowns();
            LoadEnrollments();
        }

        private void LoadDropdowns()
        {
            try
            {
                // Load students
                DataTable studentDt = new DataTable();
                string studentSql = "SELECT STUDENT_ID, NAME FROM STUDENT ORDER BY NAME";
                if (Walton_DB.FillDataTable_ViaSql(ref studentDt, studentSql))
                {
                    cmbStudent.DisplayMember = "NAME";
                    cmbStudent.ValueMember = "STUDENT_ID";
                    cmbStudent.DataSource = studentDt;
                    cmbStudent.SelectedIndex = -1;
                }

                // Load classes
                DataTable classDt = new DataTable();
                string classSql = @"SELECT c.CLASS_ID, c.CLASS_ID + ' - ' + i.NAME as DISPLAY_NAME 
                                   FROM CLASS c 
                                   LEFT JOIN INSTRUCTOR i ON c.INST_ID = i.INST_ID 
                                   ORDER BY c.CLASS_ID";
                if (Walton_DB.FillDataTable_ViaSql(ref classDt, classSql))
                {
                    cmbClass.DisplayMember = "DISPLAY_NAME";
                    cmbClass.ValueMember = "CLASS_ID";
                    cmbClass.DataSource = classDt;
                    cmbClass.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdowns: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEnrollments()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"SELECT e.ENROLL_ID, s.STUDENT_ID, s.NAME as STUDENT_NAME, 
                              c.CLASS_ID, i.NAME as INSTRUCTOR_NAME, c.MTG_TIME, c.ROOM
                              FROM ENROLL e
                              INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID
                              INNER JOIN CLASS c ON e.CLASS_ID = c.CLASS_ID
                              LEFT JOIN INSTRUCTOR i ON c.INST_ID = i.INST_ID
                              ORDER BY s.NAME, c.CLASS_ID";

                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    dgvEnrollments.DataSource = dt;
                    dgvEnrollments.Columns["ENROLL_ID"].HeaderText = "Enrollment ID";
                    dgvEnrollments.Columns["STUDENT_ID"].HeaderText = "Student ID";
                    dgvEnrollments.Columns["STUDENT_NAME"].HeaderText = "Student Name";
                    dgvEnrollments.Columns["CLASS_ID"].HeaderText = "Class ID";
                    dgvEnrollments.Columns["INSTRUCTOR_NAME"].HeaderText = "Instructor";
                    dgvEnrollments.Columns["MTG_TIME"].HeaderText = "Meeting Time";
                    dgvEnrollments.Columns["ROOM"].HeaderText = "Room";

                    dgvEnrollments.Columns["ENROLL_ID"].Width = 80;
                    dgvEnrollments.Columns["STUDENT_ID"].Width = 80;
                    dgvEnrollments.Columns["STUDENT_NAME"].Width = 150;
                    dgvEnrollments.Columns["CLASS_ID"].Width = 80;
                    dgvEnrollments.Columns["INSTRUCTOR_NAME"].Width = 150;
                    dgvEnrollments.Columns["MTG_TIME"].Width = 100;
                    dgvEnrollments.Columns["ROOM"].Width = 80;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading enrollments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (ValidateEnrollmentInput())
            {
                try
                {
                    // Check if student is already enrolled in this class
                    string checkSql = $@"SELECT COUNT(*) FROM ENROLL 
                                        WHERE STUDENT_ID = {cmbStudent.SelectedValue} 
                                        AND CLASS_ID = '{cmbClass.SelectedValue.ToString().Replace("'", "''")}'";

                    object result = Walton_DB.RetrieveSingleValue(checkSql);
                    if (Convert.ToInt32(result) > 0)
                    {
                        MessageBox.Show("Student is already enrolled in this class.", "Enrollment Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Enroll the student
                    string enrollSql = $@"INSERT INTO ENROLL (STUDENT_ID, CLASS_ID) VALUES 
                                         ({cmbStudent.SelectedValue}, '{cmbClass.SelectedValue.ToString().Replace("'", "''")}')";

                    if (Walton_DB.ExecSqlString(enrollSql))
                    {
                        MessageBox.Show("Student enrolled successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEnrollments();
                        cmbStudent.SelectedIndex = -1;
                        cmbClass.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to enroll student.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error enrolling student: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUnenroll_Click(object sender, EventArgs e)
        {
            if (dgvEnrollments.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to unenroll this student?", "Confirm Unenrollment",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var enrollId = dgvEnrollments.SelectedRows[0].Cells["ENROLL_ID"].Value;
                        string sql = $"DELETE FROM ENROLL WHERE ENROLL_ID = {enrollId}";

                        if (Walton_DB.ExecSqlString(sql))
                        {
                            MessageBox.Show("Student unenrolled successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEnrollments();
                        }
                        else
                        {
                            MessageBox.Show("Failed to unenroll student.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error unenrolling student: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an enrollment to remove.", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateEnrollmentInput()
        {
            if (cmbStudent.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStudent.Focus();
                return false;
            }

            if (cmbClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbClass.Focus();
                return false;
            }

            return true;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}