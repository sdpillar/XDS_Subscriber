namespace XDS_Subscriber
{
    partial class frmSubscriptions
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.grpPatients = new System.Windows.Forms.GroupBox();
            this.prbLoad = new System.Windows.Forms.ProgressBar();
            this.lstPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dlgLoadPatients = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTermDateTime = new System.Windows.Forms.Label();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.cmdPatients = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cmdSubscribe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubscriptions = new System.Windows.Forms.DataGridView();
            this.grpSubscriptions = new System.Windows.Forms.GroupBox();
            this.cmdByatronics = new System.Windows.Forms.Button();
            this.cmdFishcake = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.tbcSubscriptions = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.tabShow = new System.Windows.Forms.TabPage();
            this.tlpSubscriptions = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpPatients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).BeginInit();
            this.grpSubscriptions.SuspendLayout();
            this.tbcSubscriptions.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.tabShow.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(502, 302);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(136, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // grpPatients
            // 
            this.grpPatients.Controls.Add(this.prbLoad);
            this.grpPatients.Controls.Add(this.lstPatients);
            this.grpPatients.Location = new System.Drawing.Point(8, 9);
            this.grpPatients.Name = "grpPatients";
            this.grpPatients.Size = new System.Drawing.Size(237, 254);
            this.grpPatients.TabIndex = 10;
            this.grpPatients.TabStop = false;
            this.grpPatients.Text = "Patients";
            // 
            // prbLoad
            // 
            this.prbLoad.Location = new System.Drawing.Point(8, 227);
            this.prbLoad.Name = "prbLoad";
            this.prbLoad.Size = new System.Drawing.Size(221, 21);
            this.prbLoad.Step = 1;
            this.prbLoad.TabIndex = 27;
            // 
            // lstPatients
            // 
            this.lstPatients.CheckBoxes = true;
            this.lstPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPatients.Location = new System.Drawing.Point(8, 19);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(221, 202);
            this.lstPatients.TabIndex = 23;
            this.lstPatients.UseCompatibleStateImageBehavior = false;
            this.lstPatients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PatientId";
            this.columnHeader1.Width = 200;
            // 
            // dlgLoadPatients
            // 
            this.dlgLoadPatients.Filter = "csv files (*.csv)|*.csv|Text files (*.txt)|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtEndpoint);
            this.groupBox1.Controls.Add(this.cmdPatients);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmdSubscribe);
            this.groupBox1.Location = new System.Drawing.Point(251, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 158);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // lblTermDateTime
            // 
            this.lblTermDateTime.AutoSize = true;
            this.lblTermDateTime.Location = new System.Drawing.Point(6, 43);
            this.lblTermDateTime.Name = "lblTermDateTime";
            this.lblTermDateTime.Size = new System.Drawing.Size(91, 13);
            this.lblTermDateTime.TabIndex = 32;
            this.lblTermDateTime.Text = "Termination Date:";
            this.lblTermDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEndpoint
            // 
            this.txtEndpoint.Location = new System.Drawing.Point(80, 54);
            this.txtEndpoint.Name = "txtEndpoint";
            this.txtEndpoint.Size = new System.Drawing.Size(124, 20);
            this.txtEndpoint.TabIndex = 31;
            this.txtEndpoint.Leave += new System.EventHandler(this.txtEndpoint_Leave);
            // 
            // cmdPatients
            // 
            this.cmdPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPatients.Location = new System.Drawing.Point(210, 20);
            this.cmdPatients.Name = "cmdPatients";
            this.cmdPatients.Size = new System.Drawing.Size(119, 23);
            this.cmdPatients.TabIndex = 30;
            this.cmdPatients.Text = "Load Patients";
            this.cmdPatients.UseVisualStyleBackColor = true;
            this.cmdPatients.Click += new System.EventHandler(this.cmdPatients_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(78, 20);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(126, 21);
            this.cmbType.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Endpoint:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cancer Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(6, 16);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(111, 13);
            this.lblTerm.TabIndex = 23;
            this.lblTerm.Text = "Months to termination:";
            this.lblTerm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdSubscribe
            // 
            this.cmdSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubscribe.Location = new System.Drawing.Point(210, 54);
            this.cmdSubscribe.Name = "cmdSubscribe";
            this.cmdSubscribe.Size = new System.Drawing.Size(119, 23);
            this.cmdSubscribe.TabIndex = 22;
            this.cmdSubscribe.Text = "Subscribe";
            this.cmdSubscribe.UseVisualStyleBackColor = true;
            this.cmdSubscribe.Click += new System.EventHandler(this.cmdSubscribe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // dgvSubscriptions
            // 
            this.dgvSubscriptions.AllowUserToAddRows = false;
            this.dgvSubscriptions.AllowUserToDeleteRows = false;
            this.dgvSubscriptions.AllowUserToResizeColumns = false;
            this.dgvSubscriptions.AllowUserToResizeRows = false;
            this.dgvSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscriptions.Location = new System.Drawing.Point(8, 19);
            this.dgvSubscriptions.MultiSelect = false;
            this.dgvSubscriptions.Name = "dgvSubscriptions";
            this.dgvSubscriptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscriptions.Size = new System.Drawing.Size(167, 200);
            this.dgvSubscriptions.TabIndex = 25;
            this.dgvSubscriptions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubscriptions_CellFormatting);
            this.dgvSubscriptions.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubscriptions_ColumnHeaderMouseDoubleClick);
            // 
            // grpSubscriptions
            // 
            this.grpSubscriptions.Controls.Add(this.cmdByatronics);
            this.grpSubscriptions.Controls.Add(this.cmdFishcake);
            this.grpSubscriptions.Controls.Add(this.cmdUpdate);
            this.grpSubscriptions.Controls.Add(this.dgvSubscriptions);
            this.grpSubscriptions.Location = new System.Drawing.Point(8, 6);
            this.grpSubscriptions.Name = "grpSubscriptions";
            this.grpSubscriptions.Size = new System.Drawing.Size(616, 257);
            this.grpSubscriptions.TabIndex = 26;
            this.grpSubscriptions.TabStop = false;
            this.grpSubscriptions.Text = "Subscriptions";
            // 
            // cmdByatronics
            // 
            this.cmdByatronics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdByatronics.Location = new System.Drawing.Point(311, 228);
            this.cmdByatronics.Name = "cmdByatronics";
            this.cmdByatronics.Size = new System.Drawing.Size(136, 23);
            this.cmdByatronics.TabIndex = 29;
            this.cmdByatronics.Text = "Byotronics";
            this.cmdByatronics.UseVisualStyleBackColor = true;
            // 
            // cmdFishcake
            // 
            this.cmdFishcake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFishcake.Location = new System.Drawing.Point(157, 228);
            this.cmdFishcake.Name = "cmdFishcake";
            this.cmdFishcake.Size = new System.Drawing.Size(136, 23);
            this.cmdFishcake.TabIndex = 28;
            this.cmdFishcake.Text = "Fishcake";
            this.cmdFishcake.UseVisualStyleBackColor = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(6, 228);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(136, 23);
            this.cmdUpdate.TabIndex = 27;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // tbcSubscriptions
            // 
            this.tbcSubscriptions.Controls.Add(this.tabLoad);
            this.tbcSubscriptions.Controls.Add(this.tabShow);
            this.tbcSubscriptions.Location = new System.Drawing.Point(0, 0);
            this.tbcSubscriptions.Name = "tbcSubscriptions";
            this.tbcSubscriptions.SelectedIndex = 0;
            this.tbcSubscriptions.Size = new System.Drawing.Size(642, 295);
            this.tbcSubscriptions.TabIndex = 27;
            // 
            // tabLoad
            // 
            this.tabLoad.BackColor = System.Drawing.Color.Transparent;
            this.tabLoad.Controls.Add(this.label1);
            this.tabLoad.Controls.Add(this.groupBox1);
            this.tabLoad.Controls.Add(this.grpPatients);
            this.tabLoad.Location = new System.Drawing.Point(4, 22);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoad.Size = new System.Drawing.Size(634, 269);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Load Subscriptions";
            this.tabLoad.UseVisualStyleBackColor = true;
            this.tabLoad.Enter += new System.EventHandler(this.tabLoad_Enter);
            // 
            // tabShow
            // 
            this.tabShow.Controls.Add(this.grpSubscriptions);
            this.tabShow.Location = new System.Drawing.Point(4, 22);
            this.tabShow.Name = "tabShow";
            this.tabShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabShow.Size = new System.Drawing.Size(634, 269);
            this.tabShow.TabIndex = 1;
            this.tabShow.Text = "Show Subscriptions";
            this.tabShow.UseVisualStyleBackColor = true;
            this.tabShow.Enter += new System.EventHandler(this.tabShow_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTerm);
            this.groupBox2.Controls.Add(this.lblTermDateTime);
            this.groupBox2.Location = new System.Drawing.Point(10, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 65);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // frmSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 328);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbcSubscriptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSubscriptions";
            this.Text = "Subscriptions";
            this.Load += new System.EventHandler(this.frmSubscriptions_Load);
            this.grpPatients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).EndInit();
            this.grpSubscriptions.ResumeLayout(false);
            this.tbcSubscriptions.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.tabShow.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox grpPatients;
        private System.Windows.Forms.OpenFileDialog dlgLoadPatients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPatients;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button cmdSubscribe;
        private System.Windows.Forms.ListView lstPatients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSubscriptions;
        private System.Windows.Forms.GroupBox grpSubscriptions;
        private System.Windows.Forms.ProgressBar prbLoad;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdByatronics;
        private System.Windows.Forms.Button cmdFishcake;
        private System.Windows.Forms.TabControl tbcSubscriptions;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabShow;
        private System.Windows.Forms.Label lblTermDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tlpSubscriptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

