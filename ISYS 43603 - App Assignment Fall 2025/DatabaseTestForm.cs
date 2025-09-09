using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ISYS_43603___App_Assignment_Fall_2025
{
    public partial class DatabaseTestForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTestConnection;
        private Button btnValidateTables;
        private Button btnClose;
        private TextBox txtResults;
        private Label lblTitle;
        private GroupBox grpTests;
        private GroupBox grpResults;
        private Label lblStatus;

        public DatabaseTestForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnTestConnection = new Button();
            this.btnValidateTables = new Button();
            this.btnClose = new Button();
            this.txtResults = new TextBox();
            this.lblTitle = new Label();
            this.grpTests = new GroupBox();
            this.grpResults = new GroupBox();
            this.lblStatus = new Label();

            this.SuspendLayout();

            // Arkansas Razorback Colors
            Color razorbackRed = Color.FromArgb(157, 34, 53);      // #9D2235
            Color razorbackWhite = Color.FromArgb(255, 255, 255);   // #FFFFFF  
            Color razorbackLightGray = Color.FromArgb(242, 242, 244); // #F2F2F4
            Color razorbackMediumGray = Color.FromArgb(199, 200, 202); // #C7C8CA
            Color razorbackDarkGray = Color.FromArgb(66, 66, 66);   // #424242
            Color razorbackBlack = Color.FromArgb(0, 0, 0);         // #000000

            // 
            // DatabaseTestForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 500);
            this.BackColor = razorbackLightGray;
            this.ForeColor = razorbackDarkGray;
            this.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseTestForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Arkansas Student Management System - Database Test";
            this.Load += new EventHandler(this.DatabaseTestForm_Load);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new Font("Myriad Pro", 14F, FontStyle.Bold);
            this.lblTitle.ForeColor = razorbackRed;
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(560, 30);
            this.lblTitle.Text = "Database Connection Test";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // grpTests
            // 
            this.grpTests.Controls.Add(this.btnTestConnection);
            this.grpTests.Controls.Add(this.btnValidateTables);
            this.grpTests.Font = new Font("Myriad Pro", 10F, FontStyle.Bold);
            this.grpTests.ForeColor = razorbackDarkGray;
            this.grpTests.Location = new Point(20, 60);
            this.grpTests.Size = new Size(560, 80);
            this.grpTests.Text = "Database Tests";

            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = razorbackRed;
            this.btnTestConnection.ForeColor = razorbackWhite;
            this.btnTestConnection.Font = new Font("Myriad Pro", 9F, FontStyle.Bold);
            this.btnTestConnection.FlatStyle = FlatStyle.Flat;
            this.btnTestConnection.Location = new Point(30, 30);
            this.btnTestConnection.Size = new Size(150, 35);
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new EventHandler(this.btnTestConnection_Click);

            // 
            // btnValidateTables
            // 
            this.btnValidateTables.BackColor = razorbackDarkGray;
            this.btnValidateTables.ForeColor = razorbackWhite;
            this.btnValidateTables.Font = new Font("Myriad Pro", 9F, FontStyle.Bold);
            this.btnValidateTables.FlatStyle = FlatStyle.Flat;
            this.btnValidateTables.Location = new Point(200, 30);
            this.btnValidateTables.Size = new Size(150, 35);
            this.btnValidateTables.Text = "Validate Tables";
            this.btnValidateTables.UseVisualStyleBackColor = false;
            this.btnValidateTables.Click += new EventHandler(this.btnValidateTables_Click);

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new Font("Myriad Pro", 9F, FontStyle.Bold);
            this.lblStatus.ForeColor = razorbackDarkGray;
            this.lblStatus.Location = new Point(20, 160);
            this.lblStatus.Size = new Size(100, 15);
            this.lblStatus.Text = "Status: Ready";

            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.txtResults);
            this.grpResults.Font = new Font("Myriad Pro", 10F, FontStyle.Bold);
            this.grpResults.ForeColor = razorbackDarkGray;
            this.grpResults.Location = new Point(20, 190);
            this.grpResults.Size = new Size(560, 250);
            this.grpResults.Text = "Test Results";

            // 
            // txtResults
            // 
            this.txtResults.BackColor = razorbackWhite;
            this.txtResults.ForeColor = razorbackBlack;
            this.txtResults.Font = new Font("Consolas", 9F);
            this.txtResults.Location = new Point(15, 25);
            this.txtResults.Multiline = true;
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = ScrollBars.Vertical;
            this.txtResults.Size = new Size(530, 210);
            this.txtResults.Text = "Click 'Test Connection' or 'Validate Tables' to begin testing...";

            // 
            // btnClose
            // 
            this.btnClose.BackColor = razorbackMediumGray;
            this.btnClose.ForeColor = razorbackBlack;
            this.btnClose.Font = new Font("Myriad Pro", 9F, FontStyle.Bold);
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Location = new Point(505, 460);
            this.btnClose.Size = new Size(75, 30);
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpTests);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void DatabaseTestForm_Load(object sender, EventArgs e)
        {
            UpdateStatus("Ready to test database connection");
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            UpdateStatus("Testing database connection...");
            txtResults.Clear();

            try
            {
                string result = Walton_DB.TestConnection();
                txtResults.Text = result;

                if (result.Contains("Connection successful"))
                {
                    UpdateStatus("✓ Database connection successful");

                    // Add additional connection details
                    txtResults.Text += Environment.NewLine + Environment.NewLine;
                    txtResults.Text += "=== Connection Details ===" + Environment.NewLine;
                    txtResults.Text += $"Test performed at: {DateTime.Now:yyyy-MM-dd HH:mm:ss}" + Environment.NewLine;

                    // Test basic query execution
                    try
                    {
                        string testQuery = "SELECT @@VERSION";
                        object versionResult = Walton_DB.RetrieveSingleValue(testQuery);
                        if (versionResult != null)
                        {
                            txtResults.Text += Environment.NewLine + "=== SQL Server Information ===" + Environment.NewLine;
                            txtResults.Text += versionResult.ToString() + Environment.NewLine;
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResults.Text += Environment.NewLine + $"Could not retrieve server version: {ex.Message}" + Environment.NewLine;
                    }
                }
                else
                {
                    UpdateStatus("✗ Database connection failed");
                    txtResults.Text += Environment.NewLine + Environment.NewLine;
                    txtResults.Text += "=== Troubleshooting Tips ===" + Environment.NewLine;
                    txtResults.Text += "1. Check your network connection" + Environment.NewLine;
                    txtResults.Text += "2. Verify the connection string in Walton_DB.cs" + Environment.NewLine;
                    txtResults.Text += "3. Ensure the database server is running" + Environment.NewLine;
                    txtResults.Text += "4. Check your username and password" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("✗ Connection test error");
                txtResults.Text = $"Error during connection test: {ex.Message}" + Environment.NewLine + Environment.NewLine;
                txtResults.Text += "Full error details:" + Environment.NewLine + ex.ToString();
            }
        }

        private void btnValidateTables_Click(object sender, EventArgs e)
        {
            UpdateStatus("Validating database tables...");
            txtResults.Clear();

            try
            {
                // First test connection
                if (!Walton_DB.OpenConnection())
                {
                    txtResults.Text = "Cannot validate tables - database connection failed." + Environment.NewLine;
                    txtResults.Text += $"Error: {Walton_DB.LastError}";
                    UpdateStatus("✗ Table validation failed");
                    return;
                }

                txtResults.Text = "=== Table Structure Validation ===" + Environment.NewLine + Environment.NewLine;

                // Check each required table
                string[] requiredTables = { "INSTRUCTOR", "STUDENT", "CLASS", "ENROLL" };
                bool allTablesExist = true;

                foreach (string tableName in requiredTables)
                {
                    try
                    {
                        string sql = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                        object result = Walton_DB.RetrieveSingleValue(sql);

                        if (Convert.ToInt32(result) > 0)
                        {
                            txtResults.Text += $"✓ Table '{tableName}' exists" + Environment.NewLine;

                            // Get row count
                            string countSql = $"SELECT COUNT(*) FROM {tableName}";
                            object countResult = Walton_DB.RetrieveSingleValue(countSql);
                            txtResults.Text += $"   Rows: {countResult}" + Environment.NewLine;
                        }
                        else
                        {
                            txtResults.Text += $"✗ Table '{tableName}' NOT FOUND" + Environment.NewLine;
                            allTablesExist = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResults.Text += $"✗ Error checking table '{tableName}': {ex.Message}" + Environment.NewLine;
                        allTablesExist = false;
                    }
                }

                txtResults.Text += Environment.NewLine;

                // Validate table columns
                if (allTablesExist)
                {
                    txtResults.Text += "=== Column Structure Validation ===" + Environment.NewLine + Environment.NewLine;
                    ValidateTableColumns();
                }

                // Overall status
                if (allTablesExist)
                {
                    UpdateStatus("✓ All required tables found");
                    txtResults.Text += Environment.NewLine + "=== Validation Summary ===" + Environment.NewLine;
                    txtResults.Text += "✓ Database structure appears to be correct for the Arkansas Student Management System" + Environment.NewLine;
                }
                else
                {
                    UpdateStatus("✗ Missing required tables");
                    txtResults.Text += Environment.NewLine + "=== Missing Tables ===" + Environment.NewLine;
                    txtResults.Text += "Some required tables are missing. Please create the database schema." + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("✗ Table validation error");
                txtResults.Text += $"Error during table validation: {ex.Message}" + Environment.NewLine + Environment.NewLine;
                txtResults.Text += "Full error details:" + Environment.NewLine + ex.ToString();
            }
        }

        private void ValidateTableColumns()
        {
            try
            {
                // Validate INSTRUCTOR table
                string sql = @"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
                              FROM INFORMATION_SCHEMA.COLUMNS 
                              WHERE TABLE_NAME = 'INSTRUCTOR' 
                              ORDER BY ORDINAL_POSITION";

                DataTable dt = new DataTable();
                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    txtResults.Text += "INSTRUCTOR table columns:" + Environment.NewLine;
                    foreach (DataRow row in dt.Rows)
                    {
                        string columnName = row["COLUMN_NAME"].ToString();
                        string dataType = row["DATA_TYPE"].ToString();
                        string maxLength = row["CHARACTER_MAXIMUM_LENGTH"].ToString();

                        txtResults.Text += $"  - {columnName} ({dataType}";
                        if (!string.IsNullOrEmpty(maxLength) && maxLength != "-1")
                            txtResults.Text += $", {maxLength}";
                        txtResults.Text += ")" + Environment.NewLine;
                    }
                    txtResults.Text += Environment.NewLine;
                }

                // Validate STUDENT table
                sql = @"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
                       FROM INFORMATION_SCHEMA.COLUMNS 
                       WHERE TABLE_NAME = 'STUDENT' 
                       ORDER BY ORDINAL_POSITION";

                dt = new DataTable();
                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    txtResults.Text += "STUDENT table columns:" + Environment.NewLine;
                    foreach (DataRow row in dt.Rows)
                    {
                        string columnName = row["COLUMN_NAME"].ToString();
                        string dataType = row["DATA_TYPE"].ToString();
                        string maxLength = row["CHARACTER_MAXIMUM_LENGTH"].ToString();

                        txtResults.Text += $"  - {columnName} ({dataType}";
                        if (!string.IsNullOrEmpty(maxLength) && maxLength != "-1")
                            txtResults.Text += $", {maxLength}";
                        txtResults.Text += ")" + Environment.NewLine;
                    }
                    txtResults.Text += Environment.NewLine;
                }

                // Validate CLASS table
                sql = @"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
                       FROM INFORMATION_SCHEMA.COLUMNS 
                       WHERE TABLE_NAME = 'CLASS' 
                       ORDER BY ORDINAL_POSITION";

                dt = new DataTable();
                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    txtResults.Text += "CLASS table columns:" + Environment.NewLine;
                    foreach (DataRow row in dt.Rows)
                    {
                        string columnName = row["COLUMN_NAME"].ToString();
                        string dataType = row["DATA_TYPE"].ToString();
                        string maxLength = row["CHARACTER_MAXIMUM_LENGTH"].ToString();

                        txtResults.Text += $"  - {columnName} ({dataType}";
                        if (!string.IsNullOrEmpty(maxLength) && maxLength != "-1")
                            txtResults.Text += $", {maxLength}";
                        txtResults.Text += ")" + Environment.NewLine;
                    }
                    txtResults.Text += Environment.NewLine;
                }

                // Validate ENROLL table
                sql = @"SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH 
                       FROM INFORMATION_SCHEMA.COLUMNS 
                       WHERE TABLE_NAME = 'ENROLL' 
                       ORDER BY ORDINAL_POSITION";

                dt = new DataTable();
                if (Walton_DB.FillDataTable_ViaSql(ref dt, sql))
                {
                    txtResults.Text += "ENROLL table columns:" + Environment.NewLine;
                    foreach (DataRow row in dt.Rows)
                    {
                        string columnName = row["COLUMN_NAME"].ToString();
                        string dataType = row["DATA_TYPE"].ToString();
                        string maxLength = row["CHARACTER_MAXIMUM_LENGTH"].ToString();

                        txtResults.Text += $"  - {columnName} ({dataType}";
                        if (!string.IsNullOrEmpty(maxLength) && maxLength != "-1")
                            txtResults.Text += $", {maxLength}";
                        txtResults.Text += ")" + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                txtResults.Text += $"Error validating columns: {ex.Message}" + Environment.NewLine;
            }
        }

        private void UpdateStatus(string status)
        {
            lblStatus.Text = $"Status: {status}";
            lblStatus.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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