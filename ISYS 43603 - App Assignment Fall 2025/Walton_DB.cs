using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class Walton_DB
{
    private static SqlConnection lo_Connection;
    public const int CommandTimeOutSeconds = 1200;

    // Enhanced error logging
    public static string LastError { get; private set; } = "";

    public static bool OpenConnection()
    {
        int Retry = 2;
        while (Retry >= 0)
        {
            try
            {
                if (lo_Connection == null)
                {
                    lo_Connection = new SqlConnection();
                    // Your database connection string
                    lo_Connection.ConnectionString = "Data Source=essql1.walton.uark.edu;Initial Catalog=ISYS43603_Fall2025_dec011_db;user id=dec011;password=ISYSPass100447686!;Persist Security Info=False;Connection Timeout=30;";
                }

                if (lo_Connection.State == ConnectionState.Closed)
                    lo_Connection.Open();

                LastError = "";
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                lo_Connection?.Dispose();
                lo_Connection = null;

                if (Retry >= 1 && (ex.Message.Contains("Data Provider error 6") ||
                                  ex.Message.Contains("An existing connection was forcibly closed") ||
                                  ex.Message.Contains("The specified network name is no longer available") ||
                                  ex.Message.Contains("The semaphore timeout period has expired") ||
                                  ex.Message.Contains("The timeout period elapsed prior to completion of the operation")))
                {
                    // short pause before retrying
                    System.Threading.Thread.Sleep(1337);
                    Retry -= 1;
                }
                else if (Retry >= 1 && (ex.Message.Contains("The server was not found or was not accessible")
                                || ex.Message.Contains("Could not open a connection to SQL Server")))
                {
                    // long pause before retrying
                    System.Threading.Thread.Sleep(91337);
                    Retry -= 1;
                }
                else
                    Retry = -1;
            }
        }
        return false;
    }

    public static SqlConnection Connection
    {
        get
        {
            if (OpenConnection())
                return lo_Connection;
            else
                return null;
        }
    }

    public static bool ExecSqlString(string SqlString)
    {
        SqlCommand SqlCmd = new SqlCommand(SqlString);
        return ExecSqlCommand(ref SqlCmd);
    }

    public static bool ExecSqlCommand(ref SqlCommand SqlCmd)
    {
        if (!OpenConnection())
            return false;

        SqlCmd.Connection = lo_Connection;
        SqlCmd.CommandTimeout = CommandTimeOutSeconds;

        int Retry = 2;
        while (Retry >= 0)
        {
            try
            {
                SqlCmd.ExecuteNonQuery();
                lo_Connection.Close();
                LastError = "";
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                if (Retry >= 1 && ex.Message.Contains("deadlock victim"))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else if (Retry >= 1 && (ex.Message.Contains("INSERT EXEC failed ") || ex.Message.Contains("Schema changed ")))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else
                {
                    lo_Connection.Close();
                    Retry = -1;
                }
            }
        }
        return false;
    }

    public static bool FillDataTable_ViaCmd(ref DataTable ReturnTable, ref SqlCommand SqlCmd)
    {
        System.Data.SqlClient.SqlDataAdapter lo_Ada = new System.Data.SqlClient.SqlDataAdapter();
        DataTable Return_DataTable = new DataTable();
        SqlConnection ActiveConn;

        if (!OpenConnection())
            return false;
        else
            ActiveConn = lo_Connection;

        SqlCmd.Connection = ActiveConn;
        SqlCmd.CommandTimeout = CommandTimeOutSeconds;

        int Retry = 2;
        while (Retry >= 0)
        {
            try
            {
                lo_Ada.SelectCommand = SqlCmd;
                lo_Ada.Fill(Return_DataTable);
                lo_Ada.Dispose();
                lo_Ada = null;
                ActiveConn.Close();
                ReturnTable = Return_DataTable;
                LastError = "";
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                if (Retry >= 1 && ex.Message.Contains("deadlock victim"))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else if (Retry >= 1 && (ex.Message.Contains("INSERT EXEC failed ") || ex.Message.Contains("Schema changed ")))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else
                {
                    ActiveConn.Close();
                    Retry = -1;
                }
            }
        }
        return false;
    }

    public static bool FillDataTable_ViaSql(ref DataTable ReturnTable, string SqlStr)
    {
        SqlCommand SqlCmd = new SqlCommand(SqlStr);
        return FillDataTable_ViaCmd(ref ReturnTable, ref SqlCmd);
    }

    public static DataSet CreateDataSet_ViaCmd(SqlCommand SqlCmd, string str_TableName)
    {
        System.Data.SqlClient.SqlDataAdapter lo_Ada = new System.Data.SqlClient.SqlDataAdapter();
        DataSet Return_DataSet = new DataSet();
        SqlConnection ActiveConn;

        if (!OpenConnection())
            return null;
        else
            ActiveConn = lo_Connection;

        SqlCmd.Connection = ActiveConn;
        SqlCmd.CommandTimeout = CommandTimeOutSeconds;

        int Retry = 2;
        while (Retry >= 0)
        {
            try
            {
                lo_Ada.SelectCommand = SqlCmd;
                lo_Ada.Fill(Return_DataSet, str_TableName);
                lo_Ada.Dispose();
                lo_Ada = null;
                ActiveConn.Close();
                LastError = "";
                return Return_DataSet;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                if (Retry >= 1 && ex.Message.Contains("deadlock victim"))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else if (Retry >= 1 && (ex.Message.Contains("INSERT EXEC failed ") || ex.Message.Contains("Schema changed ")))
                {
                    System.Threading.Thread.Sleep(3337);
                    Retry -= 1;
                }
                else
                {
                    ActiveConn.Close();
                    Retry = -1;
                }
            }
        }
        return null;
    }

    public static DataSet CreateDataSet_ViaSql(string str_Sql, string str_TableName)
    {
        return CreateDataSet_ViaCmd(new SqlCommand(str_Sql), str_TableName);
    }

    public static decimal RetrieveScalar(string StrSql)
    {
        System.Data.SqlClient.SqlCommand objCom = new System.Data.SqlClient.SqlCommand();
        decimal ld_Result;

        if (!OpenConnection())
            return 0;

        try
        {
            objCom.Connection = lo_Connection;
            objCom.CommandTimeout = CommandTimeOutSeconds;
            objCom.CommandText = StrSql;
            ld_Result = (decimal)objCom.ExecuteScalar();

            LastError = "";
            return ld_Result;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return 0;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static object RetrieveSingleValue(string Sql)
    {
        System.Data.SqlClient.SqlCommand objCom = new System.Data.SqlClient.SqlCommand();
        object ld_Result;

        if (!OpenConnection())
            return 0;

        try
        {
            objCom.Connection = lo_Connection;
            objCom.CommandTimeout = CommandTimeOutSeconds;
            objCom.CommandText = Sql;
            ld_Result = objCom.ExecuteScalar();

            LastError = "";
            return ld_Result;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return 0;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static object RetrieveSingleValue(ref SqlCommand objCom)
    {
        object ld_Result;

        if (!OpenConnection())
            return 0;

        objCom.Connection = lo_Connection;
        objCom.CommandTimeout = CommandTimeOutSeconds;

        try
        {
            ld_Result = objCom.ExecuteScalar();

            LastError = "";
            return ld_Result;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return 0;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    // Enhanced utility methods for the Student Management System

    /// <summary>
    /// Tests the database connection and returns detailed connection status
    /// </summary>
    /// <returns>Connection status message</returns>
    public static string TestConnection()
    {
        try
        {
            if (OpenConnection())
            {
                string serverVersion = "";
                string databaseName = "";

                try
                {
                    serverVersion = lo_Connection.ServerVersion;
                    databaseName = lo_Connection.Database;
                    lo_Connection.Close();

                    return $"Connection successful!\nServer: {lo_Connection.DataSource}\nDatabase: {databaseName}\nServer Version: {serverVersion}";
                }
                catch
                {
                    lo_Connection.Close();
                    return "Connection successful but unable to retrieve server details.";
                }
            }
            else
            {
                return $"Connection failed: {LastError}";
            }
        }
        catch (Exception ex)
        {
            return $"Connection test error: {ex.Message}";
        }
    }

    /// <summary>
    /// Checks if a record exists in a table with the specified condition
    /// </summary>
    /// <param name="tableName">Table name to check</param>
    /// <param name="whereClause">WHERE clause condition</param>
    /// <returns>True if record exists, false otherwise</returns>
    public static bool RecordExists(string tableName, string whereClause)
    {
        try
        {
            string sql = $"SELECT COUNT(*) FROM {tableName} WHERE {whereClause}";
            object result = RetrieveSingleValue(sql);
            return Convert.ToInt32(result) > 0;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>
    /// Gets the next available ID for a table with an integer primary key
    /// </summary>
    /// <param name="tableName">Table name</param>
    /// <param name="idColumnName">ID column name</param>
    /// <returns>Next available ID</returns>
    public static int GetNextAvailableId(string tableName, string idColumnName)
    {
        try
        {
            string sql = $"SELECT ISNULL(MAX({idColumnName}), 0) + 1 FROM {tableName}";
            object result = RetrieveSingleValue(sql);
            return Convert.ToInt32(result);
        }
        catch
        {
            return 1;
        }
    }

    /// <summary>
    /// Executes a SQL command within a transaction
    /// </summary>
    /// <param name="sqlCommands">Array of SQL commands to execute</param>
    /// <returns>True if all commands succeeded, false otherwise</returns>
    public static bool ExecuteTransaction(string[] sqlCommands)
    {
        if (!OpenConnection())
            return false;

        SqlTransaction transaction = null;
        try
        {
            transaction = lo_Connection.BeginTransaction();

            foreach (string sql in sqlCommands)
            {
                SqlCommand cmd = new SqlCommand(sql, lo_Connection, transaction);
                cmd.CommandTimeout = CommandTimeOutSeconds;
                cmd.ExecuteNonQuery();
            }

            transaction.Commit();
            LastError = "";
            return true;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            try
            {
                transaction?.Rollback();
            }
            catch { }
            return false;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    /// <summary>
    /// Validates that required tables exist in the database
    /// </summary>
    /// <returns>True if all required tables exist</returns>
    public static bool ValidateTableStructure()
    {
        try
        {
            string[] requiredTables = { "INSTRUCTOR", "STUDENT", "CLASS", "ENROLL" };

            foreach (string tableName in requiredTables)
            {
                string sql = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
                object result = RetrieveSingleValue(sql);

                if (Convert.ToInt32(result) == 0)
                {
                    LastError = $"Required table '{tableName}' not found in database.";
                    return false;
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            LastError = $"Error validating table structure: {ex.Message}";
            return false;
        }
    }

    /// <summary>
    /// Safely escapes single quotes in strings for SQL queries
    /// </summary>
    /// <param name="input">Input string</param>
    /// <returns>Escaped string safe for SQL</returns>
    public static string EscapeSqlString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        return input.Replace("'", "''");
    }

    // Remaining methods from original class...
    public static Hashtable CreateHashTable2_ViaCmd(ref SqlCommand SqlCmd)
    {
        // creates a key-pair hashtable for a multi-row 2-column query
        // item key will be the first column value (must be a string-type)
        // item value will be the second column
        // null keys are not added, null values are converted to empty strings

        System.Data.SqlClient.SqlDataReader lo_DatR;
        Hashtable lo_HT = new Hashtable();

        if (!OpenConnection())
            return null;

        try
        {
            SqlCmd.Connection = lo_Connection;
            SqlCmd.CommandTimeout = CommandTimeOutSeconds;
            lo_DatR = SqlCmd.ExecuteReader();
            if (lo_DatR.HasRows)
            {
                while (lo_DatR.Read())
                {
                    if (!Convert.IsDBNull(lo_DatR[0]))
                    {
                        if (Convert.IsDBNull(lo_DatR[1]))
                            lo_HT.Add(lo_DatR[0], "");
                        else
                            lo_HT.Add(lo_DatR[0], lo_DatR[1]);
                    }
                }
            }
            lo_DatR.Close();

            if (lo_HT.Count <= 0)
                return null;
            else
                return lo_HT;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return null;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static Hashtable CreateHashTable_ViaCmd(ref SqlCommand SqlCmd)
    {
        // creates a hashtable for a single-row query
        // item key will be the db column name
        // null values are converted to empty strings
        System.Data.SqlClient.SqlDataReader lo_DatR;
        Hashtable lo_HT;
        int li_i;
        SqlConnection ActiveConn;

        if (!OpenConnection())
            return null;
        else
            ActiveConn = lo_Connection;

        try
        {
            SqlCmd.Connection = ActiveConn;
            SqlCmd.CommandTimeout = CommandTimeOutSeconds;

            lo_DatR = SqlCmd.ExecuteReader(CommandBehavior.SingleRow);
            if (!lo_DatR.HasRows)
                lo_HT = null;
            else if (!lo_DatR.Read())
                lo_HT = null;
            else
            {
                lo_HT = new Hashtable();
                for (li_i = 0; li_i <= lo_DatR.FieldCount - 1; li_i++)
                {
                    if (Convert.IsDBNull(lo_DatR[li_i]))
                        lo_HT.Add(lo_DatR.GetName(li_i), "");
                    else
                        lo_HT.Add(lo_DatR.GetName(li_i), lo_DatR[li_i]);
                }
                if (lo_HT.Count <= 0)
                    lo_HT = null;
            }
            lo_DatR.Close();

            LastError = "";
            return lo_HT;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return null;
        }
        finally
        {
            ActiveConn.Close();
        }
    }

    public static Hashtable CreateHashTable_ViaSql(string str_Sql)
    {
        System.Data.SqlClient.SqlCommand lo_SqlCmd = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lo_DatR;
        Hashtable lo_HT;
        int li_i;

        if (!OpenConnection())
            return null;

        try
        {
            lo_SqlCmd.Connection = lo_Connection;
            lo_SqlCmd.CommandTimeout = CommandTimeOutSeconds;
            lo_SqlCmd.CommandText = str_Sql;
            lo_DatR = lo_SqlCmd.ExecuteReader(CommandBehavior.SingleRow);

            if (!lo_DatR.HasRows)
                lo_HT = null;
            else if (!lo_DatR.Read())
                lo_HT = null;
            else
            {
                lo_HT = new Hashtable();
                for (li_i = 0; li_i <= lo_DatR.FieldCount - 1; li_i++)
                {
                    if (Convert.IsDBNull(lo_DatR[li_i]))
                        lo_HT.Add(lo_DatR.GetName(li_i), "");
                    else
                        lo_HT.Add(lo_DatR.GetName(li_i), lo_DatR[li_i]);
                }
                if (lo_HT.Count <= 0)
                    lo_HT = null;
            }
            lo_DatR.Close();

            LastError = "";
            return lo_HT;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return null;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static ArrayList CreateArrayList_ViaSql(string str_Sql)
    {
        System.Data.SqlClient.SqlCommand lo_SqlCmd = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lo_DatR;
        ArrayList Return_ArrayList = new ArrayList();

        if (!OpenConnection())
            return null;

        try
        {
            lo_SqlCmd.Connection = lo_Connection;
            lo_SqlCmd.CommandTimeout = CommandTimeOutSeconds;
            lo_SqlCmd.CommandText = str_Sql;
            lo_DatR = lo_SqlCmd.ExecuteReader();

            if (lo_DatR.HasRows)
            {
                while (lo_DatR.Read())
                {
                    if (Convert.IsDBNull(lo_DatR[0]))
                        Return_ArrayList.Add("");
                    else
                        Return_ArrayList.Add(lo_DatR[0]);
                }
            }
            lo_DatR.Close();

            if (Return_ArrayList.Count > 0)
            {
                LastError = "";
                return Return_ArrayList;
            }
            else
                return null;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return null;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static bool AppendDataTable(ref DataTable dsNewTable, string strSQL)
    {
        if (!OpenConnection())
            return false;

        try
        {
            DataTable oDataSet = new DataTable();
            System.Data.SqlClient.SqlDataAdapter DataAdapter;

            DataAdapter = new System.Data.SqlClient.SqlDataAdapter(strSQL, lo_Connection);

            System.Data.SqlClient.SqlCommandBuilder myDataRowsCommandBuilder = new System.Data.SqlClient.SqlCommandBuilder(DataAdapter);

            DataAdapter.Update(dsNewTable);

            DataAdapter.Dispose();
            myDataRowsCommandBuilder.Dispose();

            LastError = "";
            return true;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return false;
        }
        finally
        {
            lo_Connection.Close();
        }
    }

    public static bool CloneDataTable(ref DataTable ReturnTable, string TableName)
    {
        System.Data.SqlClient.SqlDataAdapter lo_Ada = new System.Data.SqlClient.SqlDataAdapter();
        DataTable Return_DataTable = new DataTable();

        if (!OpenConnection())
            return false;

        try
        {
            System.Data.SqlClient.SqlCommand SqlCmd;
            SqlCmd = new System.Data.SqlClient.SqlCommand("Select TOP 1 * from " + TableName, lo_Connection);
            SqlCmd.Connection = lo_Connection;
            lo_Ada.SelectCommand = SqlCmd;
            lo_Ada.FillSchema(Return_DataTable, SchemaType.Source);
            lo_Ada.Dispose();
            lo_Ada = null;

            ReturnTable = Return_DataTable;
            LastError = "";
            return true;
        }
        catch (Exception ex)
        {
            LastError = ex.Message;
            return false;
        }
        finally
        {
            lo_Connection.Close();
        }
    }
}