using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tamir.SharpSsh;


namespace Uifs_Green
{
    public partial class StartForm : Form
    {

        Utils_Green.User activeUser;

        private Utils_Green.User ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        public StartForm()
        {
            InitializeComponent();
            ActiveUser = new Utils_Green.User(null, null);            
        }

        /// <summary>
        /// Accept name and password from text box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginbtn_Click(object sender, EventArgs e)
        {
            usernameErrorlbl.Show();
            passErrorlbl.Show();   
            
            string name = userNametxb.Text;
            string key = passtxb.Text;
            
            //instantiate User object with two arguments from the user
            ActiveUser = new Utils_Green.User(name, key);            

            ActiveUser.Username = name;
            ActiveUser.Userpass = key;

            //check if the user enters username
            if (ActiveUser.IsValid(name))
            {
                //for test case
                usernameErrorlbl.Text = "user Success";

                passtxb.Focus();
                passErrorlbl.Text = "No password";

                //check if the user entered password
                if (ActiveUser.IsValid(key))
                {
                    //for test case 
                    passErrorlbl.Text = "Access granted";
                    loginStatusBar.Panels[0].Text = " Connecting " + name + " to host....";
                    usernameErrorlbl.Hide();
                    passErrorlbl.Hide();

                    Utils_Green.GrantedUser dbUser = new Utils_Green.GrantedUser(name, key);
                    //check user if exists in the database still got some issues with the mysql server at the backend

                   // if (!dbUser.Authenticated(activeUser))
                    if (dbUser.Authenticated(activeUser) == true)
                    {
                        Utils_Green.SSHConnector sshUser = new Utils_Green.SSHConnector(ActiveUser);
                        if (sshUser.IsSshCreated() == true)
                        {
                            BackupWin backupForm = new BackupWin(ActiveUser);
                            // create a new BackupWin form....then....
                            //check if the user pass every authentication and validation
                            StartForm startForm = new StartForm();
                            backupForm.Show();
                            if (IsFormOpen(backupForm))
                            {
                                backupForm.Show();
                                startForm.Close();
                                //loginForm.Dispose();                
                            }
                            else
                                startForm.Show();
                        }
                    }                    
                }
            }
            
            else
            {
                //clear everything and 
                usernameErrorlbl.Text = "Enter username";
                passErrorlbl.Text = "Enter Password";
                userNametxb.Clear();
                passtxb.Clear();
                userNametxb.Focus();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        //check if any form is open ->> Useful for any form
        private bool IsFormOpen(Form iForm)
        {
            // traverse through the application windows(default open windows) 
            // and close the selected child window otherwise go out of the looop!!!
            foreach (Form f in Application.OpenForms)
                if (iForm == f)
                {
                    this.Hide();
                    return true;
                }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Size = new Size(521, 564);
            this.credentialsgbx.Enabled = false;
            firstnametbx.Focus();

            firstnametbx.Clear();
            lastnametxb.Clear();
            emailtxb.Clear();
            registerusernametxb.Clear();
            registerpasstxb.Clear();
            repasswdtxb.Clear();
        }

        private void regCanelbtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(521, 235);
            this.credentialsgbx.Enabled = true;

            userNametxb.Clear();
            passtxb.Clear();
            userNametxb.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registergbx.Focus();

            string firstname = firstnametbx.Text;
            string lastname = lastnametxb.Text;
            string email = emailtxb.Text;
            string newusername = registerusernametxb.Text;
            string newpasswd = registerpasstxb.Text;
            string repasswd = repasswdtxb.Text;

            firstnameErrlbl.Show();
            lastnameErrolbl.Show();
            emailErrorlbl.Show();
            regnameErrorlbl.Show();
            regpassErrorlbl.Show();
            repassErrorlbl.Show();
            
            string required = "**";
            //check if the user entered all the required fields on the register form
            if (ActiveUser.IsValid(firstname))
            {
                lastnametxb.Focus();
                lastnameErrolbl.Text = required;

                if (ActiveUser.IsValid(lastname))
                {
                    emailtxb.Focus();
                    emailErrorlbl.Text = required;

                    if(ActiveUser.IsValid(email))
                    {
                        registerusernametxb.Focus();
                        regnameErrorlbl.Text = required;

                        if(ActiveUser.IsValid(newusername))
                        {
                            registerpasstxb.Focus();
                            regpassErrorlbl.Text = required;

                            if(ActiveUser.IsValid(newpasswd))
                            {
                                repasswdtxb.Focus();
                                repassErrorlbl.Text = required;

                                if(ActiveUser.IsValid(repasswd))
                                {
                                    if (newpasswd.Equals(repasswd, StringComparison.Ordinal) == true)
                                    {
                                        activeUser.InsertNewUser(firstname, lastname, email, newusername, newpasswd, repasswd);
                                        this.Size = new Size(521, 235);                                        
                                        this.credentialsgbx.Enabled = true;
                                        userNametxb.Clear();
                                        passtxb.Clear();

                                        registergbx.Dispose();
                                        registerlinklbl.Dispose();
                                    }                                       
                                        registerpasstxb.Clear();
                                        repasswdtxb.Clear();
                                        registerpasstxb.Focus();
                                        repassErrorlbl.Text = "Does not match";
                                }
                                repassErrorlbl.Hide();
                            }
                            regnameErrorlbl.Hide();
                        }
                        emailErrorlbl.Hide();
                    }
                    lastnameErrolbl.Hide();            
                }
                firstnameErrlbl.Hide();                
            }            
            else
            {                
                firstnametbx.Focus();
               
                firstnameErrlbl.Text = required;
                lastnameErrolbl.Text = required;
                emailErrorlbl.Text = required;
                regnameErrorlbl.Text = required;
                regpassErrorlbl.Text = required;
                repassErrorlbl.Text = required;
            }
        }   
    }
}
