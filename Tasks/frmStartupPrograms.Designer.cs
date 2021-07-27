
namespace Tasks
{
    partial class frmStartupPrograms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartupPrograms));
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewFolderLocationWIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.vistaOpenFileDialog1 = new Ookii.Dialogs.WinForms.VistaOpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.taskDialog1 = new Ookii.Dialogs.WinForms.TaskDialog(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(307, 445);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFolderLocationWIPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 26);
            // 
            // viewFolderLocationWIPToolStripMenuItem
            // 
            this.viewFolderLocationWIPToolStripMenuItem.Name = "viewFolderLocationWIPToolStripMenuItem";
            this.viewFolderLocationWIPToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.viewFolderLocationWIPToolStripMenuItem.Text = "View File Location (WIP)";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(339, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(339, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // vistaOpenFileDialog1
            // 
            this.vistaOpenFileDialog1.FileName = "vistaOpenFileDialog1";
            this.vistaOpenFileDialog1.Filter = null;
            this.vistaOpenFileDialog1.Title = "Please select a file to add on Startup.";
            this.vistaOpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.vistaOpenFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open Startup Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // taskDialog1
            // 
            this.taskDialog1.MainInstruction = "taskDialog1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "Debug Logs:"});
            this.listBox1.Location = new System.Drawing.Point(339, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 206);
            this.listBox1.TabIndex = 8;
            // 
            // frmStartupPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(641, 469);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartupPrograms";
            this.Text = "Startup Programs";
            this.Load += new System.EventHandler(this.frmStartupManager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewFolderLocationWIPToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private Ookii.Dialogs.WinForms.VistaOpenFileDialog vistaOpenFileDialog1;
        private System.Windows.Forms.Button button2;
        private Ookii.Dialogs.WinForms.TaskDialog taskDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}