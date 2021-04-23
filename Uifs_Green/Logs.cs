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
    public partial class Logs : Form
    {
//        List<string> _history = new List<string>();

        public Logs()
        {
            InitializeComponent();
            // Adding ListView Columns
            listView1.Columns.Add("Date", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("History", 350, HorizontalAlignment.Left);

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

//        private void backbtn_Click(object sender, EventArgs e)
//        {
//            BackupWin backupForm = new BackupWin();
//            backupForm.Focus();
//            this.Close();
//        }

    }
}
