
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblFoundBug = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnChangelog = new System.Windows.Forms.Button();
            this.lblRepo = new System.Windows.Forms.LinkLabel();
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
            this.groupPCInfo = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblRootDirectory = new System.Windows.Forms.Label();
            this.lblOSVer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupCleanup.SuspendLayout();
            this.groupBloatwareRemoval.SuspendLayout();
            this.groupStartupPrograms.SuspendLayout();
            this.groupTaskManager.SuspendLayout();
            this.groupPCInfo.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.lblFoundBug);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.btnChangelog);
            this.panel1.Controls.Add(this.lblRepo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 585);
            this.panel1.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(-1, 492);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(131, 31);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblFoundBug
            // 
            this.lblFoundBug.AutoSize = true;
            this.lblFoundBug.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundBug.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFoundBug.Location = new System.Drawing.Point(11, 92);
            this.lblFoundBug.Name = "lblFoundBug";
            this.lblFoundBug.Size = new System.Drawing.Size(100, 20);
            this.lblFoundBug.TabIndex = 11;
            this.lblFoundBug.TabStop = true;
            this.lblFoundBug.Text = "Found A Bug?";
            this.lblFoundBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(70, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(60, 30);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "v1.3.1";
            // 
            // btnChangelog
            // 
            this.btnChangelog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangelog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangelog.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.btnChangelog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangelog.Location = new System.Drawing.Point(0, 446);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(131, 31);
            this.btnChangelog.TabIndex = 9;
            this.btnChangelog.Text = "Changelog";
            this.btnChangelog.UseVisualStyleBackColor = true;
            this.btnChangelog.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblRepo
            // 
            this.lblRepo.AutoSize = true;
            this.lblRepo.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepo.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRepo.Location = new System.Drawing.Point(11, 55);
            this.lblRepo.Name = "lblRepo";
            this.lblRepo.Size = new System.Drawing.Size(93, 20);
            this.lblRepo.TabIndex = 7;
            this.lblRepo.TabStop = true;
            this.lblRepo.Text = "GitHub Repo";
            this.lblRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.groupCleanup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupCleanup.Controls.Add(this.btnCleanup);
            this.groupCleanup.Controls.Add(this.lblCleanupDesc);
            this.groupCleanup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCleanup.ForeColor = System.Drawing.Color.White;
            this.groupCleanup.Location = new System.Drawing.Point(139, 12);
            this.groupCleanup.Name = "groupCleanup";
            this.groupCleanup.Size = new System.Drawing.Size(314, 119);
            this.groupCleanup.TabIndex = 4;
            this.groupCleanup.TabStop = false;
            this.groupCleanup.Text = "Cleaning";
            // 
            // groupBloatwareRemoval
            // 
            this.groupBloatwareRemoval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.groupStartupPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.groupTaskManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupTaskManager.Controls.Add(this.btnTaskManager);
            this.groupTaskManager.Controls.Add(this.lblTaskManagerDesc);
            this.groupTaskManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTaskManager.ForeColor = System.Drawing.Color.White;
            this.groupTaskManager.Location = new System.Drawing.Point(139, 387);
            this.groupTaskManager.Name = "groupTaskManager";
            this.groupTaskManager.Size = new System.Drawing.Size(314, 119);
            this.groupTaskManager.TabIndex = 7;
            this.groupTaskManager.TabStop = false;
            this.groupTaskManager.Text = "Improved Task Manager";
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
            // groupPCInfo
            // 
            this.groupPCInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupPCInfo.Controls.Add(this.lblOSVer);
            this.groupPCInfo.Controls.Add(this.lblRootDirectory);
            this.groupPCInfo.Controls.Add(this.lblUserName);
            this.groupPCInfo.Controls.Add(this.lblComputerName);
            this.groupPCInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPCInfo.ForeColor = System.Drawing.Color.White;
            this.groupPCInfo.Location = new System.Drawing.Point(459, 12);
            this.groupPCInfo.Name = "groupPCInfo";
            this.groupPCInfo.Size = new System.Drawing.Size(336, 244);
            this.groupPCInfo.TabIndex = 5;
            this.groupPCInfo.TabStop = false;
            this.groupPCInfo.Text = "PC Info";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblUserName.Location = new System.Drawing.Point(6, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name: %name%";
            // 
            // lblComputerName
            // 
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblComputerName.Location = new System.Drawing.Point(6, 19);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(165, 20);
            this.lblComputerName.TabIndex = 8;
            this.lblComputerName.Text = "Computer Name: %os%";
            // 
            // lblRootDirectory
            // 
            this.lblRootDirectory.AutoSize = true;
            this.lblRootDirectory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRootDirectory.Location = new System.Drawing.Point(6, 59);
            this.lblRootDirectory.Name = "lblRootDirectory";
            this.lblRootDirectory.Size = new System.Drawing.Size(139, 20);
            this.lblRootDirectory.TabIndex = 10;
            this.lblRootDirectory.Text = "Directory: %direct%";
            // 
            // lblOSVer
            // 
            this.lblOSVer.AutoSize = true;
            this.lblOSVer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOSVer.Location = new System.Drawing.Point(6, 79);
            this.lblOSVer.Name = "lblOSVer";
            this.lblOSVer.Size = new System.Drawing.Size(131, 20);
            this.lblOSVer.TabIndex = 11;
            this.lblOSVer.Text = "OS Version: %ver%";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(807, 552);
            this.Controls.Add(this.groupPCInfo);
            this.Controls.Add(this.groupTaskManager);
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
            this.groupCleanup.ResumeLayout(false);
            this.groupCleanup.PerformLayout();
            this.groupBloatwareRemoval.ResumeLayout(false);
            this.groupBloatwareRemoval.PerformLayout();
            this.groupStartupPrograms.ResumeLayout(false);
            this.groupStartupPrograms.PerformLayout();
            this.groupTaskManager.ResumeLayout(false);
            this.groupTaskManager.PerformLayout();
            this.groupPCInfo.ResumeLayout(false);
            this.groupPCInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.LinkLabel lblRepo;
        private System.Windows.Forms.Button btnChangelog;
        private System.Windows.Forms.GroupBox groupTaskManager;
        private System.Windows.Forms.Button btnTaskManager;
        private System.Windows.Forms.Label lblTaskManagerDesc;
        private System.Windows.Forms.LinkLabel lblFoundBug;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.GroupBox groupPCInfo;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblRootDirectory;
        private System.Windows.Forms.Label lblOSVer;
    }
}

