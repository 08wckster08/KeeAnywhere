﻿namespace KeeAnywhere.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.m_bannerImage = new System.Windows.Forms.PictureBox();
            this.m_tcSettings = new System.Windows.Forms.TabControl();
            this.m_tabAccounts = new System.Windows.Forms.TabPage();
            this.m_btnAccountCheck = new System.Windows.Forms.Button();
            this.m_btnAccountAdd = new KeeAnywhere.Forms.DropDownButton();
            this.m_mnuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_btnAccountRemove = new System.Windows.Forms.Button();
            this.m_lvAccounts = new System.Windows.Forms.ListView();
            this.m_imlProviderIcons = new System.Windows.Forms.ImageList(this.components);
            this.lnklblHelpMeChooseAccountStorage = new System.Windows.Forms.LinkLabel();
            this.m_rbStorageLocation_Disk = new System.Windows.Forms.RadioButton();
            this.m_rbStorageLocation_LocalUserSecureStore = new System.Windows.Forms.RadioButton();
            this.lblAccountStorageLocation = new System.Windows.Forms.Label();
            this.m_tabGeneral = new System.Windows.Forms.TabPage();
            this.m_cbOfflineCache = new System.Windows.Forms.CheckBox();
            this.m_tabAbout = new System.Windows.Forms.TabPage();
            this.m_lblAboutVersion = new System.Windows.Forms.Label();
            this.m_lblAboutExplanation = new System.Windows.Forms.Label();
            this.m_lblAboutHeader = new System.Windows.Forms.Label();
            this.m_btnOK = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_mnuHelp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_mnuHelp_Documentation = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_Homepage = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_WhatsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_License = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuHelp_ReportBug = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_ContactAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mnuHelp_Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_mnuHelp_Donate = new System.Windows.Forms.ToolStripMenuItem();
            this.m_btnHelp = new KeeAnywhere.Forms.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
            this.m_tcSettings.SuspendLayout();
            this.m_tabAccounts.SuspendLayout();
            this.m_tabGeneral.SuspendLayout();
            this.m_tabAbout.SuspendLayout();
            this.m_mnuHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_bannerImage
            // 
            this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
            this.m_bannerImage.Name = "m_bannerImage";
            this.m_bannerImage.Size = new System.Drawing.Size(622, 60);
            this.m_bannerImage.TabIndex = 4;
            this.m_bannerImage.TabStop = false;
            // 
            // m_tcSettings
            // 
            this.m_tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tcSettings.Controls.Add(this.m_tabAccounts);
            this.m_tcSettings.Controls.Add(this.m_tabGeneral);
            this.m_tcSettings.Controls.Add(this.m_tabAbout);
            this.m_tcSettings.Location = new System.Drawing.Point(12, 66);
            this.m_tcSettings.Name = "m_tcSettings";
            this.m_tcSettings.SelectedIndex = 0;
            this.m_tcSettings.Size = new System.Drawing.Size(598, 287);
            this.m_tcSettings.TabIndex = 5;
            // 
            // m_tabAccounts
            // 
            this.m_tabAccounts.Controls.Add(this.m_btnAccountCheck);
            this.m_tabAccounts.Controls.Add(this.m_btnAccountAdd);
            this.m_tabAccounts.Controls.Add(this.m_btnAccountRemove);
            this.m_tabAccounts.Controls.Add(this.m_lvAccounts);
            this.m_tabAccounts.Controls.Add(this.lnklblHelpMeChooseAccountStorage);
            this.m_tabAccounts.Controls.Add(this.m_rbStorageLocation_Disk);
            this.m_tabAccounts.Controls.Add(this.m_rbStorageLocation_LocalUserSecureStore);
            this.m_tabAccounts.Controls.Add(this.lblAccountStorageLocation);
            this.m_tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.m_tabAccounts.Name = "m_tabAccounts";
            this.m_tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabAccounts.Size = new System.Drawing.Size(590, 261);
            this.m_tabAccounts.TabIndex = 1;
            this.m_tabAccounts.Text = "Accounts";
            this.m_tabAccounts.UseVisualStyleBackColor = true;
            // 
            // m_btnAccountCheck
            // 
            this.m_btnAccountCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnAccountCheck.Location = new System.Drawing.Point(490, 96);
            this.m_btnAccountCheck.Name = "m_btnAccountCheck";
            this.m_btnAccountCheck.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccountCheck.TabIndex = 12;
            this.m_btnAccountCheck.Text = "Check";
            this.m_btnAccountCheck.UseVisualStyleBackColor = true;
            this.m_btnAccountCheck.Click += new System.EventHandler(this.OnAccountCheck);
            // 
            // m_btnAccountAdd
            // 
            this.m_btnAccountAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnAccountAdd.Location = new System.Drawing.Point(490, 38);
            this.m_btnAccountAdd.Menu = this.m_mnuAdd;
            this.m_btnAccountAdd.Name = "m_btnAccountAdd";
            this.m_btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccountAdd.TabIndex = 11;
            this.m_btnAccountAdd.Text = "Add...";
            this.m_btnAccountAdd.UseVisualStyleBackColor = true;
            // 
            // m_mnuAdd
            // 
            this.m_mnuAdd.Name = "m_mnuAdd";
            this.m_mnuAdd.Size = new System.Drawing.Size(61, 4);
            // 
            // m_btnAccountRemove
            // 
            this.m_btnAccountRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnAccountRemove.Location = new System.Drawing.Point(490, 67);
            this.m_btnAccountRemove.Name = "m_btnAccountRemove";
            this.m_btnAccountRemove.Size = new System.Drawing.Size(75, 23);
            this.m_btnAccountRemove.TabIndex = 10;
            this.m_btnAccountRemove.Text = "Remove";
            this.m_btnAccountRemove.UseVisualStyleBackColor = true;
            this.m_btnAccountRemove.Click += new System.EventHandler(this.OnAccountRemove);
            // 
            // m_lvAccounts
            // 
            this.m_lvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lvAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.m_lvAccounts.LabelEdit = true;
            this.m_lvAccounts.Location = new System.Drawing.Point(7, 38);
            this.m_lvAccounts.MultiSelect = false;
            this.m_lvAccounts.Name = "m_lvAccounts";
            this.m_lvAccounts.Size = new System.Drawing.Size(476, 217);
            this.m_lvAccounts.SmallImageList = this.m_imlProviderIcons;
            this.m_lvAccounts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.m_lvAccounts.TabIndex = 9;
            this.m_lvAccounts.UseCompatibleStateImageBehavior = false;
            this.m_lvAccounts.View = System.Windows.Forms.View.Details;
            this.m_lvAccounts.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.OnAfterLabelEdit);
            // 
            // m_imlProviderIcons
            // 
            this.m_imlProviderIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.m_imlProviderIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.m_imlProviderIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lnklblHelpMeChooseAccountStorage
            // 
            this.lnklblHelpMeChooseAccountStorage.AutoSize = true;
            this.lnklblHelpMeChooseAccountStorage.Location = new System.Drawing.Point(408, 9);
            this.lnklblHelpMeChooseAccountStorage.Name = "lnklblHelpMeChooseAccountStorage";
            this.lnklblHelpMeChooseAccountStorage.Size = new System.Drawing.Size(156, 13);
            this.lnklblHelpMeChooseAccountStorage.TabIndex = 8;
            this.lnklblHelpMeChooseAccountStorage.TabStop = true;
            this.lnklblHelpMeChooseAccountStorage.Text = "I have no idea, help me choose";
            this.lnklblHelpMeChooseAccountStorage.UseMnemonic = false;
            this.lnklblHelpMeChooseAccountStorage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnHelpMeChooseAccountStorage);
            // 
            // m_rbStorageLocation_Disk
            // 
            this.m_rbStorageLocation_Disk.AutoSize = true;
            this.m_rbStorageLocation_Disk.Location = new System.Drawing.Point(270, 7);
            this.m_rbStorageLocation_Disk.Name = "m_rbStorageLocation_Disk";
            this.m_rbStorageLocation_Disk.Size = new System.Drawing.Size(132, 17);
            this.m_rbStorageLocation_Disk.TabIndex = 2;
            this.m_rbStorageLocation_Disk.TabStop = true;
            this.m_rbStorageLocation_Disk.Text = "KeePass Configuration";
            this.m_rbStorageLocation_Disk.UseVisualStyleBackColor = true;
            // 
            // m_rbStorageLocation_LocalUserSecureStore
            // 
            this.m_rbStorageLocation_LocalUserSecureStore.AutoSize = true;
            this.m_rbStorageLocation_LocalUserSecureStore.Location = new System.Drawing.Point(100, 7);
            this.m_rbStorageLocation_LocalUserSecureStore.Name = "m_rbStorageLocation_LocalUserSecureStore";
            this.m_rbStorageLocation_LocalUserSecureStore.Size = new System.Drawing.Size(141, 17);
            this.m_rbStorageLocation_LocalUserSecureStore.TabIndex = 1;
            this.m_rbStorageLocation_LocalUserSecureStore.TabStop = true;
            this.m_rbStorageLocation_LocalUserSecureStore.Text = "Local User Secure Store";
            this.m_rbStorageLocation_LocalUserSecureStore.UseVisualStyleBackColor = true;
            // 
            // lblAccountStorageLocation
            // 
            this.lblAccountStorageLocation.AutoSize = true;
            this.lblAccountStorageLocation.Location = new System.Drawing.Point(3, 9);
            this.lblAccountStorageLocation.Name = "lblAccountStorageLocation";
            this.lblAccountStorageLocation.Size = new System.Drawing.Size(91, 13);
            this.lblAccountStorageLocation.TabIndex = 0;
            this.lblAccountStorageLocation.Text = "Storage Location:";
            // 
            // m_tabGeneral
            // 
            this.m_tabGeneral.Controls.Add(this.m_cbOfflineCache);
            this.m_tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.m_tabGeneral.Name = "m_tabGeneral";
            this.m_tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabGeneral.Size = new System.Drawing.Size(590, 261);
            this.m_tabGeneral.TabIndex = 0;
            this.m_tabGeneral.Text = "General";
            this.m_tabGeneral.UseVisualStyleBackColor = true;
            // 
            // m_cbOfflineCache
            // 
            this.m_cbOfflineCache.AutoSize = true;
            this.m_cbOfflineCache.Location = new System.Drawing.Point(7, 7);
            this.m_cbOfflineCache.Name = "m_cbOfflineCache";
            this.m_cbOfflineCache.Size = new System.Drawing.Size(189, 17);
            this.m_cbOfflineCache.TabIndex = 0;
            this.m_cbOfflineCache.Text = "Cache Databases for offline usage";
            this.m_cbOfflineCache.UseVisualStyleBackColor = true;
            // 
            // m_tabAbout
            // 
            this.m_tabAbout.Controls.Add(this.m_lblAboutVersion);
            this.m_tabAbout.Controls.Add(this.m_lblAboutExplanation);
            this.m_tabAbout.Controls.Add(this.m_lblAboutHeader);
            this.m_tabAbout.Location = new System.Drawing.Point(4, 22);
            this.m_tabAbout.Name = "m_tabAbout";
            this.m_tabAbout.Size = new System.Drawing.Size(590, 261);
            this.m_tabAbout.TabIndex = 2;
            this.m_tabAbout.Text = "About";
            this.m_tabAbout.UseVisualStyleBackColor = true;
            // 
            // m_lblAboutVersion
            // 
            this.m_lblAboutVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblAboutVersion.Location = new System.Drawing.Point(12, 35);
            this.m_lblAboutVersion.Name = "m_lblAboutVersion";
            this.m_lblAboutVersion.Size = new System.Drawing.Size(560, 21);
            this.m_lblAboutVersion.TabIndex = 10;
            this.m_lblAboutVersion.Text = "Version";
            this.m_lblAboutVersion.UseMnemonic = false;
            // 
            // m_lblAboutExplanation
            // 
            this.m_lblAboutExplanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutExplanation.Location = new System.Drawing.Point(12, 66);
            this.m_lblAboutExplanation.Name = "m_lblAboutExplanation";
            this.m_lblAboutExplanation.Size = new System.Drawing.Size(560, 122);
            this.m_lblAboutExplanation.TabIndex = 8;
            this.m_lblAboutExplanation.Text = resources.GetString("m_lblAboutExplanation.Text");
            this.m_lblAboutExplanation.UseMnemonic = false;
            // 
            // m_lblAboutHeader
            // 
            this.m_lblAboutHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblAboutHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblAboutHeader.Location = new System.Drawing.Point(11, 12);
            this.m_lblAboutHeader.Name = "m_lblAboutHeader";
            this.m_lblAboutHeader.Size = new System.Drawing.Size(392, 23);
            this.m_lblAboutHeader.TabIndex = 7;
            this.m_lblAboutHeader.Text = "KeeAnywhere";
            this.m_lblAboutHeader.UseMnemonic = false;
            // 
            // m_btnOK
            // 
            this.m_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_btnOK.Location = new System.Drawing.Point(454, 359);
            this.m_btnOK.Name = "m_btnOK";
            this.m_btnOK.Size = new System.Drawing.Size(75, 23);
            this.m_btnOK.TabIndex = 6;
            this.m_btnOK.Text = "OK";
            this.m_btnOK.UseVisualStyleBackColor = true;
            this.m_btnOK.Click += new System.EventHandler(this.OnBtnOkClick);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(535, 359);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 7;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancelClick);
            // 
            // m_mnuHelp
            // 
            this.m_mnuHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mnuHelp_Documentation,
            this.m_mnuHelp_Homepage,
            this.m_mnuHelp_WhatsNew,
            this.m_mnuHelp_License,
            this.m_mnuHelp_Sep1,
            this.m_mnuHelp_ReportBug,
            this.m_mnuHelp_ContactAuthor,
            this.m_mnuHelp_Sep2,
            this.m_mnuHelp_Donate});
            this.m_mnuHelp.Name = "m_mnuHelp";
            this.m_mnuHelp.Size = new System.Drawing.Size(248, 170);
            // 
            // m_mnuHelp_Documentation
            // 
            this.m_mnuHelp_Documentation.Name = "m_mnuHelp_Documentation";
            this.m_mnuHelp_Documentation.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_Documentation.Text = "Documentation";
            this.m_mnuHelp_Documentation.Click += new System.EventHandler(this.OnDocumentation);
            // 
            // m_mnuHelp_Homepage
            // 
            this.m_mnuHelp_Homepage.Name = "m_mnuHelp_Homepage";
            this.m_mnuHelp_Homepage.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_Homepage.Text = "Homepage";
            this.m_mnuHelp_Homepage.Click += new System.EventHandler(this.OnHomepage);
            // 
            // m_mnuHelp_WhatsNew
            // 
            this.m_mnuHelp_WhatsNew.Name = "m_mnuHelp_WhatsNew";
            this.m_mnuHelp_WhatsNew.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_WhatsNew.Text = "What\'s new";
            this.m_mnuHelp_WhatsNew.Click += new System.EventHandler(this.OnWhatsNew);
            // 
            // m_mnuHelp_License
            // 
            this.m_mnuHelp_License.Name = "m_mnuHelp_License";
            this.m_mnuHelp_License.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_License.Text = "License";
            this.m_mnuHelp_License.Click += new System.EventHandler(this.OnLicense);
            // 
            // m_mnuHelp_Sep1
            // 
            this.m_mnuHelp_Sep1.Name = "m_mnuHelp_Sep1";
            this.m_mnuHelp_Sep1.Size = new System.Drawing.Size(244, 6);
            // 
            // m_mnuHelp_ReportBug
            // 
            this.m_mnuHelp_ReportBug.Name = "m_mnuHelp_ReportBug";
            this.m_mnuHelp_ReportBug.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_ReportBug.Text = "Report a bug or request a feature";
            this.m_mnuHelp_ReportBug.Click += new System.EventHandler(this.OnReportBug);
            // 
            // m_mnuHelp_ContactAuthor
            // 
            this.m_mnuHelp_ContactAuthor.Name = "m_mnuHelp_ContactAuthor";
            this.m_mnuHelp_ContactAuthor.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_ContactAuthor.Text = "Contact the Author";
            this.m_mnuHelp_ContactAuthor.Click += new System.EventHandler(this.OnContactAuthor);
            // 
            // m_mnuHelp_Sep2
            // 
            this.m_mnuHelp_Sep2.Name = "m_mnuHelp_Sep2";
            this.m_mnuHelp_Sep2.Size = new System.Drawing.Size(244, 6);
            // 
            // m_mnuHelp_Donate
            // 
            this.m_mnuHelp_Donate.Name = "m_mnuHelp_Donate";
            this.m_mnuHelp_Donate.Size = new System.Drawing.Size(247, 22);
            this.m_mnuHelp_Donate.Text = "Donate";
            this.m_mnuHelp_Donate.Click += new System.EventHandler(this.OnDonate);
            // 
            // m_btnHelp
            // 
            this.m_btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_btnHelp.Location = new System.Drawing.Point(12, 358);
            this.m_btnHelp.Menu = this.m_mnuHelp;
            this.m_btnHelp.Name = "m_btnHelp";
            this.m_btnHelp.Size = new System.Drawing.Size(75, 23);
            this.m_btnHelp.TabIndex = 8;
            this.m_btnHelp.Text = "Help...";
            this.m_btnHelp.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.m_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(622, 397);
            this.Controls.Add(this.m_btnHelp);
            this.Controls.Add(this.m_btnOK);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_tcSettings);
            this.Controls.Add(this.m_bannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeeAnywhere Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
            this.m_tcSettings.ResumeLayout(false);
            this.m_tabAccounts.ResumeLayout(false);
            this.m_tabAccounts.PerformLayout();
            this.m_tabGeneral.ResumeLayout(false);
            this.m_tabGeneral.PerformLayout();
            this.m_tabAbout.ResumeLayout(false);
            this.m_mnuHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_bannerImage;
        private System.Windows.Forms.TabControl m_tcSettings;
        private System.Windows.Forms.TabPage m_tabGeneral;
        private System.Windows.Forms.TabPage m_tabAccounts;
        private System.Windows.Forms.TabPage m_tabAbout;
        private System.Windows.Forms.Button m_btnOK;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.CheckBox m_cbOfflineCache;
        private System.Windows.Forms.Label m_lblAboutExplanation;
        private System.Windows.Forms.Label m_lblAboutHeader;
        private System.Windows.Forms.RadioButton m_rbStorageLocation_Disk;
        private System.Windows.Forms.RadioButton m_rbStorageLocation_LocalUserSecureStore;
        private System.Windows.Forms.Label lblAccountStorageLocation;
        private System.Windows.Forms.LinkLabel lnklblHelpMeChooseAccountStorage;
        private System.Windows.Forms.ListView m_lvAccounts;
        private System.Windows.Forms.Button m_btnAccountRemove;
        private System.Windows.Forms.Label m_lblAboutVersion;
        private System.Windows.Forms.ContextMenuStrip m_mnuAdd;
        private DropDownButton m_btnAccountAdd;
        private System.Windows.Forms.ImageList m_imlProviderIcons;
        private System.Windows.Forms.Button m_btnAccountCheck;
        private DropDownButton m_btnHelp;
        private System.Windows.Forms.ContextMenuStrip m_mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_Documentation;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_Homepage;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_WhatsNew;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_License;
        private System.Windows.Forms.ToolStripSeparator m_mnuHelp_Sep1;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_ReportBug;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_ContactAuthor;
        private System.Windows.Forms.ToolStripSeparator m_mnuHelp_Sep2;
        private System.Windows.Forms.ToolStripMenuItem m_mnuHelp_Donate;
    }
}