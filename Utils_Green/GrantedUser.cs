using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Utils_Green
{
    public class GrantedUser : User
    {
        //return success if username entered exist in the database
        //should also cross check the password to match

        private User activeUser;
        public User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        /// <summary>
        /// Default constructor
        /// </summary>     
        public GrantedUser(string name, string pass)
            : base(name, pass)
        {
            //name = activeUser.Username;
            //pass = activeUser.Userpass;
        }

        public bool Authenticated(User activeUser)
        {
            bool success = false;

            /****
             * retrieve connection string from app.config file. The app.config file is only excuted during the application run time life and 
             * is recommened for security and update the application for the future.
             * using the key word: "Backup_Users"-->> Hiding sensitive data: 
             * password and username for the database is very IMPORTANT!!
             * ****/

            string connectionString = ConfigurationManager.ConnectionStrings["Backup_Users"].ConnectionString;

            // create new connection using the connection string stored at connectionString string above
            MySqlConnection connection = new MySqlConnection(connectionString);
                       
            try
            {
                //open db connection using connection string 
                connection.Open();

                //retrieve user name and password 
                MySqlCommand retrieveUser = connection.CreateCommand();
                retrieveUser.CommandType = CommandType.Text;

                /*****
                 * slq query from the selected database, 
                 * Table name: GsBackupUsers with fields: userName and password 
                 * ***********/                
                string sqlFetch = "SELECT userName,rePasswd FROM GsBackupUsers WHERE userName = @user AND passwd = @pass;";

                retrieveUser.Parameters.AddWithValue("@user", Username);
                retrieveUser.Parameters.AddWithValue("@pass", Userpass);                
                
                retrieveUser.CommandText = sqlFetch;                

                //excute the reader 
                MySqlDataReader reader = retrieveUser.ExecuteReader();

                // check if the user exists in the database  and match password and return true if user pass the verification
                if (reader.Read() == true)
                {
                    string dbUsername = reader["userName"].ToString();
                    string dbPassword = reader["rePasswd"].ToString();
                    // since password is case sensitive, it should be rechecked ...String compare method...Handy!
                    if  ( (dbPassword.Equals(Userpass, StringComparison.Ordinal)) && (dbUsername.Equals(Username, StringComparison.OrdinalIgnoreCase)) )
                    {
                        reader.Close();
                        success = true;
                        return success;
                    }
                }
                reader.Close();
                MessageBox.Show("Login failed. \n" 
                    + "Please check you username/password or request for  password recovery.", "Login Info");
                return success;
            }
            catch (MySqlException ex)
            {
                //throw exception if db connection is not okay
                 MessageBox.Show("Mysql Error. \n " + ex.ToString(), "Database Connection Info");               
                return success;
            }
            finally
            {
                //finally release all database resources
                if (connection != null)
                    connection.Dispose();
                    connection.Close();
            }
        }
    }
}

