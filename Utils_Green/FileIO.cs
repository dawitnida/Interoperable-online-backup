using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Utils_Green
{
    public sealed class FileIO
    {

        /// <summary>
        /// List all ready drives and add it to the combo box
        /// </summary>
        /// <param name="listcbx"></param>
        public static void ListDrives(ComboBox listcbx)
        {
            // get all ready drives and save it into the array 
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivesInfo)
            {
                if (drive.IsReady)
                {
                    listcbx.Items.Add(drive.Name);
                }
                else
                {
                    //test case
                    MessageBox.Show(" Drive " + drive.Name + " not ready!", " Drive Selector Info");
                }
            }
        }


        /// <summary>
        /// get drives from the host computer and return drive name
        /// Add to the combobox list
        /// </summary>
        /// <param name="drivescbx"></param>
        /// <returns></returns>
        public static string GetSelectedDriveName(ComboBox drivescbx)
        {
            string dr = null;
            dr = drivescbx.GetItemText(drivescbx.SelectedItem);

            if (dr.Length > 0)
            {
                //Test case
                MessageBox.Show("Selected Drive " + dr, " Drive Selector Info");
                return dr;
            }
            else
            {
                drivescbx.SelectedIndex = -1;
                drivescbx.SelectedValue = drivescbx.SelectedIndex;
                dr = drivescbx.GetItemText(drivescbx.SelectedItem);

                //test case
                //   MessageBox.Show("Default drive" + dr);
                return @"D:\";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="drive"></param>
        public void DisplayDirectoriesAndFiles(TreeView tree, string drive)
        {

            //clear everything from the treeview
            tree.Nodes.Clear();
            tree.BeginUpdate();
            //get all drives from the computer
            tree.Nodes.Add(Environment.UserName);

            DirectoryInfo di = new DirectoryInfo(drive);
            DirectoryInfo[] dirInfo = di.GetDirectories();

            foreach (DirectoryInfo rootDirs in dirInfo)
            {
                TreeNode parent = new TreeNode(rootDirs.FullName);

                parent.ImageIndex = 0;
                parent.Tag = rootDirs;
                tree.Nodes[0].Nodes.Add(parent);
                GetFiles(rootDirs, parent);
                tree.EndUpdate();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dirInfo"></param>
        /// <param name="child"></param>
        private void GetFiles(DirectoryInfo dirInfo, TreeNode child)
        {
            try
            {
                DirectoryInfo[] dirInfoArray = dirInfo.GetDirectories();
                if (dirInfoArray.Length != 0)
                {
                    foreach (DirectoryInfo subDirs in dirInfoArray)
                    {
                        //Add the subdirectories to the upper level node
                        TreeNode dirNode = new TreeNode();
                        dirNode = child.Nodes.Add(subDirs.Name);
                        GetFiles(subDirs, dirNode);
                        dirNode.Tag = subDirs;
                    }
                    // Get any files for this node.
                    FileInfo[] files = dirInfo.GetFiles();
                    // After placing the nodes place the files in that subdirectory
                    foreach (FileInfo file in files)
                    {
                        TreeNode fileNode = new TreeNode(file.Name);
                        child.Nodes.Add(fileNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                //test case
                //  MessageBox.Show( ex.ToString() + "File Access denied " , " File Access Info");                    
            }
        }

        /// <summary>
        /// Get the full path name from the selected/checked file on the ListBox
        /// </summary>
        /// <param name="fPath"></param>
        /// <returns>full file path so that it will be used when a user needs to backup</returns>
        public static string ParseFilePath(string fPath)
        {

            string fullPath = Path.GetFileName(fPath);
            return fullPath;
        }
        public static string GetFileSize(string fPath)
        {
            FileInfo fileInfo = new FileInfo(fPath);
            string fSize = fileInfo.Length.ToString();
            return fSize;
        }

        // Testcase
        private static List<string> readyFiles = new List<string>();
        public static string StoreListedFiles(ListView box)
        {

            ListView.CheckedListViewItemCollection chked = box.CheckedItems;
            for (int i = 0; i < chked.Count; )
            {
                string filename = box.CheckedItems[i].Text;
                foreach (ListViewItem items in chked)
                {
                    items.Checked = true;
                    readyFiles.Add(filename); ;
                }
                return filename;
            }
            return null;
        }
    }
}



