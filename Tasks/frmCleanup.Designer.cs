
namespace Tasks
{
    partial class FrmCleanup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCleanup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.CleanupBtn = new System.Windows.Forms.Button();
            this.CleanupLogsLBox = new System.Windows.Forms.ListBox();
            this.taskDialog1 = new Ookii.Dialogs.WinForms.TaskDialog(this.components);
            this.taskDialogButton1 = new Ookii.Dialogs.WinForms.TaskDialogButton(this.components);
            this.CopyLogsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cleanup Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.checkBox1.Location = new System.Drawing.Point(8, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Clear Recycle Bin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.checkBox2.Location = new System.Drawing.Point(8, 65);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 29);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Clear Downloads";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.checkBox3.Location = new System.Drawing.Point(8, 101);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(179, 29);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Clear Temp Folders";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.checkBox4.Location = new System.Drawing.Point(8, 137);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(141, 29);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Clear Prefetch";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // CleanupBtn
            // 
            this.CleanupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CleanupBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanupBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.CleanupBtn.Location = new System.Drawing.Point(629, 478);
            this.CleanupBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CleanupBtn.Name = "CleanupBtn";
            this.CleanupBtn.Size = new System.Drawing.Size(175, 45);
            this.CleanupBtn.TabIndex = 1;
            this.CleanupBtn.Text = "Cleanup";
            this.CleanupBtn.UseVisualStyleBackColor = true;
            this.CleanupBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CleanupLogsLBox
            // 
            this.CleanupLogsLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CleanupLogsLBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CleanupLogsLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CleanupLogsLBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CleanupLogsLBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CleanupLogsLBox.ForeColor = System.Drawing.Color.White;
            this.CleanupLogsLBox.FormattingEnabled = true;
            this.CleanupLogsLBox.HorizontalScrollbar = true;
            this.CleanupLogsLBox.ItemHeight = 21;
            this.CleanupLogsLBox.Items.AddRange(new object[] {
            "Cleanup Logs:"});
            this.CleanupLogsLBox.Location = new System.Drawing.Point(16, 185);
            this.CleanupLogsLBox.Margin = new System.Windows.Forms.Padding(4);
            this.CleanupLogsLBox.Name = "CleanupLogsLBox";
            this.CleanupLogsLBox.Size = new System.Drawing.Size(559, 338);
            this.CleanupLogsLBox.TabIndex = 7;
            // 
            // taskDialog1
            // 
            this.taskDialog1.Buttons.Add(this.taskDialogButton1);
            this.taskDialog1.ButtonStyle = Ookii.Dialogs.WinForms.TaskDialogButtonStyle.CommandLinks;
            this.taskDialog1.Content = "You did not select anything to clean!";
            this.taskDialog1.FooterIcon = Ookii.Dialogs.WinForms.TaskDialogIcon.Shield;
            this.taskDialog1.MainInstruction = "Cleanup Error";
            this.taskDialog1.WindowTitle = "Tasks";
            // 
            // taskDialogButton1
            // 
            this.taskDialogButton1.Text = "Okay";
            // 
            // CopyLogsBtn
            // 
            this.CopyLogsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyLogsBtn.Enabled = false;
            this.CopyLogsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyLogsBtn.ForeColor = System.Drawing.Color.Black;
            this.CopyLogsBtn.Location = new System.Drawing.Point(629, 425);
            this.CopyLogsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CopyLogsBtn.Name = "CopyLogsBtn";
            this.CopyLogsBtn.Size = new System.Drawing.Size(175, 45);
            this.CopyLogsBtn.TabIndex = 8;
            this.CopyLogsBtn.Text = "Copy Logs";
            this.CopyLogsBtn.UseVisualStyleBackColor = true;
            this.CopyLogsBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FrmCleanup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(819, 551);
            this.Controls.Add(this.CopyLogsBtn);
            this.Controls.Add(this.CleanupLogsLBox);
            this.Controls.Add(this.CleanupBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCleanup";
            this.Text = "Cleanup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CleanupBtn;
        private System.Windows.Forms.ListBox CleanupLogsLBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private Ookii.Dialogs.WinForms.TaskDialog taskDialog1;
        private Ookii.Dialogs.WinForms.TaskDialogButton taskDialogButton1;
        private System.Windows.Forms.Button CopyLogsBtn;
    }
}