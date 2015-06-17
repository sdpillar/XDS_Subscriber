using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace XDS_Subscriber
{
    public class UserDatabase
    {
        private string currentUser;
        SubscriptionLog subLog = new SubscriptionLog(@"C:\HSS_XDS");

        public string CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
            }
        }

        public SqlConnection openConnection(string databaseName)
        {
            try
            {
                subLog.WriteLog("Opening connection to " + databaseName + " database...");
                string server = Properties.Settings.Default.Server;
                string database = databaseName;
                string user = Properties.Settings.Default.User;
                string password = Properties.Settings.Default.Password;
                string connectionString = "Server=" + server + ";Database=" + database + ";User Id=" + user + ";Password=" + password;
                subLog.WriteLog("Connection String - '" + connectionString + "'");
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                subLog.WriteLog("Connection to database - " + databaseName + " opened...");
                return cnn;
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("openConnection exception - " + exceptionMsg);
                return null;
            }
        }

        public bool CheckTableExists(SqlConnection conn, string tableName)
        {
            try
            {
                subLog.WriteLog("Checking db table - " + tableName + " exists...");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn;
                sqlCmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME ='" + tableName + "'";
                SqlDataReader myReader = null;
                int count = 0;
                subLog.WriteLog("Executing query - '" + sqlCmd.CommandText + "'"); 
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    count++;
                }
                myReader.Close();
                if (count == 0)
                {
                    subLog.WriteLog("Db table - " + tableName + " does not exists...");
                    return false;
                }
                else
                {
                    subLog.WriteLog("Db table - " + tableName + " exists...");
                    return true;
                }
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CheckTableExists exception - " + exceptionMsg);
                return false;
            }
            
        }

        public bool CreateUsersTable(SqlConnection conn)
        {
            try
            {
                subLog.WriteLog("Creating Users table...");
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "CREATE TABLE Users(username char(50), surname char(50), forename char(50), Admin bit, Password char(50), passChanged bit);";
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    command.ExecuteNonQuery();
                    subLog.WriteLog("Users table created...");

                    command.CommandText = "INSERT INTO Users (username, surname, forename, Admin, Password, passchanged) VALUES ('admin','admin','admin',1,'admin', 0)";
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    command.ExecuteNonQuery();
                    subLog.WriteLog("Admin user inserted...");
                    return true;
                }
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CreateUsersTable exception - " + exceptionMsg);
                return false;
            }
        }

        public bool CreateNewUser(SqlConnection conn, string username, string surname, string forename)
        {
            try
            {
                subLog.WriteLog("Creating new user...");
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    string insertString = String.Format("INSERT INTO Users (username, surname, forename, Admin, Password, passchanged) VALUES ('{0}','{1}','{2}',1,'Password1', 0)", username, surname, forename);
                    command.CommandText = insertString;
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    command.ExecuteNonQuery();
                    subLog.WriteLog("New user created...");
                    return true;
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CreateNewUser exception - " + exceptionMsg);
                return false;
            }
        }

        public bool CheckUserLogin(SqlConnection conn, string user, string password)
        {
            try
            {
                subLog.WriteLog("Checking user login...");
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "select COUNT(username) from Users where username = '" + user + "' and password = '" + password + "'";
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        this.currentUser = user;
                        subLog.WriteLog("User verified...");
                        return true;
                    }
                    else
                    {
                        subLog.WriteLog("User unverified...");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CheckUserLogin exception - " + exceptionMsg);
                return false;
            }
        }

        public bool UpdateUserPassword(SqlConnection conn, string user, string password)
        {
            try
            {
                subLog.WriteLog("Updating user password...");
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    string queryString = "update dbo.Users set Password = '" + password + "', passChanged = 1 where username = '" + user + "'";
                    command.CommandText = queryString;
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    command.ExecuteNonQuery();
                    subLog.WriteLog("User password updated...");
                    return true;
                }
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CheckUserLogin exception - " + exceptionMsg);
                return false;
            }
        }

        public bool CheckUserExists(SqlConnection conn, string user)
        {
            try
            {
                subLog.WriteLog("Checking user exists...");
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "select COUNT(username) from Users where username = '" + user + "'";
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        subLog.WriteLog("User exists...");
                        return true;
                    }
                    else
                    {
                        subLog.WriteLog("User does not exist...");
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CheckUserExists exception - " + exceptionMsg);
                return false;
            }
        }

        public bool CheckUserPasswordChanged(SqlConnection conn, string user)
        {
            try
            {
                subLog.WriteLog("Checking user password changed...");
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "select passChanged from Users where username = '" + user + "'";
                    subLog.WriteLog("CommandText - '" + command.CommandText + "'");
                    SqlDataReader myReader = command.ExecuteReader();
                    bool changed = false;
                    //is a record returned?
                    while (myReader.Read())
                    {
                        changed = myReader.GetBoolean(0);
                    }
                    if (changed == false) //passChanged = 0, therefore new user
                    {
                        myReader.Close();
                        subLog.WriteLog("User password has not changed, therefore new user...");
                        return false;
                    }
                    else
                    {
                        myReader.Close();
                        subLog.WriteLog("User password changed, therefore existing user...");
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("CheckUserPasswordChanged exception - " + exceptionMsg);
                return false;
            }
        }
    }
}
