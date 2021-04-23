using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Utils_Green
{
    public class User : IUser
    {
        private string _host = @"gsbackup.greenspot.fi";
        private string _name = string.Empty;
        private string _passwd = string.Empty;

        /// <summary>
        /// Default constructor with name and password 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        public User(string name, string pass)
        {
            _name = name;
            _passwd = pass;
            // _host = @"gsbackup.greenspot.fi"; 
        }
        public User()
        {
        }

        #region IUser Members
        /// <summary>
        /// create auto-implemented Properties
        /// </summary>
        public string Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
            }
        }
        public string Username
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                    _name = value;
                else
                    _name = string.Empty;
            }
        }
        // Do the same for password
        public string Userpass
        {
            get
            {
                return _passwd;
            }
            set
            {
                if (value != null)
                    _passwd = value;
                else
                    _passwd = string.Empty;
            }
        }
        /// <summary>
        /// Validate User check username->> return true if OK 
        /// more validation todo 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public bool IsValid(string input)
        {
            if (input.Length > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        public void InsertNewUser(string fname, string lname, string email,string username,string passwd,string repasswd)
        {         
            string connectionString = ConfigurationManager.ConnectionStrings["Backup_Users"].ConnectionString;

            // create new connection using the connection string stored at connectionString string above
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                //open db connection using connection string 
                connection.Open();

                string sqlInsert = " INSERT INTO GsBackupUsers VALUES (@fname,@lname,@email,@username,@passwd,@repasswd,@date);";         
                MySqlCommand insertUser = new MySqlCommand(sqlInsert, connection);

                insertUser.Parameters.AddWithValue("@fname", fname);
                insertUser.Parameters.AddWithValue("@lname", lname);
                insertUser.Parameters.AddWithValue("@email", email);
                insertUser.Parameters.AddWithValue("@username", username);
                insertUser.Parameters.AddWithValue("@passwd", passwd);
                insertUser.Parameters.AddWithValue("@repasswd", repasswd);
                insertUser.Parameters.AddWithValue("@date", DateTime.Now);                               

                insertUser.ExecuteNonQuery();
                insertUser.Dispose();
                insertUser = null;
                 
                //test case
                MessageBox.Show(String.Format("{0} {1} : has registered successfully. Thank you.",fname, lname), "Registration Info");
            }
            catch (MySqlException ex)
            {
                //throw exception if db connection is not okay
                 MessageBox.Show("Mysql Error. \n " + ex.ToString(), "Database Connection Info");               
            }
            finally
            {
                //finally release all database resources
                if (connection != null)
                    connection.Close();
            }         
        }
    }
}

