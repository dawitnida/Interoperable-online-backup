using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uifs_Green
{
    public partial class ScheduleWin : Form
    {
        public ScheduleWin()
        {
            InitializeComponent();
        }

        private void BackupWin_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            timelbl.Text = now.ToLocalTime().ToString();

        }

//        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }
        //check if any form is open ->> Useful for any form
//        private bool IsFormOpen(Form iForm)
//        {
//            // traverse through the application windows(default open windows) 
//            // and close the selected child window otherwise go out of the looop!!!
//            foreach (Form f in Application.OpenForms)
//                if (iForm == f)
//                {
//                    this.Hide();
//                    return true;
//                }
//            return false;
//        }
//        private void backupbtn_Click(object sender, EventArgs e)
//        {
//            BackupWin backupForm = new BackupWin();
//            backupForm.Show();
//
//            if (IsFormOpen(backupForm))
//            {
//                backupForm.Show();
//                this.Close();
//                //loginForm.Dispose();                
//            }
//            else
//                this.Show();
//        }

//        private void toolStripMenuItem2_Click(object sender, EventArgs e)
//        {
//            BackupWin backupForm = new BackupWin();
//            backupForm.Show();
//
//            if (IsFormOpen(backupForm))
//            {
//                backupForm.Show();
//                this.Close();
//                //loginForm.Dispose();                
//            }
//            else
//                this.Show();
//        }
//
//        private void greenspotToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            System.Diagnostics.Process.Start("IExplore", "http://www.greenspot.fi/");
//        }
//
//        private void viewLogsToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Logs logsForm = new Logs();
//            logsForm.Show();
//        }
//
//        private void toolStripMenuItem3_Click(object sender, EventArgs e)
//        {
//            this.Focus();
//        }

//        private void aboutGreenspotToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            AboutBackup about = new AboutBackup();
//            about.Show();
//        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to be implemented....
            this.Dispose();
        }

                 
    }
}
