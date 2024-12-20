﻿namespace DRB_Icon_Appender
{
    partial class FormMain
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
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.ToolTip toolTip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddIcon = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBatchAddIcons = new System.Windows.Forms.Button();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.dgvIcons = new System.Windows.Forms.DataGridView();
            this.dgvIconsIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIconsTextureCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvIconsTopLeftCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIconsTopEdgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIconsWidthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIconsHeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlendMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdExecutable = new System.Windows.Forms.OpenFileDialog();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.nudIconID = new System.Windows.Forms.NumericUpDown();
            this.lblIconID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            lblGameDir = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(12, 9);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(80, 13);
            lblGameDir.TabIndex = 0;
            lblGameDir.Text = "Game Directory";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 51);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            toolTip1.SetToolTip(this.btnBrowse, "Browse for your Dark Souls installation");
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(174, 51);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 4;
            this.btnExplore.Text = "Explore";
            toolTip1.SetToolTip(this.btnExplore, "Open the game directory in Explorer");
            this.btnExplore.UseVisualStyleBackColor = true;
            this.btnExplore.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(255, 51);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "Restore";
            toolTip1.SetToolTip(this.btnRestore, "Restore backed-up files and reload");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(557, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            toolTip1.SetToolTip(this.btnSave, "Save changes");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddIcon
            // 
            this.btnAddIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIcon.Enabled = false;
            this.btnAddIcon.Location = new System.Drawing.Point(557, 550);
            this.btnAddIcon.Name = "btnAddIcon";
            this.btnAddIcon.Size = new System.Drawing.Size(75, 23);
            this.btnAddIcon.TabIndex = 13;
            this.btnAddIcon.Text = "Add Icon";
            toolTip1.SetToolTip(this.btnAddIcon, "Create a new icon with the given ID");
            this.btnAddIcon.UseVisualStyleBackColor = true;
            this.btnAddIcon.Click += new System.EventHandler(this.btnAddIcon_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(638, 51);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            toolTip1.SetToolTip(this.btnClose, "Close files without saving");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(93, 51);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            toolTip1.SetToolTip(this.btnOpen, "Load files from the game directory");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnBatchAddIcons
            // 
            this.btnBatchAddIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchAddIcons.Enabled = false;
            this.btnBatchAddIcons.Location = new System.Drawing.Point(638, 550);
            this.btnBatchAddIcons.Name = "btnBatchAddIcons";
            this.btnBatchAddIcons.Size = new System.Drawing.Size(75, 23);
            this.btnBatchAddIcons.TabIndex = 14;
            this.btnBatchAddIcons.Text = "Batch Add";
            toolTip1.SetToolTip(this.btnBatchAddIcons, "Create a new icon with the given ID");
            this.btnBatchAddIcons.UseVisualStyleBackColor = true;
            this.btnBatchAddIcons.Click += new System.EventHandler(this.btnBatchAddIcons_Click);
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(12, 25);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.ReadOnly = true;
            this.txtGameDir.Size = new System.Drawing.Size(701, 20);
            this.txtGameDir.TabIndex = 1;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED";
            // 
            // dgvIcons
            // 
            this.dgvIcons.AllowUserToAddRows = false;
            this.dgvIcons.AllowUserToDeleteRows = false;
            this.dgvIcons.AllowUserToResizeColumns = false;
            this.dgvIcons.AllowUserToResizeRows = false;
            this.dgvIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIcons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIconsIDCol,
            this.dgvIconsTextureCol,
            this.dgvIconsTopLeftCol,
            this.dgvIconsTopEdgeCol,
            this.dgvIconsWidthCol,
            this.dgvIconsHeightCol,
            this.BlendMode});
            this.dgvIcons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvIcons.Location = new System.Drawing.Point(12, 80);
            this.dgvIcons.Name = "dgvIcons";
            this.dgvIcons.RowHeadersVisible = false;
            this.dgvIcons.Size = new System.Drawing.Size(701, 454);
            this.dgvIcons.TabIndex = 8;
            this.dgvIcons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIcons_CellContentClick);
            this.dgvIcons.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvIcons_DataError);
            // 
            // dgvIconsIDCol
            // 
            this.dgvIconsIDCol.DataPropertyName = "ID";
            this.dgvIconsIDCol.HeaderText = "ID";
            this.dgvIconsIDCol.Name = "dgvIconsIDCol";
            this.dgvIconsIDCol.ReadOnly = true;
            // 
            // dgvIconsTextureCol
            // 
            this.dgvIconsTextureCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvIconsTextureCol.DataPropertyName = "Texture";
            this.dgvIconsTextureCol.HeaderText = "Texture";
            this.dgvIconsTextureCol.Name = "dgvIconsTextureCol";
            // 
            // dgvIconsTopLeftCol
            // 
            this.dgvIconsTopLeftCol.DataPropertyName = "LeftEdge";
            this.dgvIconsTopLeftCol.HeaderText = "Left Edge";
            this.dgvIconsTopLeftCol.Name = "dgvIconsTopLeftCol";
            // 
            // dgvIconsTopEdgeCol
            // 
            this.dgvIconsTopEdgeCol.DataPropertyName = "TopEdge";
            this.dgvIconsTopEdgeCol.HeaderText = "Top Edge";
            this.dgvIconsTopEdgeCol.Name = "dgvIconsTopEdgeCol";
            // 
            // dgvIconsWidthCol
            // 
            this.dgvIconsWidthCol.DataPropertyName = "Width";
            this.dgvIconsWidthCol.HeaderText = "Width";
            this.dgvIconsWidthCol.Name = "dgvIconsWidthCol";
            // 
            // dgvIconsHeightCol
            // 
            this.dgvIconsHeightCol.DataPropertyName = "Height";
            this.dgvIconsHeightCol.HeaderText = "Height";
            this.dgvIconsHeightCol.Name = "dgvIconsHeightCol";
            // 
            // BlendMode
            // 
            this.BlendMode.DataPropertyName = "BlendingMode";
            this.BlendMode.HeaderText = "Blending Mode";
            this.BlendMode.Name = "BlendMode";
            // 
            // ofdExecutable
            // 
            this.ofdExecutable.Filter = "DS Executable or DeS EBOOT|*.exe;*.bin";
            this.ofdExecutable.Title = "Select executable or EBOOT...";
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(12, 555);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llbUpdate.Size = new System.Drawing.Size(114, 13);
            this.llbUpdate.TabIndex = 9;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(12, 555);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblUpdate.TabIndex = 20;
            this.lblUpdate.Text = "Checking for update...";
            // 
            // nudIconID
            // 
            this.nudIconID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIconID.Location = new System.Drawing.Point(431, 553);
            this.nudIconID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudIconID.Name = "nudIconID";
            this.nudIconID.Size = new System.Drawing.Size(120, 20);
            this.nudIconID.TabIndex = 12;
            // 
            // lblIconID
            // 
            this.lblIconID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconID.AutoSize = true;
            this.lblIconID.Location = new System.Drawing.Point(428, 537);
            this.lblIconID.Name = "lblIconID";
            this.lblIconID.Size = new System.Drawing.Size(42, 13);
            this.lblIconID.TabIndex = 11;
            this.lblIconID.Text = "Icon ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Original by TKGP\r\nRebuild by Greatgramcracker";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 585);
            this.Controls.Add(this.btnBatchAddIcons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIconID);
            this.Controls.Add(this.nudIconID);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddIcon);
            this.Controls.Add(this.dgvIcons);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(682, 213);
            this.Name = "FormMain";
            this.Text = "DRB Icon Appender <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIconID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvIcons;
        private System.Windows.Forms.OpenFileDialog ofdExecutable;
        private System.Windows.Forms.Button btnAddIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.NumericUpDown nudIconID;
        private System.Windows.Forms.Label lblIconID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIconsIDCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvIconsTextureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIconsTopLeftCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIconsTopEdgeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIconsWidthCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIconsHeightCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlendMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatchAddIcons;
    }
}

