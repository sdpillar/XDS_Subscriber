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
            this.lstPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSubResponse = new System.Windows.Forms.Label();
            this.dlgLoadPatients = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.cmdPatients = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTermDateTime = new System.Windows.Forms.TextBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cmdSubscribe = new System.Windows.Forms.Button();
            this.ttpSubscription = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubscriptions = new System.Windows.Forms.DataGridView();
            this.grpSubscriptions = new System.Windows.Forms.GroupBox();
            this.grpPatients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).BeginInit();
            this.grpSubscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(468, 381);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(136, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "CLOSE";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // grpPatients
            // 
            this.grpPatients.Controls.Add(this.lstPatients);
            this.grpPatients.Controls.Add(this.lblSubResponse);
            this.grpPatients.Location = new System.Drawing.Point(10, 12);
            this.grpPatients.Name = "grpPatients";
            this.grpPatients.Size = new System.Drawing.Size(237, 145);
            this.grpPatients.TabIndex = 10;
            this.grpPatients.TabStop = false;
            this.grpPatients.Text = "Patients";
            // 
            // lstPatients
            // 
            this.lstPatients.CheckBoxes = true;
            this.lstPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstPatients.Location = new System.Drawing.Point(8, 19);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(221, 114);
            this.lstPatients.TabIndex = 23;
            this.lstPatients.UseCompatibleStateImageBehavior = false;
            this.lstPatients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PatientId";
            this.columnHeader1.Width = 200;
            // 
            // lblSubResponse
            // 
            this.lblSubResponse.AutoSize = true;
            this.lblSubResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubResponse.Location = new System.Drawing.Point(936, 76);
            this.lblSubResponse.Name = "lblSubResponse";
            this.lblSubResponse.Size = new System.Drawing.Size(0, 13);
            this.lblSubResponse.TabIndex = 11;
            // 
            // dlgLoadPatients
            // 
            this.dlgLoadPatients.Filter = "csv files (*.csv)|*.csv|Text files (*.txt)|*.txt";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndpoint);
            this.groupBox1.Controls.Add(this.cmdPatients);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudMonths);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTermDateTime);
            this.groupBox1.Controls.Add(this.lblTerm);
            this.groupBox1.Controls.Add(this.cmdSubscribe);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
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
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(246, 93);
            this.nudMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(83, 20);
            this.nudMonths.TabIndex = 24;
            this.nudMonths.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonths.Visible = false;
            this.nudMonths.ValueChanged += new System.EventHandler(this.nudMonths_ValueChanged);
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
            // txtTermDateTime
            // 
            this.txtTermDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtTermDateTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTermDateTime.Location = new System.Drawing.Point(8, 120);
            this.txtTermDateTime.Name = "txtTermDateTime";
            this.txtTermDateTime.Size = new System.Drawing.Size(296, 13);
            this.txtTermDateTime.TabIndex = 25;
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(5, 93);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(111, 13);
            this.lblTerm.TabIndex = 23;
            this.lblTerm.Text = "Months to termination:";
            this.lblTerm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdSubscribe
            // 
            this.cmdSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubscribe.Location = new System.Drawing.Point(210, 56);
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
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 24;
            // 
            // dgvSubscriptions
            // 
            this.dgvSubscriptions.AllowUserToAddRows = false;
            this.dgvSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscriptions.Location = new System.Drawing.Point(8, 19);
            this.dgvSubscriptions.Name = "dgvSubscriptions";
            this.dgvSubscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscriptions.Size = new System.Drawing.Size(167, 187);
            this.dgvSubscriptions.TabIndex = 25;
            this.dgvSubscriptions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubscriptions_CellFormatting);
            // 
            // grpSubscriptions
            // 
            this.grpSubscriptions.Controls.Add(this.dgvSubscriptions);
            this.grpSubscriptions.Location = new System.Drawing.Point(10, 163);
            this.grpSubscriptions.Name = "grpSubscriptions";
            this.grpSubscriptions.Size = new System.Drawing.Size(594, 212);
            this.grpSubscriptions.TabIndex = 26;
            this.grpSubscriptions.TabStop = false;
            this.grpSubscriptions.Text = "Subscriptions";
            // 
            // frmSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 409);
            this.Controls.Add(this.grpSubscriptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPatients);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSubscriptions";
            this.Text = "Subscriptions";
            this.Load += new System.EventHandler(this.frmSubscriptions_Load);
            this.grpPatients.ResumeLayout(false);
            this.grpPatients.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).EndInit();
            this.grpSubscriptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox grpPatients;
        private System.Windows.Forms.Label lblSubResponse;
        private System.Windows.Forms.OpenFileDialog dlgLoadPatients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPatients;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTermDateTime;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button cmdSubscribe;
        private System.Windows.Forms.ToolTip ttpSubscription;
        private System.Windows.Forms.ListView lstPatients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txtEndpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSubscriptions;
        private System.Windows.Forms.GroupBox grpSubscriptions;
    }
}

