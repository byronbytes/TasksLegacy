
namespace Tasks
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblFoundBug = new System.Windows.Forms.LinkLabel();
            this.btnCleanup = new System.Windows.Forms.Button();
            this.lblCleanupDesc = new System.Windows.Forms.Label();
            this.groupCleanup = new System.Windows.Forms.GroupBox();
            this.groupBloatwareRemoval = new System.Windows.Forms.GroupBox();
            this.btnRemoveBloat = new System.Windows.Forms.Button();
            this.lblBloatwareDesc = new System.Windows.Forms.Label();
            this.groupStartupPrograms = new System.Windows.Forms.GroupBox();
            this.btnStartupPrograms = new System.Windows.Forms.Button();
            this.lblStartupProgramsDesc = new System.Windows.Forms.Label();
            this.groupTaskManager = new System.Windows.Forms.GroupBox();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.lblTaskManagerDesc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupCleanup.SuspendLayout();
            this.groupBloatwareRemoval.SuspendLayout();
            this.groupStartupPrograms.SuspendLayout();
            this.groupTaskManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 16.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tasks";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 594);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Tasks.Properties.Resources.GitHub_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(12, 525);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Tasks.Properties.Resources.Twitter;
            this.pictureBox2.Location = new System.Drawing.Point(94, 525);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Tasks.Properties.Resources.Discord;
            this.pictureBox1.Location = new System.Drawing.Point(52, 525);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 488);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(133, 31);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(70, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(64, 30);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "v1.4.0";
            // 
            // lblFoundBug
            // 
            this.lblFoundBug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoundBug.AutoSize = true;
            this.lblFoundBug.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundBug.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFoundBug.Location = new System.Drawing.Point(545, 527);
            this.lblFoundBug.Name = "lblFoundBug";
            this.lblFoundBug.Size = new System.Drawing.Size(100, 20);
            this.lblFoundBug.TabIndex = 11;
            this.lblFoundBug.TabStop = true;
            this.lblFoundBug.Text = "Found A Bug?";
            this.lblFoundBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnCleanup
            // 
            this.btnCleanup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanup.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanup.ForeColor = System.Drawing.Color.Black;
            this.btnCleanup.Location = new System.Drawing.Point(9, 19);
            this.btnCleanup.Name = "btnCleanup";
            this.btnCleanup.Size = new System.Drawing.Size(141, 40);
            this.btnCleanup.TabIndex = 2;
            this.btnCleanup.Text = "Cleanup";
            this.btnCleanup.UseVisualStyleBackColor = true;
            this.btnCleanup.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCleanupDesc
            // 
            this.lblCleanupDesc.AutoSize = true;
            this.lblCleanupDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleanupDesc.ForeColor = System.Drawing.Color.White;
            this.lblCleanupDesc.Location = new System.Drawing.Point(6, 62);
            this.lblCleanupDesc.Name = "lblCleanupDesc";
            this.lblCleanupDesc.Size = new System.Drawing.Size(299, 34);
            this.lblCleanupDesc.TabIndex = 3;
            this.lblCleanupDesc.Text = "Cleanup will clean your computer of junk  and temp\r\n folders. You may customize w" +
    "hat folders get cleared.";
            // 
            // groupCleanup
            // 
            this.groupCleanup.Controls.Add(this.btnCleanup);
            this.groupCleanup.Controls.Add(this.lblCleanupDesc);
            this.groupCleanup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCleanup.ForeColor = System.Drawing.Color.White;
            this.groupCleanup.Location = new System.Drawing.Point(139, 12);
            this.groupCleanup.Name = "groupCleanup";
            this.groupCleanup.Size = new System.Drawing.Size(314, 119);
            this.groupCleanup.TabIndex = 4;
            this.groupCleanup.TabStop = false;
            this.groupCleanup.Text = "Cleanup";
            // 
            // groupBloatwareRemoval
            // 
            this.groupBloatwareRemoval.Controls.Add(this.btnRemoveBloat);
            this.groupBloatwareRemoval.Controls.Add(this.lblBloatwareDesc);
            this.groupBloatwareRemoval.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBloatwareRemoval.ForeColor = System.Drawing.Color.White;
            this.groupBloatwareRemoval.Location = new System.Drawing.Point(139, 137);
            this.groupBloatwareRemoval.Name = "groupBloatwareRemoval";
            this.groupBloatwareRemoval.Size = new System.Drawing.Size(314, 119);
            this.groupBloatwareRemoval.TabIndex = 5;
            this.groupBloatwareRemoval.TabStop = false;
            this.groupBloatwareRemoval.Text = "Remove Bloatware";
            // 
            // btnRemoveBloat
            // 
            this.btnRemoveBloat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveBloat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBloat.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveBloat.Location = new System.Drawing.Point(9, 19);
            this.btnRemoveBloat.Name = "btnRemoveBloat";
            this.btnRemoveBloat.Size = new System.Drawing.Size(141, 40);
            this.btnRemoveBloat.TabIndex = 2;
            this.btnRemoveBloat.Text = "Remove Bloat";
            this.btnRemoveBloat.UseVisualStyleBackColor = true;
            this.btnRemoveBloat.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblBloatwareDesc
            // 
            this.lblBloatwareDesc.AutoSize = true;
            this.lblBloatwareDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloatwareDesc.ForeColor = System.Drawing.Color.White;
            this.lblBloatwareDesc.Location = new System.Drawing.Point(6, 62);
            this.lblBloatwareDesc.Name = "lblBloatwareDesc";
            this.lblBloatwareDesc.Size = new System.Drawing.Size(289, 51);
            this.lblBloatwareDesc.TabIndex = 3;
            this.lblBloatwareDesc.Text = "This will remove bloat from your computer such as \r\nbuilt in Windows Store Apps, " +
    "and remove \r\nbloatware registry keys.\r\n";
            // 
            // groupStartupPrograms
            // 
            this.groupStartupPrograms.Controls.Add(this.btnStartupPrograms);
            this.groupStartupPrograms.Controls.Add(this.lblStartupProgramsDesc);
            this.groupStartupPrograms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStartupPrograms.ForeColor = System.Drawing.Color.White;
            this.groupStartupPrograms.Location = new System.Drawing.Point(139, 262);
            this.groupStartupPrograms.Name = "groupStartupPrograms";
            this.groupStartupPrograms.Size = new System.Drawing.Size(314, 119);
            this.groupStartupPrograms.TabIndex = 6;
            this.groupStartupPrograms.TabStop = false;
            this.groupStartupPrograms.Text = "Startup Programs";
            // 
            // btnStartupPrograms
            // 
            this.btnStartupPrograms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartupPrograms.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartupPrograms.ForeColor = System.Drawing.Color.Black;
            this.btnStartupPrograms.Location = new System.Drawing.Point(9, 19);
            this.btnStartupPrograms.Name = "btnStartupPrograms";
            this.btnStartupPrograms.Size = new System.Drawing.Size(141, 40);
            this.btnStartupPrograms.TabIndex = 2;
            this.btnStartupPrograms.Text = "Startup Programs";
            this.btnStartupPrograms.UseVisualStyleBackColor = true;
            this.btnStartupPrograms.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblStartupProgramsDesc
            // 
            this.lblStartupProgramsDesc.AutoSize = true;
            this.lblStartupProgramsDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartupProgramsDesc.ForeColor = System.Drawing.Color.White;
            this.lblStartupProgramsDesc.Location = new System.Drawing.Point(6, 62);
            this.lblStartupProgramsDesc.Name = "lblStartupProgramsDesc";
            this.lblStartupProgramsDesc.Size = new System.Drawing.Size(288, 34);
            this.lblStartupProgramsDesc.TabIndex = 3;
            this.lblStartupProgramsDesc.Text = "You can view, add, and remove programs that run \r\non start.";
            // 
            // groupTaskManager
            // 
            this.groupTaskManager.Controls.Add(this.btnTaskManager);
            this.groupTaskManager.Controls.Add(this.lblTaskManagerDesc);
            this.groupTaskManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTaskManager.ForeColor = System.Drawing.Color.White;
            this.groupTaskManager.Location = new System.Drawing.Point(139, 387);
            this.groupTaskManager.Name = "groupTaskManager";
            this.groupTaskManager.Size = new System.Drawing.Size(314, 119);
            this.groupTaskManager.TabIndex = 7;
            this.groupTaskManager.TabStop = false;
            this.groupTaskManager.Text = "Task Manager";
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskManager.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskManager.ForeColor = System.Drawing.Color.Black;
            this.btnTaskManager.Location = new System.Drawing.Point(9, 19);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(141, 40);
            this.btnTaskManager.TabIndex = 2;
            this.btnTaskManager.Text = "Task Manager";
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTaskManagerDesc
            // 
            this.lblTaskManagerDesc.AutoSize = true;
            this.lblTaskManagerDesc.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskManagerDesc.ForeColor = System.Drawing.Color.White;
            this.lblTaskManagerDesc.Location = new System.Drawing.Point(6, 62);
            this.lblTaskManagerDesc.Name = "lblTaskManagerDesc";
            this.lblTaskManagerDesc.Size = new System.Drawing.Size(282, 51);
            this.lblTaskManagerDesc.TabIndex = 3;
            this.lblTaskManagerDesc.Text = "A more improved and efficient task manager. This\r\nwill include basic task manager" +
    " features and \r\nmore.\r\n";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(657, 552);
            this.Controls.Add(this.groupTaskManager);
            this.Controls.Add(this.lblFoundBug);
            this.Controls.Add(this.groupStartupPrograms);
            this.Controls.Add(this.groupBloatwareRemoval);
            this.Controls.Add(this.groupCleanup);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = " Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupCleanup.ResumeLayout(false);
            this.groupCleanup.PerformLayout();
            this.groupBloatwareRemoval.ResumeLayout(false);
            this.groupBloatwareRemoval.PerformLayout();
            this.groupStartupPrograms.ResumeLayout(false);
            this.groupStartupPrograms.PerformLayout();
            this.groupTaskManager.ResumeLayout(false);
            this.groupTaskManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCleanup;
        private System.Windows.Forms.Label lblCleanupDesc;
        private System.Windows.Forms.GroupBox groupCleanup;
        private System.Windows.Forms.GroupBox groupBloatwareRemoval;
        private System.Windows.Forms.Button btnRemoveBloat;
        private System.Windows.Forms.Label lblBloatwareDesc;
        private System.Windows.Forms.GroupBox groupStartupPrograms;
        private System.Windows.Forms.Button btnStartupPrograms;
        private System.Windows.Forms.Label lblStartupProgramsDesc;
        private System.Windows.Forms.GroupBox groupTaskManager;
        private System.Windows.Forms.Button btnTaskManager;
        private System.Windows.Forms.Label lblTaskManagerDesc;
        private System.Windows.Forms.LinkLabel lblFoundBug;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

