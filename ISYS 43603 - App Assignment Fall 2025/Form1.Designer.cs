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

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testDatabaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();

            // Arkansas Razorback Colors
            System.Drawing.Color razorbackRed = System.Drawing.Color.FromArgb(157, 34, 53);      // #9D2235
            System.Drawing.Color razorbackWhite = System.Drawing.Color.FromArgb(255, 255, 255);   // #FFFFFF  
            System.Drawing.Color razorbackLightGray = System.Drawing.Color.FromArgb(242, 242, 244); // #F2F2F4
            System.Drawing.Color razorbackMediumGray = System.Drawing.Color.FromArgb(199, 200, 202); // #C7C8CA
            System.Drawing.Color razorbackDarkGray = System.Drawing.Color.FromArgb(66, 66, 66);   // #424242
            System.Drawing.Color razorbackBlack = System.Drawing.Color.FromArgb(0, 0, 0);         // #000000

            this.tabInstructors = new System.Windows.Forms.TabPage();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.tabClasses = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();

            // Initialize Instructors Controls
            this.dgvInstructors = new System.Windows.Forms.DataGridView();
            this.txtInstID = new System.Windows.Forms.TextBox();
            this.txtInstName = new System.Windows.Forms.TextBox();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.btnUpdateInstructor = new System.Windows.Forms.Button();
            this.btnClearInstructor = new System.Windows.Forms.Button();
            this.lblInstID = new System.Windows.Forms.Label();
            this.lblInstName = new System.Windows.Forms.Label();

            // Initialize Students Controls
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtGradeLevel = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();

            // Initialize Classes Controls
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtMeetingTime = new System.Windows.Forms.TextBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.btnClearClass = new System.Windows.Forms.Button();
            this.lblClassID = new System.Windows.Forms.Label();
            this.lblMeetingTime = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();

            // Initialize Reports Controls
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

            this.tabControl1.SuspendLayout();
            this.tabInstructors.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabClasses.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).BeginInit();
            this.grpInstructorClasses.SuspendLayout();
            this.grpStudentClasses.SuspendLayout();
            this.grpClassStudents.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.BackColor = razorbackLightGray;
            this.ForeColor = razorbackDarkGray;
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arkansas Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);

            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = razorbackRed;
            this.menuStrip1.ForeColor = razorbackWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
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
            this.toolsToolStripMenuItem.BackColor = razorbackRed;
            this.toolsToolStripMenuItem.ForeColor = razorbackWhite;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testDatabaseConnectionToolStripMenuItem,
            this.manageEnrollmentsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";

            // 
            // testDatabaseConnectionToolStripMenuItem
            // 
            this.testDatabaseConnectionToolStripMenuItem.BackColor = razorbackWhite;
            this.testDatabaseConnectionToolStripMenuItem.ForeColor = razorbackDarkGray;
            this.testDatabaseConnectionToolStripMenuItem.Name = "testDatabaseConnectionToolStripMenuItem";
            this.testDatabaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.testDatabaseConnectionToolStripMenuItem.Text = "Test Database Connection";
            this.testDatabaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.testDatabaseConnectionToolStripMenuItem_Click);

            // 
            // manageEnrollmentsToolStripMenuItem
            // 
            this.manageEnrollmentsToolStripMenuItem.BackColor = razorbackWhite;
            this.manageEnrollmentsToolStripMenuItem.ForeColor = razorbackDarkGray;
            this.manageEnrollmentsToolStripMenuItem.Name = "manageEnrollmentsToolStripMenuItem";
            this.manageEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.manageEnrollmentsToolStripMenuItem.Text = "Manage Enrollments";
            this.manageEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.manageEnrollmentsToolStripMenuItem_Click);

            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = razorbackWhite;
            this.exitToolStripMenuItem.ForeColor = razorbackDarkGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
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
            this.tabControl1.Font = new System.Drawing.Font("Myriad Pro", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 576);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.BackColor = razorbackMediumGray;
            this.tabControl1.ForeColor = razorbackDarkGray;

            // 
            // INSTRUCTORS TAB
            // 
            this.tabInstructors.Controls.Add(this.dgvInstructors);
            this.tabInstructors.Controls.Add(this.lblInstID);
            this.tabInstructors.Controls.Add(this.txtInstID);
            this.tabInstructors.Controls.Add(this.lblInstName);
            this.tabInstructors.Controls.Add(this.txtInstName);
            this.tabInstructors.Controls.Add(this.btnAddInstructor);
            this.tabInstructors.Controls.Add(this.btnUpdateInstructor);
            this.tabInstructors.Controls.Add(this.btnClearInstructor);
            this.tabInstructors.Location = new System.Drawing.Point(4, 22);
            this.tabInstructors.Name = "tabInstructors";
            this.tabInstructors.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructors.Size = new System.Drawing.Size(992, 574);
            this.tabInstructors.TabIndex = 0;
            this.tabInstructors.Text = "Instructors";
            this.tabInstructors.BackColor = razorbackWhite;
            this.tabInstructors.ForeColor = razorbackDarkGray;
            this.tabInstructors.UseVisualStyleBackColor = false;

            // dgvInstructors
            this.dgvInstructors.AllowUserToAddRows = false;
            this.dgvInstructors.AllowUserToDeleteRows = false;
            this.dgvInstructors.BackgroundColor = razorbackWhite;
            this.dgvInstructors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstructors.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvInstructors.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvInstructors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.dgvInstructors.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvInstructors.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvInstructors.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 9F);
            this.dgvInstructors.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvInstructors.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvInstructors.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructors.Location = new System.Drawing.Point(20, 20);
            this.dgvInstructors.Name = "dgvInstructors";
            this.dgvInstructors.ReadOnly = true;
            this.dgvInstructors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructors.Size = new System.Drawing.Size(950, 300);
            this.dgvInstructors.TabIndex = 0;
            this.dgvInstructors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructors_CellClick);

            // Instructor form controls
            this.lblInstID.AutoSize = true;
            this.lblInstID.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstID.ForeColor = razorbackDarkGray;
            this.lblInstID.Location = new System.Drawing.Point(20, 350);
            this.lblInstID.Name = "lblInstID";
            this.lblInstID.Size = new System.Drawing.Size(70, 13);
            this.lblInstID.TabIndex = 1;
            this.lblInstID.Text = "Instructor ID:";

            this.txtInstID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtInstID.BackColor = razorbackWhite;
            this.txtInstID.ForeColor = razorbackBlack;
            this.txtInstID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstID.Location = new System.Drawing.Point(120, 347);
            this.txtInstID.Name = "txtInstID";
            this.txtInstID.Size = new System.Drawing.Size(100, 20);
            this.txtInstID.TabIndex = 2;

            this.lblInstName.AutoSize = true;
            this.lblInstName.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstName.ForeColor = razorbackDarkGray;
            this.lblInstName.Location = new System.Drawing.Point(20, 380);
            this.lblInstName.Name = "lblInstName";
            this.lblInstName.Size = new System.Drawing.Size(38, 13);
            this.lblInstName.TabIndex = 3;
            this.lblInstName.Text = "Name:";

            this.txtInstName.Font = new System.Drawing.Font("Lato", 9F);
            this.txtInstName.BackColor = razorbackWhite;
            this.txtInstName.ForeColor = razorbackBlack;
            this.txtInstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstName.Location = new System.Drawing.Point(120, 377);
            this.txtInstName.Name = "txtInstName";
            this.txtInstName.Size = new System.Drawing.Size(300, 20);
            this.txtInstName.TabIndex = 4;

            this.btnAddInstructor.BackColor = razorbackRed;
            this.btnAddInstructor.ForeColor = razorbackWhite;
            this.btnAddInstructor.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Location = new System.Drawing.Point(20, 420);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnAddInstructor.TabIndex = 5;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);

            this.btnUpdateInstructor.BackColor = razorbackDarkGray;
            this.btnUpdateInstructor.ForeColor = razorbackWhite;
            this.btnUpdateInstructor.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInstructor.Location = new System.Drawing.Point(140, 420);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateInstructor.TabIndex = 6;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.UseVisualStyleBackColor = false;
            this.btnUpdateInstructor.Click += new System.EventHandler(this.btnUpdateInstructor_Click);

            this.btnClearInstructor.BackColor = razorbackMediumGray;
            this.btnClearInstructor.ForeColor = razorbackBlack;
            this.btnClearInstructor.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInstructor.Location = new System.Drawing.Point(260, 420);
            this.btnClearInstructor.Name = "btnClearInstructor";
            this.btnClearInstructor.Size = new System.Drawing.Size(100, 30);
            this.btnClearInstructor.TabIndex = 7;
            this.btnClearInstructor.Text = "Clear";
            this.btnClearInstructor.UseVisualStyleBackColor = false;
            this.btnClearInstructor.Click += new System.EventHandler(this.btnClearInstructor_Click);

            // 
            // STUDENTS TAB
            // 
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
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(992, 574);
            this.tabStudents.TabIndex = 1;
            this.tabStudents.Text = "Students";
            this.tabStudents.BackColor = razorbackWhite;
            this.tabStudents.ForeColor = razorbackDarkGray;
            this.tabStudents.UseVisualStyleBackColor = false;

            // dgvStudents
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = razorbackWhite;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.dgvStudents.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvStudents.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvStudents.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 9F);
            this.dgvStudents.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvStudents.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(20, 20);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(950, 300);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);

            // Student form controls
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = razorbackDarkGray;
            this.lblStudentID.Location = new System.Drawing.Point(20, 350);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Student ID:";

            this.txtStudentID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtStudentID.BackColor = razorbackWhite;
            this.txtStudentID.ForeColor = razorbackBlack;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Location = new System.Drawing.Point(120, 347);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 2;

            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = razorbackDarkGray;
            this.lblStudentName.Location = new System.Drawing.Point(20, 380);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(38, 13);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Name:";

            this.txtStudentName.Font = new System.Drawing.Font("Lato", 9F);
            this.txtStudentName.BackColor = razorbackWhite;
            this.txtStudentName.ForeColor = razorbackBlack;
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Location = new System.Drawing.Point(120, 377);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(300, 20);
            this.txtStudentName.TabIndex = 4;

            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblMajor.ForeColor = razorbackDarkGray;
            this.lblMajor.Location = new System.Drawing.Point(20, 410);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(36, 13);
            this.lblMajor.TabIndex = 5;
            this.lblMajor.Text = "Major:";

            this.txtMajor.Font = new System.Drawing.Font("Lato", 9F);
            this.txtMajor.BackColor = razorbackWhite;
            this.txtMajor.ForeColor = razorbackBlack;
            this.txtMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajor.Location = new System.Drawing.Point(120, 407);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 20);
            this.txtMajor.TabIndex = 6;
            this.txtMajor.MaxLength = 5;

            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradeLevel.ForeColor = razorbackDarkGray;
            this.lblGradeLevel.Location = new System.Drawing.Point(250, 410);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(70, 13);
            this.lblGradeLevel.TabIndex = 7;
            this.lblGradeLevel.Text = "Grade Level:";

            this.txtGradeLevel.Font = new System.Drawing.Font("Lato", 9F);
            this.txtGradeLevel.BackColor = razorbackWhite;
            this.txtGradeLevel.ForeColor = razorbackBlack;
            this.txtGradeLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGradeLevel.Location = new System.Drawing.Point(330, 407);
            this.txtGradeLevel.Name = "txtGradeLevel";
            this.txtGradeLevel.Size = new System.Drawing.Size(50, 20);
            this.txtGradeLevel.TabIndex = 8;
            this.txtGradeLevel.MaxLength = 2;

            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = razorbackDarkGray;
            this.lblAge.Location = new System.Drawing.Point(400, 410);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age:";

            this.txtAge.Font = new System.Drawing.Font("Lato", 9F);
            this.txtAge.BackColor = razorbackWhite;
            this.txtAge.ForeColor = razorbackBlack;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(440, 407);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 20);
            this.txtAge.TabIndex = 10;

            this.btnAddStudent.BackColor = razorbackRed;
            this.btnAddStudent.ForeColor = razorbackWhite;
            this.btnAddStudent.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(20, 450);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(100, 30);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            this.btnUpdateStudent.BackColor = razorbackDarkGray;
            this.btnUpdateStudent.ForeColor = razorbackWhite;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Location = new System.Drawing.Point(140, 450);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateStudent.TabIndex = 12;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);

            this.btnClearStudent.BackColor = razorbackMediumGray;
            this.btnClearStudent.ForeColor = razorbackBlack;
            this.btnClearStudent.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStudent.Location = new System.Drawing.Point(260, 450);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(100, 30);
            this.btnClearStudent.TabIndex = 13;
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.UseVisualStyleBackColor = false;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);

            // 
            // CLASSES TAB
            // 
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
            this.tabClasses.Location = new System.Drawing.Point(4, 22);
            this.tabClasses.Name = "tabClasses";
            this.tabClasses.Size = new System.Drawing.Size(992, 574);
            this.tabClasses.TabIndex = 2;
            this.tabClasses.Text = "Classes";
            this.tabClasses.BackColor = razorbackWhite;
            this.tabClasses.ForeColor = razorbackDarkGray;
            this.tabClasses.UseVisualStyleBackColor = false;

            // dgvClasses
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.BackgroundColor = razorbackWhite;
            this.dgvClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClasses.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvClasses.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvClasses.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.dgvClasses.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvClasses.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvClasses.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 9F);
            this.dgvClasses.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvClasses.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvClasses.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(20, 20);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClasses.Size = new System.Drawing.Size(950, 300);
            this.dgvClasses.TabIndex = 0;
            this.dgvClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellClick);

            // Class form controls
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblClassID.ForeColor = razorbackDarkGray;
            this.lblClassID.Location = new System.Drawing.Point(20, 350);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(52, 13);
            this.lblClassID.TabIndex = 1;
            this.lblClassID.Text = "Class ID:";

            this.txtClassID.Font = new System.Drawing.Font("Lato", 9F);
            this.txtClassID.BackColor = razorbackWhite;
            this.txtClassID.ForeColor = razorbackBlack;
            this.txtClassID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassID.Location = new System.Drawing.Point(120, 347);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(100, 20);
            this.txtClassID.TabIndex = 2;
            this.txtClassID.MaxLength = 8;

            this.lblMeetingTime.AutoSize = true;
            this.lblMeetingTime.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblMeetingTime.ForeColor = razorbackDarkGray;
            this.lblMeetingTime.Location = new System.Drawing.Point(20, 380);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(76, 13);
            this.lblMeetingTime.TabIndex = 3;
            this.lblMeetingTime.Text = "Meeting Time:";

            this.txtMeetingTime.Font = new System.Drawing.Font("Lato", 9F);
            this.txtMeetingTime.BackColor = razorbackWhite;
            this.txtMeetingTime.ForeColor = razorbackBlack;
            this.txtMeetingTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeetingTime.Location = new System.Drawing.Point(120, 377);
            this.txtMeetingTime.Name = "txtMeetingTime";
            this.txtMeetingTime.Size = new System.Drawing.Size(100, 20);
            this.txtMeetingTime.TabIndex = 4;
            this.txtMeetingTime.MaxLength = 5;

            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblInstructor.ForeColor = razorbackDarkGray;
            this.lblInstructor.Location = new System.Drawing.Point(250, 380);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(57, 13);
            this.lblInstructor.TabIndex = 5;
            this.lblInstructor.Text = "Instructor:";

            this.cmbInstructor.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbInstructor.BackColor = razorbackWhite;
            this.cmbInstructor.ForeColor = razorbackBlack;
            this.cmbInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(320, 377);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(200, 21);
            this.cmbInstructor.TabIndex = 6;
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoom.ForeColor = razorbackDarkGray;
            this.lblRoom.Location = new System.Drawing.Point(20, 410);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 7;
            this.lblRoom.Text = "Room:";

            this.txtRoom.Font = new System.Drawing.Font("Lato", 9F);
            this.txtRoom.BackColor = razorbackWhite;
            this.txtRoom.ForeColor = razorbackBlack;
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoom.Location = new System.Drawing.Point(120, 407);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(100, 20);
            this.txtRoom.TabIndex = 8;
            this.txtRoom.MaxLength = 7;

            this.btnAddClass.BackColor = razorbackRed;
            this.btnAddClass.ForeColor = razorbackWhite;
            this.btnAddClass.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Location = new System.Drawing.Point(20, 450);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(100, 30);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);

            this.btnUpdateClass.BackColor = razorbackDarkGray;
            this.btnUpdateClass.ForeColor = razorbackWhite;
            this.btnUpdateClass.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClass.Location = new System.Drawing.Point(140, 450);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateClass.TabIndex = 10;
            this.btnUpdateClass.Text = "Update Class";
            this.btnUpdateClass.UseVisualStyleBackColor = false;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);

            this.btnClearClass.BackColor = razorbackMediumGray;
            this.btnClearClass.ForeColor = razorbackBlack;
            this.btnClearClass.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearClass.Location = new System.Drawing.Point(260, 450);
            this.btnClearClass.Name = "btnClearClass";
            this.btnClearClass.Size = new System.Drawing.Size(100, 30);
            this.btnClearClass.TabIndex = 11;
            this.btnClearClass.Text = "Clear";
            this.btnClearClass.UseVisualStyleBackColor = false;
            this.btnClearClass.Click += new System.EventHandler(this.btnClearClass_Click);

            // 
            // REPORTS TAB
            // 
            this.tabReports.Controls.Add(this.grpInstructorClasses);
            this.tabReports.Controls.Add(this.grpStudentClasses);
            this.tabReports.Controls.Add(this.grpClassStudents);
            this.tabReports.Controls.Add(this.btnManageEnrollments);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(992, 574);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.BackColor = razorbackWhite;
            this.tabReports.ForeColor = razorbackDarkGray;
            this.tabReports.UseVisualStyleBackColor = false;

            // Instructor Classes Group
            this.grpInstructorClasses.Controls.Add(this.cmbReportInstructor);
            this.grpInstructorClasses.Controls.Add(this.dgvInstructorClasses);
            this.grpInstructorClasses.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.grpInstructorClasses.ForeColor = razorbackDarkGray;
            this.grpInstructorClasses.Location = new System.Drawing.Point(20, 20);
            this.grpInstructorClasses.Name = "grpInstructorClasses";
            this.grpInstructorClasses.Size = new System.Drawing.Size(450, 250);
            this.grpInstructorClasses.TabIndex = 0;
            this.grpInstructorClasses.TabStop = false;
            this.grpInstructorClasses.Text = "Classes by Instructor";

            this.cmbReportInstructor.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportInstructor.BackColor = razorbackWhite;
            this.cmbReportInstructor.ForeColor = razorbackBlack;
            this.cmbReportInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReportInstructor.FormattingEnabled = true;
            this.cmbReportInstructor.Location = new System.Drawing.Point(20, 25);
            this.cmbReportInstructor.Name = "cmbReportInstructor";
            this.cmbReportInstructor.Size = new System.Drawing.Size(300, 21);
            this.cmbReportInstructor.TabIndex = 0;
            this.cmbReportInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportInstructor.SelectedIndexChanged += new System.EventHandler(this.cmbReportInstructor_SelectedIndexChanged);

            this.dgvInstructorClasses.AllowUserToAddRows = false;
            this.dgvInstructorClasses.AllowUserToDeleteRows = false;
            this.dgvInstructorClasses.BackgroundColor = razorbackWhite;
            this.dgvInstructorClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstructorClasses.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvInstructorClasses.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvInstructorClasses.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 8F, System.Drawing.FontStyle.Bold);
            this.dgvInstructorClasses.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvInstructorClasses.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvInstructorClasses.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 8F);
            this.dgvInstructorClasses.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvInstructorClasses.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvInstructorClasses.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvInstructorClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructorClasses.Location = new System.Drawing.Point(20, 60);
            this.dgvInstructorClasses.Name = "dgvInstructorClasses";
            this.dgvInstructorClasses.ReadOnly = true;
            this.dgvInstructorClasses.Size = new System.Drawing.Size(410, 180);
            this.dgvInstructorClasses.TabIndex = 1;

            // Student Classes Group
            this.grpStudentClasses.Controls.Add(this.cmbReportStudent);
            this.grpStudentClasses.Controls.Add(this.dgvStudentClasses);
            this.grpStudentClasses.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudentClasses.ForeColor = razorbackDarkGray;
            this.grpStudentClasses.Location = new System.Drawing.Point(490, 20);
            this.grpStudentClasses.Name = "grpStudentClasses";
            this.grpStudentClasses.Size = new System.Drawing.Size(480, 250);
            this.grpStudentClasses.TabIndex = 1;
            this.grpStudentClasses.TabStop = false;
            this.grpStudentClasses.Text = "Classes by Student";

            this.cmbReportStudent.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportStudent.BackColor = razorbackWhite;
            this.cmbReportStudent.ForeColor = razorbackBlack;
            this.cmbReportStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReportStudent.FormattingEnabled = true;
            this.cmbReportStudent.Location = new System.Drawing.Point(20, 25);
            this.cmbReportStudent.Name = "cmbReportStudent";
            this.cmbReportStudent.Size = new System.Drawing.Size(300, 21);
            this.cmbReportStudent.TabIndex = 0;
            this.cmbReportStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportStudent.SelectedIndexChanged += new System.EventHandler(this.cmbReportStudent_SelectedIndexChanged);

            this.dgvStudentClasses.AllowUserToAddRows = false;
            this.dgvStudentClasses.AllowUserToDeleteRows = false;
            this.dgvStudentClasses.BackgroundColor = razorbackWhite;
            this.dgvStudentClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudentClasses.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvStudentClasses.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvStudentClasses.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 8F, System.Drawing.FontStyle.Bold);
            this.dgvStudentClasses.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvStudentClasses.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvStudentClasses.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 8F);
            this.dgvStudentClasses.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvStudentClasses.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvStudentClasses.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvStudentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentClasses.Location = new System.Drawing.Point(20, 60);
            this.dgvStudentClasses.Name = "dgvStudentClasses";
            this.dgvStudentClasses.ReadOnly = true;
            this.dgvStudentClasses.Size = new System.Drawing.Size(440, 180);
            this.dgvStudentClasses.TabIndex = 1;

            // Class Students Group
            this.grpClassStudents.Controls.Add(this.cmbReportClass);
            this.grpClassStudents.Controls.Add(this.dgvClassStudents);
            this.grpClassStudents.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.grpClassStudents.ForeColor = razorbackDarkGray;
            this.grpClassStudents.Location = new System.Drawing.Point(20, 290);
            this.grpClassStudents.Name = "grpClassStudents";
            this.grpClassStudents.Size = new System.Drawing.Size(950, 250);
            this.grpClassStudents.TabIndex = 2;
            this.grpClassStudents.TabStop = false;
            this.grpClassStudents.Text = "Students by Class";

            this.cmbReportClass.Font = new System.Drawing.Font("Lato", 9F);
            this.cmbReportClass.BackColor = razorbackWhite;
            this.cmbReportClass.ForeColor = razorbackBlack;
            this.cmbReportClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReportClass.FormattingEnabled = true;
            this.cmbReportClass.Location = new System.Drawing.Point(20, 25);
            this.cmbReportClass.Name = "cmbReportClass";
            this.cmbReportClass.Size = new System.Drawing.Size(300, 21);
            this.cmbReportClass.TabIndex = 0;
            this.cmbReportClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportClass.SelectedIndexChanged += new System.EventHandler(this.cmbReportClass_SelectedIndexChanged);

            this.dgvClassStudents.AllowUserToAddRows = false;
            this.dgvClassStudents.AllowUserToDeleteRows = false;
            this.dgvClassStudents.BackgroundColor = razorbackWhite;
            this.dgvClassStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClassStudents.ColumnHeadersDefaultCellStyle.BackColor = razorbackRed;
            this.dgvClassStudents.ColumnHeadersDefaultCellStyle.ForeColor = razorbackWhite;
            this.dgvClassStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myriad Pro", 8F, System.Drawing.FontStyle.Bold);
            this.dgvClassStudents.DefaultCellStyle.BackColor = razorbackWhite;
            this.dgvClassStudents.DefaultCellStyle.ForeColor = razorbackDarkGray;
            this.dgvClassStudents.DefaultCellStyle.Font = new System.Drawing.Font("Lato", 8F);
            this.dgvClassStudents.DefaultCellStyle.SelectionBackColor = razorbackLightGray;
            this.dgvClassStudents.DefaultCellStyle.SelectionForeColor = razorbackBlack;
            this.dgvClassStudents.AlternatingRowsDefaultCellStyle.BackColor = razorbackLightGray;
            this.dgvClassStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassStudents.Location = new System.Drawing.Point(20, 60);
            this.dgvClassStudents.Name = "dgvClassStudents";
            this.dgvClassStudents.ReadOnly = true;
            this.dgvClassStudents.Size = new System.Drawing.Size(910, 180);
            this.dgvClassStudents.TabIndex = 1;

            // 
            // btnManageEnrollments
            // 
            this.btnManageEnrollments.BackColor = razorbackRed;
            this.btnManageEnrollments.ForeColor = razorbackWhite;
            this.btnManageEnrollments.Font = new System.Drawing.Font("Myriad Pro", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEnrollments.Location = new System.Drawing.Point(350, 25);
            this.btnManageEnrollments.Name = "btnManageEnrollments";
            this.btnManageEnrollments.Size = new System.Drawing.Size(150, 30);
            this.btnManageEnrollments.TabIndex = 3;
            this.btnManageEnrollments.Text = "Manage Enrollments";
            this.btnManageEnrollments.UseVisualStyleBackColor = false;
            this.btnManageEnrollments.Click += new System.EventHandler(this.btnManageEnrollments_Click);

            // Finish initialization
            this.tabControl1.ResumeLayout(false);
            this.tabInstructors.ResumeLayout(false);
            this.tabInstructors.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            this.tabStudents.PerformLayout();
            this.tabClasses.ResumeLayout(false);
            this.tabClasses.PerformLayout();
            this.tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructorClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassStudents)).EndInit();
            this.grpInstructorClasses.ResumeLayout(false);
            this.grpStudentClasses.ResumeLayout(false);
            this.grpClassStudents.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}