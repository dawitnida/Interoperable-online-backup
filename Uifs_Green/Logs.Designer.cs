namespace Uifs_Green
{
    partial class Logs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            this.containerpnl = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.closebtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LogStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.containerpnl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerpnl
            // 
            this.containerpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.containerpnl.Controls.Add(this.listView1);
            this.containerpnl.Controls.Add(this.closebtn);
            this.containerpnl.Controls.Add(this.statusStrip1);
            this.containerpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerpnl.Location = new System.Drawing.Point(0, 0);
            this.containerpnl.Name = "containerpnl";
            this.containerpnl.Size = new System.Drawing.Size(570, 433);
            this.containerpnl.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(0, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 346);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // closebtn
            // 
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closebtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closebtn.Location = new System.Drawing.Point(503, 385);
            this.closebtn.Margin = new System.Windows.Forms.Padding(2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(56, 24);
            this.closebtn.TabIndex = 17;
            this.closebtn.Text = "close";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogStatuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LogStatuslbl
            // 
            this.LogStatuslbl.BackColor = System.Drawing.SystemColors.Info;
            this.LogStatuslbl.Name = "LogStatuslbl";
            this.LogStatuslbl.Size = new System.Drawing.Size(39, 17);
            this.LogStatuslbl.Text = "Status";
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closebtn;
            this.ClientSize = new System.Drawing.Size(570, 433);
            this.Controls.Add(this.containerpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Logs";
            this.containerpnl.ResumeLayout(false);
            this.containerpnl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel containerpnl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LogStatuslbl;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.ListView listView1;
    }
}