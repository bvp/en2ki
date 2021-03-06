﻿namespace en2ki
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.gbEvernoteLogin = new System.Windows.Forms.GroupBox();
            this.gbSaveTo = new System.Windows.Forms.GroupBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.tbSaveFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gbExport = new System.Windows.Forms.GroupBox();
            this.rdoExportSelected = new System.Windows.Forms.RadioButton();
            this.rdoExportAll = new System.Windows.Forms.RadioButton();
            this.gbEvernoteLogin.SuspendLayout();
            this.gbSaveTo.SuspendLayout();
            this.status.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(64, 22);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(130, 20);
            this.tbID.TabIndex = 2;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(64, 46);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(130, 20);
            this.tbPW.TabIndex = 3;
            // 
            // gbEvernoteLogin
            // 
            this.gbEvernoteLogin.Controls.Add(this.label1);
            this.gbEvernoteLogin.Controls.Add(this.tbPW);
            this.gbEvernoteLogin.Controls.Add(this.label2);
            this.gbEvernoteLogin.Controls.Add(this.tbID);
            this.gbEvernoteLogin.Location = new System.Drawing.Point(10, 30);
            this.gbEvernoteLogin.Name = "gbEvernoteLogin";
            this.gbEvernoteLogin.Size = new System.Drawing.Size(200, 77);
            this.gbEvernoteLogin.TabIndex = 4;
            this.gbEvernoteLogin.TabStop = false;
            this.gbEvernoteLogin.Text = "Evernote Login";
            // 
            // gbSaveTo
            // 
            this.gbSaveTo.Controls.Add(this.btnSaveFolder);
            this.gbSaveTo.Controls.Add(this.tbSaveFolder);
            this.gbSaveTo.Location = new System.Drawing.Point(216, 30);
            this.gbSaveTo.Name = "gbSaveTo";
            this.gbSaveTo.Size = new System.Drawing.Size(200, 77);
            this.gbSaveTo.TabIndex = 5;
            this.gbSaveTo.TabStop = false;
            this.gbSaveTo.Text = "Save To";
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Location = new System.Drawing.Point(6, 39);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFolder.TabIndex = 1;
            this.btnSaveFolder.Text = "Browse...";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // tbSaveFolder
            // 
            this.tbSaveFolder.Location = new System.Drawing.Point(6, 15);
            this.tbSaveFolder.Name = "tbSaveFolder";
            this.tbSaveFolder.ReadOnly = true;
            this.tbSaveFolder.Size = new System.Drawing.Size(188, 20);
            this.tbSaveFolder.TabIndex = 0;
            // 
            // status
            // 
            this.status.AutoSize = false;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 115);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(653, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 6;
            // 
            // statusProgress
            // 
            this.statusProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(559, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 77);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gbExport
            // 
            this.gbExport.Controls.Add(this.rdoExportSelected);
            this.gbExport.Controls.Add(this.rdoExportAll);
            this.gbExport.Location = new System.Drawing.Point(423, 30);
            this.gbExport.Name = "gbExport";
            this.gbExport.Size = new System.Drawing.Size(130, 77);
            this.gbExport.TabIndex = 10;
            this.gbExport.TabStop = false;
            this.gbExport.Text = "Export";
            // 
            // rdoExportSelected
            // 
            this.rdoExportSelected.AutoSize = true;
            this.rdoExportSelected.Location = new System.Drawing.Point(7, 44);
            this.rdoExportSelected.Name = "rdoExportSelected";
            this.rdoExportSelected.Size = new System.Drawing.Size(122, 17);
            this.rdoExportSelected.TabIndex = 1;
            this.rdoExportSelected.Text = "Selected Notebooks";
            this.rdoExportSelected.UseVisualStyleBackColor = true;
            // 
            // rdoExportAll
            // 
            this.rdoExportAll.AutoSize = true;
            this.rdoExportAll.Checked = true;
            this.rdoExportAll.Location = new System.Drawing.Point(7, 20);
            this.rdoExportAll.Name = "rdoExportAll";
            this.rdoExportAll.Size = new System.Drawing.Size(91, 17);
            this.rdoExportAll.TabIndex = 0;
            this.rdoExportAll.TabStop = true;
            this.rdoExportAll.Text = "All Notebooks";
            this.rdoExportAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 137);
            this.Controls.Add(this.gbExport);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbSaveTo);
            this.Controls.Add(this.gbEvernoteLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "en2ki ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbEvernoteLogin.ResumeLayout(false);
            this.gbEvernoteLogin.PerformLayout();
            this.gbSaveTo.ResumeLayout(false);
            this.gbSaveTo.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbExport.ResumeLayout(false);
            this.gbExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.GroupBox gbEvernoteLogin;
        private System.Windows.Forms.GroupBox gbSaveTo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.TextBox tbSaveFolder;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox gbExport;
        private System.Windows.Forms.RadioButton rdoExportSelected;
        private System.Windows.Forms.RadioButton rdoExportAll;
    }
}

