using System;
using Tamir.SharpSsh;
using System.Windows.Forms;

namespace Utils_Green
{
    public class SSHConnector : User
    {
        private SshShell shell = null;
        private User user;
        public User SshUser
        {
            get { return user; }
            set { user = value; }
        }
        public SSHConnector(User user)
            : base(user.Username, user.Userpass)
        {
            SshUser = user ;
        }

        /// <summary>
        /// gets the user from User class and check if ssh connection is created
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>boolean</returns>
        public bool IsSshCreated()
        {
            //create socket connection then!!
            //prompt to the next step->>> To the main window
            bool success = false;
            shell = new SshShell(SshUser.Host, SshUser.Username);
            if (SshUser.Userpass != null) shell.Password = SshUser.Userpass;

            try
            {
                //This statement must be prior to connecting
                shell.RedirectToConsole();
                //Connect using the parameters entered by the user
                shell.Connect();
                //test case
                MessageBox.Show("SSH Connection Opened", " SSH connection Info");
                success = true;
                return success;
            }
            catch (Exception ex)
            {
                //test case
                MessageBox.Show(" SSH Connection Error. \n" + ex.ToString(), " SSH connection Info");
                return success;
            }
            finally
            {
                if (shell != null)
                    shell.Close();                
            }
        }

    }
}
