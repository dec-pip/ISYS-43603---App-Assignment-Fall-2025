namespace ISYS_43603___App_Assignment_Fall_2025
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDatabaseConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEnrollmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInstructors;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabClasses;
        private System.Windows.Forms.TabPage tabReports;

        // Instructors Tab Controls
        private System.Windows.Forms.DataGridView dgvInstructors;
        private System.Windows.Forms.TextBox txtInstID;
        private System.Windows.Forms.TextBox txtInstName;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Button btnUpdateInstructor;
        private System.Windows.Forms.Button btnClearInstructor;
        private System.Windows.Forms.Label lblInstID;
        private System.Windows.Forms.Label lblInstName;

        // Students Tab Controls
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtGradeLevel;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.Label lblAge;

        // Classes Tab Controls
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtMeetingTime;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnClearClass;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Label lblMeetingTime;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblRoom;

        // Reports Tab Controls
        private System.Windows.Forms.GroupBox grpInstructorClasses;
        private System.Windows.Forms.ComboBox cmbReportInstructor;
        private System.Windows.Forms.DataGridView dgvInstructorClasses;
        private System.Windows.Forms.GroupBox grpStudentClasses;
        private System.Windows.Forms.ComboBox cmbReportStudent;
        private System.Windows.Forms.DataGridView dgvStudentClasses;
        private System.Windows.Forms.GroupBox grpClassStudents;
        private System.Windows.Forms.ComboBox cmbReportClass;
        private System.Windows.Forms.DataGridView dgvClassStudents;
        private System.Windows.Forms.Button btnManageEnrollments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button btnExit;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInstructors = new System.Windows.Forms.TabPage();
            this.dgvInstructors = new System.Windows.Forms.DataGridView();
            this.lblInstID = new System.Windows.Forms.Label();
            this.txtInstID = new System.Windows.Forms.TextBox();
            this.lblInstName = new System.Windows.Forms.Label();
            this.txtInstName = new System.Windows.Forms.TextBox();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.btnUpdateInstructor = new System.Windows.Forms.Button();
            this.btnClearInstructor = new System.Windows.Forms.Button();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtGradeLevel = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lblMeetingTime = new System.Windows.Forms.Label();
            this.txtMeetingTime = new System.Windows.Forms.TextBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnClearClass = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.grpInstructorClasses = new System.Windows.Forms.GroupBox();
            this.cmbReportInstructor = new System.Windows.Forms.ComboBox();
            this.dgvInstructorClasses = new System.Windows.Forms.DataGridView();
            this.grpStudentClasses = new System.Windows.Forms.GroupBox();
            this.cmbReportStudent = new System.Windows.Forms.ComboBox();
            this.dgvStudentClasses = new System.Windows.Forms.DataGridView();
            this.grpClassStudents = new System.Windows.Forms.GroupBox();
            this.cmbReportClass = new System.Windows.Forms.ComboBox();
            this.dgvClassStudents = new System.Windows.Forms.DataGridView();
            this.btnManageEnrollments = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInstructors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).BeginInit();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.tabReports.SuspendLayout();
            this.grpInstructorClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorClasses)).BeginInit();
            this.grpStudentClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).BeginInit();
            this.grpClassStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDatabaseConnectionToolStripMenuItem,
            this.manageEnrollmentsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // testDatabaseConnectionToolStripMenuItem
            // 
            this.testDatabaseConnectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.testDatabaseConnectionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.testDatabaseConnectionToolStripMenuItem.Name = "testDatabaseConnectionToolStripMenuItem";
            this.testDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.testDatabaseConnectionToolStripMenuItem.Text = "Test Database Connection";
            this.testDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.testDatabaseConnectionToolStripMenuItem_Click);
            // 
            // manageEnrollmentsToolStripMenuItem
            // 
            this.manageEnrollmentsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.manageEnrollmentsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.manageEnrollmentsToolStripMenuItem.Name = "manageEnrollmentsToolStripMenuItem";
            this.manageEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.manageEnrollmentsToolStripMenuItem.Text = "Manage Enrollments";
            this.manageEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.manageEnrollmentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInstructors);
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabClasses);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInstructors
            // 
            this.tabInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabInstructors.Controls.Add(this.dgvInstructors);
            this.tabInstructors.Controls.Add(this.lblInstID);
            this.tabInstructors.Controls.Add(this.txtInstID);
            this.tabInstructors.Controls.Add(this.lblInstName);
            this.tabInstructors.Controls.Add(this.txtInstName);
            this.tabInstructors.Controls.Add(this.btnAddInstructor);
            this.tabInstructors.Controls.Add(this.btnUpdateInstructor);
            this.tabInstructors.Controls.Add(this.btnClearInstructor);
            this.tabInstructors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabInstructors.Location = new System.Drawing.Point(4, 25);
            this.tabInstructors.Name = "tabInstructors";
            this.tabInstructors.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructors.Size = new System.Drawing.Size(992, 547);
            this.tabInstructors.TabIndex = 0;
            this.tabInstructors.Text = "Instructors";
            // 
            // dgvInstructors
            // 
            this.dgvInstructors.AllowUserToAddRows = false;
            this.dgvInstructors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvInstructors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvInstructors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInstructors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Lato", 9F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructors.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvInstructors.Location = new System.Drawing.Point(20, 20);
            this.dgvInstructors.Name = "dgvInstructors";
            this.dgvInstructors.ReadOnly = true;
            this.dgvInstructors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructors.Size = new System.Drawing.Size(950, 300);
            this.dgvInstructors.TabIndex = 0;
            this.dgvInstructors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructors_CellClick);
            // 
            // lblInstID
            // 
            this.lblInstID.AutoSize = true;
            this.lblInstID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblInstID.Location = new System.Drawing.Point(20, 350);
            this.lblInstID.Name = "lblInstID";
            this.lblInstID.Size = new System.Drawing.Size(89, 15);
            this.lblInstID.TabIndex = 1;
            this.lblInstID.Text = "Instructor ID:";
            // 
            // txtInstID
            // 
            this.txtInstID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInstID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtInstID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtInstID.Location = new System.Drawing.Point(120, 347);
            this.txtInstID.Name = "txtInstID";
            this.txtInstID.Size = new System.Drawing.Size(100, 22);
            this.txtInstID.TabIndex = 2;
            // 
            // lblInstName
            // 
            this.lblInstName.AutoSize = true;
            this.lblInstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblInstName.Location = new System.Drawing.Point(20, 380);
            this.lblInstName.Name = "lblInstName";
            this.lblInstName.Size = new System.Drawing.Size(49, 15);
            this.lblInstName.TabIndex = 3;
            this.lblInstName.Text = "Name:";
            // 
            // txtInstName
            // 
            this.txtInstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtInstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstName.Font = new System.Drawing.Font("Lato", 9F);
            this.txtInstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtInstName.Location = new System.Drawing.Point(120, 377);
            this.txtInstName.Name = "txtInstName";
            this.txtInstName.Size = new System.Drawing.Size(300, 22);
            this.txtInstName.TabIndex = 4;
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddInstructor.Location = new System.Drawing.Point(20, 420);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnAddInstructor.TabIndex = 5;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // btnUpdateInstructor
            // 
            this.btnUpdateInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnUpdateInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateInstructor.Location = new System.Drawing.Point(140, 420);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateInstructor.TabIndex = 6;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.UseVisualStyleBackColor = false;
            this.btnUpdateInstructor.Click += new System.EventHandler(this.btnUpdateInstructor_Click);
            // 
            // btnClearInstructor
            // 
            this.btnClearInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.btnClearInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearInstructor.Location = new System.Drawing.Point(260, 420);
            this.btnClearInstructor.Name = "btnClearInstructor";
            this.btnClearInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnClearInstructor.TabIndex = 7;
            this.btnClearInstructor.Text = "Clear";
            this.btnClearInstructor.UseVisualStyleBackColor = false;
            this.btnClearInstructor.Click += new System.EventHandler(this.btnClearInstructor_Click);
            // 
            // tabStudents
            // 
            this.tabStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.lblStudentID);
            this.tabStudents.Controls.Add(this.txtStudentID);
            this.tabStudents.Controls.Add(this.lblStudentName);
            this.tabStudents.Controls.Add(this.txtStudentName);
            this.tabStudents.Controls.Add(this.lblMajor);
            this.tabStudents.Controls.Add(this.txtMajor);
            this.tabStudents.Controls.Add(this.lblGradeLevel);
            this.tabStudents.Controls.Add(this.txtGradeLevel);
            this.tabStudents.Controls.Add(this.lblAge);
            this.tabStudents.Controls.Add(this.txtAge);
            this.tabStudents.Controls.Add(this.btnAddStudent);
            this.tabStudents.Controls.Add(this.btnUpdateStudent);
            this.tabStudents.Controls.Add(this.btnClearStudent);
            this.tabStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabStudents.Location = new System.Drawing.Point(4, 25);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(992, 547);
            this.tabStudents.TabIndex = 1;
            this.tabStudents.Text = "Students";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Lato", 9F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvStudents.Location = new System.Drawing.Point(20, 20);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(950, 300);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblStudentID.Location = new System.Drawing.Point(20, 350);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(78, 15);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStudentID.Location = new System.Drawing.Point(120, 347);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblStudentName.Location = new System.Drawing.Point(20, 380);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(49, 15);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Font = new System.Drawing.Font("Lato", 9F);
            this.txtStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStudentName.Location = new System.Drawing.Point(120, 377);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(300, 22);
            this.txtStudentName.TabIndex = 4;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMajor.Location = new System.Drawing.Point(20, 410);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(48, 15);
            this.lblMajor.TabIndex = 5;
            this.lblMajor.Text = "Major:";
            // 
            // txtMajor
            // 
            this.txtMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajor.Font = new System.Drawing.Font("Lato", 9F);
            this.txtMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMajor.Location = new System.Drawing.Point(120, 407);
            this.txtMajor.MaxLength = 5;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 22);
            this.txtMajor.TabIndex = 6;
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblGradeLevel.Location = new System.Drawing.Point(250, 410);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(88, 15);
            this.lblGradeLevel.TabIndex = 7;
            this.lblGradeLevel.Text = "Grade Level:";
            // 
            // txtGradeLevel
            // 
            this.txtGradeLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtGradeLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeLevel.Font = new System.Drawing.Font("Lato", 9F);
            this.txtGradeLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtGradeLevel.Location = new System.Drawing.Point(350, 407);
            this.txtGradeLevel.MaxLength = 2;
            this.txtGradeLevel.Name = "txtGradeLevel";
            this.txtGradeLevel.Size = new System.Drawing.Size(50, 22);
            this.txtGradeLevel.TabIndex = 8;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblAge.Location = new System.Drawing.Point(420, 410);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(35, 15);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Lato", 9F);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAge.Location = new System.Drawing.Point(460, 407);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 22);
            this.txtAge.TabIndex = 10;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddStudent.Location = new System.Drawing.Point(20, 450);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 30);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(140, 450);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateStudent.TabIndex = 12;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.btnClearStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearStudent.Location = new System.Drawing.Point(260, 450);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(100, 30);
            this.btnClearStudent.TabIndex = 13;
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.UseVisualStyleBackColor = false;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // tabClasses
            // 
            this.tabClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabClasses.Controls.Add(this.dgvClasses);
            this.tabClasses.Controls.Add(this.lblClassID);
            this.tabClasses.Controls.Add(this.txtClassID);
            this.tabClasses.Controls.Add(this.lblMeetingTime);
            this.tabClasses.Controls.Add(this.txtMeetingTime);
            this.tabClasses.Controls.Add(this.lblInstructor);
            this.tabClasses.Controls.Add(this.cmbInstructor);
            this.tabClasses.Controls.Add(this.lblRoom);
            this.tabClasses.Controls.Add(this.txtRoom);
            this.tabClasses.Controls.Add(this.btnAddClass);
            this.tabClasses.Controls.Add(this.btnUpdateClass);
            this.tabClasses.Controls.Add(this.btnClearClass);
            this.tabClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabClasses.Location = new System.Drawing.Point(4, 25);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Size = new System.Drawing.Size(992, 547);
            this.tabClasses.TabIndex = 2;
            this.tabClasses.Text = "Classes";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Lato", 9F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClasses.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvClasses.Location = new System.Drawing.Point(20, 20);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(950, 300);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblClassID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblClassID.Location = new System.Drawing.Point(20, 350);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(64, 15);
            this.lblClassID.TabIndex = 1;
            this.lblClassID.Text = "Class ID:";
            // 
            // txtClassID
            // 
            this.txtClassID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtClassID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtClassID.Location = new System.Drawing.Point(120, 347);
            this.txtClassID.MaxLength = 8;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(100, 22);
            this.txtClassID.TabIndex = 2;
            // 
            // lblMeetingTime
            // 
            this.lblMeetingTime.AutoSize = true;
            this.lblMeetingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblMeetingTime.Location = new System.Drawing.Point(20, 380);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(99, 15);
            this.lblMeetingTime.TabIndex = 3;
            this.lblMeetingTime.Text = "Meeting Time:";
            // 
            // txtMeetingTime
            // 
            this.txtMeetingTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMeetingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeetingTime.Font = new System.Drawing.Font("Lato", 9F);
            this.txtMeetingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMeetingTime.Location = new System.Drawing.Point(120, 377);
            this.txtMeetingTime.MaxLength = 5;
            this.txtMeetingTime.Name = "txtMeetingTime";
            this.txtMeetingTime.Size = new System.Drawing.Size(100, 22);
            this.txtMeetingTime.TabIndex = 4;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblInstructor.Location = new System.Drawing.Point(250, 380);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(71, 15);
            this.lblInstructor.TabIndex = 5;
            this.lblInstructor.Text = "Instructor:";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructor.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(320, 377);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(200, 23);
            this.cmbInstructor.TabIndex = 6;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblRoom.Location = new System.Drawing.Point(20, 410);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(49, 15);
            this.lblRoom.TabIndex = 7;
            this.lblRoom.Text = "Room:";
            // 
            // txtRoom
            // 
            this.txtRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Font = new System.Drawing.Font("Lato", 9F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRoom.Location = new System.Drawing.Point(120, 407);
            this.txtRoom.MaxLength = 7;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 22);
            this.txtRoom.TabIndex = 8;
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddClass.Location = new System.Drawing.Point(20, 450);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(100, 30);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateClass.Location = new System.Drawing.Point(140, 450);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateClass.TabIndex = 10;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // btnClearClass
            // 
            this.btnClearClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.btnClearClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearClass.Location = new System.Drawing.Point(260, 450);
            this.btnClearClass.Name = "btnClearClass";
            this.btnClearClass.Size = new System.Drawing.Size(100, 30);
            this.btnClearClass.TabIndex = 11;
            this.btnClearClass.Text = "Clear";
            this.btnClearClass.UseVisualStyleBackColor = false;
            this.btnClearClass.Click += new System.EventHandler(this.btnClearClass_Click);
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabReports.Controls.Add(this.grpInstructorClasses);
            this.tabReports.Controls.Add(this.grpStudentClasses);
            this.tabReports.Controls.Add(this.grpClassStudents);
            this.tabReports.Controls.Add(this.btnManageEnrollments);
            this.tabReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(992, 547);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            // 
            // grpInstructorClasses
            // 
            this.grpInstructorClasses.Controls.Add(this.cmbReportInstructor);
            this.grpInstructorClasses.Controls.Add(this.dgvInstructorClasses);
            this.grpInstructorClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpInstructorClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.grpInstructorClasses.Location = new System.Drawing.Point(20, 20);
            this.grpInstructorClasses.Name = "grpInstructorClasses";
            this.grpInstructorClasses.Size = new System.Drawing.Size(450, 250);
            this.grpInstructorClasses.TabIndex = 0;
            this.grpInstructorClasses.TabStop = false;
            this.grpInstructorClasses.Text = "Classes by Instructor";
            // 
            // cmbReportInstructor
            // 
            this.cmbReportInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportInstructor.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportInstructor.FormattingEnabled = true;
            this.cmbReportInstructor.Location = new System.Drawing.Point(20, 25);
            this.cmbReportInstructor.Name = "cmbReportInstructor";
            this.cmbReportInstructor.Size = new System.Drawing.Size(300, 23);
            this.cmbReportInstructor.TabIndex = 0;
            this.cmbReportInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbReportInstructor_SelectedIndexChanged);
            // 
            // dgvInstructorClasses
            // 
            this.dgvInstructorClasses.AllowUserToAddRows = false;
            this.dgvInstructorClasses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvInstructorClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvInstructorClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInstructorClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInstructorClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvInstructorClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Lato", 8F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructorClasses.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvInstructorClasses.Location = new System.Drawing.Point(20, 60);
            this.dgvInstructorClasses.Name = "dgvInstructorClasses";
            this.dgvInstructorClasses.ReadOnly = true;
            this.dgvInstructorClasses.Size = new System.Drawing.Size(410, 180);
            this.dgvInstructorClasses.TabIndex = 1;
            // 
            // grpStudentClasses
            // 
            this.grpStudentClasses.Controls.Add(this.cmbReportStudent);
            this.grpStudentClasses.Controls.Add(this.dgvStudentClasses);
            this.grpStudentClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.grpStudentClasses.Location = new System.Drawing.Point(490, 20);
            this.grpStudentClasses.Name = "grpStudentClasses";
            this.grpStudentClasses.Size = new System.Drawing.Size(480, 250);
            this.grpStudentClasses.TabIndex = 1;
            this.grpStudentClasses.TabStop = false;
            this.grpStudentClasses.Text = "Classes by Student";
            // 
            // cmbReportStudent
            // 
            this.cmbReportStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportStudent.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportStudent.FormattingEnabled = true;
            this.cmbReportStudent.Location = new System.Drawing.Point(20, 25);
            this.cmbReportStudent.Name = "cmbReportStudent";
            this.cmbReportStudent.Size = new System.Drawing.Size(300, 23);
            this.cmbReportStudent.TabIndex = 0;
            this.cmbReportStudent.SelectedIndexChanged += new System.EventHandler(this.cmbReportStudent_SelectedIndexChanged);
            // 
            // dgvStudentClasses
            // 
            this.dgvStudentClasses.AllowUserToAddRows = false;
            this.dgvStudentClasses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvStudentClasses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvStudentClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStudentClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvStudentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Lato", 8F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentClasses.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvStudentClasses.Location = new System.Drawing.Point(20, 60);
            this.dgvStudentClasses.Name = "dgvStudentClasses";
            this.dgvStudentClasses.ReadOnly = true;
            this.dgvStudentClasses.Size = new System.Drawing.Size(440, 180);
            this.dgvStudentClasses.TabIndex = 1;
            // 
            // grpClassStudents
            // 
            this.grpClassStudents.Controls.Add(this.cmbReportClass);
            this.grpClassStudents.Controls.Add(this.dgvClassStudents);
            this.grpClassStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpClassStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.grpClassStudents.Location = new System.Drawing.Point(20, 316);
            this.grpClassStudents.Name = "grpClassStudents";
            this.grpClassStudents.Size = new System.Drawing.Size(950, 250);
            this.grpClassStudents.TabIndex = 2;
            this.grpClassStudents.TabStop = false;
            this.grpClassStudents.Text = "Students by Class";
            // 
            // cmbReportClass
            // 
            this.cmbReportClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbReportClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportClass.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbReportClass.FormattingEnabled = true;
            this.cmbReportClass.Location = new System.Drawing.Point(20, 25);
            this.cmbReportClass.Name = "cmbReportClass";
            this.cmbReportClass.Size = new System.Drawing.Size(300, 23);
            this.cmbReportClass.TabIndex = 0;
            this.cmbReportClass.SelectedIndexChanged += new System.EventHandler(this.cmbReportClass_SelectedIndexChanged);
            // 
            // dgvClassStudents
            // 
            this.dgvClassStudents.AllowUserToAddRows = false;
            this.dgvClassStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dgvClassStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvClassStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvClassStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Lato", 8F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClassStudents.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvClassStudents.Location = new System.Drawing.Point(20, 60);
            this.dgvClassStudents.Name = "dgvClassStudents";
            this.dgvClassStudents.ReadOnly = true;
            this.dgvClassStudents.Size = new System.Drawing.Size(910, 180);
            this.dgvClassStudents.TabIndex = 1;
            // 
            // btnManageEnrollments
            // 
            this.btnManageEnrollments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(34)))), ((int)(((byte)(53)))));
            this.btnManageEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageEnrollments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnManageEnrollments.Location = new System.Drawing.Point(400, 276);
            this.btnManageEnrollments.Name = "btnManageEnrollments";
            this.btnManageEnrollments.Size = new System.Drawing.Size(165, 44);
            this.btnManageEnrollments.TabIndex = 3;
            this.btnManageEnrollments.Text = "Manage Enrollments";
            this.btnManageEnrollments.UseVisualStyleBackColor = false;
            this.btnManageEnrollments.Click += new System.EventHandler(this.btnManageEnrollments_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(900, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arkansas Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabInstructors.ResumeLayout(false);
            this.tabInstructors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).EndInit();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabClasses.ResumeLayout(false);
            this.tabClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.grpInstructorClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorClasses)).EndInit();
            this.grpStudentClasses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).EndInit();
            this.grpClassStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}