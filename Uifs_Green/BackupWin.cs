using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Uifs_Green
{
    public partial class BackupWin : Form
    {
        Utils_Green.User onlineUser;

        public Utils_Green.User OnlineUser
        {
            get { return onlineUser; }
            set { onlineUser = value; }
        }
        
        public BackupWin(Utils_Green.User onlineUser)
        {
            InitializeComponent();
            OnlineUser = onlineUser;
            unamelbl.Text = "User : " + onlineUser.Username ;
        }


        private void BackupWin_Load(object sender, EventArgs e)
        {

            Utils_Green.FileIO fileIO = new Utils_Green.FileIO();
            Utils_Green.FileIO.ListDrives(driveListcbx);
            string drivePath = Utils_Green.FileIO.GetSelectedDriveName(driveListcbx);
            fileIO.DisplayDirectoriesAndFiles(allTreeView, drivePath);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void sortupbtn_Click(object sender, EventArgs e)
        {
            allTreeView.ExpandAll();
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            Logs logForm = new Logs();
            logForm.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            ScheduleWin scheduleForm = new ScheduleWin();
            scheduleForm.ShowDialog();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
            AboutBackup aboutForm = new AboutBackup();
            aboutForm.Show();
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.greenspot.fi/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScheduleWin scheduleForm = new ScheduleWin();
            scheduleForm.ShowDialog();
        }
        private void clearAllbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllSelection(allTreeView.Nodes);
        }

        public void ClearAllSelection(TreeNodeCollection nodes)
        {
            foreach (TreeNode parent in nodes)
            {
                //uncheck parent nodes and child nodes using recursion method
                parent.Checked = false;
                ClearAllSelection(parent.Nodes);
            }
        }

        private void selectAlllbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectAllNodes(allTreeView.Nodes);
        }
        public void SelectAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode parent in nodes)
            {
                // check all nodes and child nodes(recursion method)
                parent.Checked = true;
                RecurseNodes(parent.Nodes);
            }            
        }
        private void RecurseNodes(TreeNodeCollection nodes)
        {
            nodes = allTreeView.Nodes;
            foreach (TreeNode node in nodes)
            {
                node.Checked = true;
                RecurseNodes(node.Nodes);
            }
        }    

        private void sortdownbtn_Click_1(object sender, EventArgs e)
        {            
            allTreeView.Sort();            
        }


        private void undobtn_Click(object sender, EventArgs e)
        {  

            ListView.CheckedListViewItemCollection chked = selectedFileList.CheckedItems;
            if (selectedFileList.Items.Count > 0)
            {
                if (chked.Count > 0)
                {
                    foreach (ListViewItem items in chked)
                    {
                        items.Remove();
                    }
                }
                else
                    MessageBox.Show(" No file chosen from the list!", "File Selector Info");
            }
            else
                MessageBox.Show(" Please Add files to the list !", "File Selector Info");
                
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void driveListcbx_SelectedValueChanged(object sender, EventArgs e)
        {
            string driveName = null;
            Utils_Green.FileIO fileIO = new Utils_Green.FileIO(); 
            //get the selected drive name and continue to populate the tree
            driveName = Utils_Green.FileIO.GetSelectedDriveName(driveListcbx);
            //Add all dirs and files to the root tree
            fileIO.DisplayDirectoriesAndFiles(allTreeView, driveName);
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 20)
            {
                selectedFileList.Items.Add("Test File " + i.ToString());
            }
        }

        private void selectedFileList_MouseClick(object sender, MouseEventArgs e)
        {
            // handy and easy
             selectedFileList.CheckBoxes = true;   
        }


        //add checked dirs and files to the list
        private void allTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNodeCollection NodesChecked = allTreeView.Nodes;
            string path = ((TreeView)sender).SelectedNode.FullPath;

            if (((TreeView)sender) != null)
            {
                // Add the checked directories and files to the list box 
                // infinite looping here...Need to recurse to all files or or
                string fp = Path.GetFileName(path);
                selectedFileList.Items.Add(fp);
            }
            else return;                              
        }

        private void allTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            //get the current node location
            TreeNode NodeAtStatus = allTreeView.GetNodeAt(e.Location);
            allTreeView.SelectedNode = NodeAtStatus;
            
            // Display the selected node tag/fullname to the status bar
            backupStatusBar.Panels[0].Text = NodeAtStatus.FullPath;

        }

        string filePath = @"E:\solution101\TestGreenBackup.txt";
        
        private void backupbtn_Click(object sender, EventArgs e)
        {
            //test case
            SaveBackupName();
            string testPath = Utils_Green.FileIO.StoreListedFiles(selectedFileList);

            Utils_Green.ClientSocket clientsoc = new Utils_Green.ClientSocket(onlineUser);
            Socket sock = clientsoc.EstablishClientSock();

            Utils_Green.AsynchronousNetStreamIO streamHandler = new Utils_Green.AsynchronousNetStreamIO(sock, OnlineUser);
            streamHandler.SendFileTo(filePath);
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            //test case....Calculate all the selected files for backup and result will be
            //send to the server to get the buffer size before streaming 
            Utils_Green.FileIO.GetFileSize(filePath);
        }

        //backup name
        private string backupName = string.Empty;
        DateTime date = DateTime.Now;       
            
     
        private void SaveBackupName()
        {
            backupName = bknametxb.Text;
            if (backupName.Length > 0)
            {
                backupName = bknametxb.Text;
            }
            else
            {
                bknametxb.Text = "Backup" + date.Date.ToLongDateString();
                backupName = "Backup" + date.Date.ToLongTimeString();                
            }
            MessageBox.Show("Backup will be saved as \n" + backupName, "Backup File Info");            
        }

        private void scheduleMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleWin scheduleForm = new ScheduleWin();
            scheduleForm.ShowDialog();
        }
    }
}
