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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdClose = new System.Windows.Forms.Button();
            this.grpPatients = new System.Windows.Forms.GroupBox();
            this.prbLoad = new System.Windows.Forms.ProgressBar();
            this.lstPatients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dlgLoadPatients = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblTermDateTime = new System.Windows.Forms.Label();
            this.txtEndpoint = new System.Windows.Forms.TextBox();
            this.cmdPatients = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSubscribe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSubscriptions = new System.Windows.Forms.DataGridView();
            this.grpSubscriptions = new System.Windows.Forms.GroupBox();
            this.tbcSubscriptions = new System.Windows.Forms.TabControl();
            this.tabShow = new System.Windows.Forms.TabPage();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.tlpSubscriptions = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPatViewerPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatViewer = new System.Windows.Forms.TextBox();
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMirth = new System.Windows.Forms.TextBox();
            this.txtUnsubscribePort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSubscribePort = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.grpPatients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).BeginInit();
            this.grpSubscriptions.SuspendLayout();
            this.tbcSubscriptions.SuspendLayout();
            this.tabShow.SuspendLayout();
            this.tabLoad.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(492, 529);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(136, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "&CLOSE";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 300);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvSubscriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubscriptions.Location = new System.Drawing.Point(8, 19);
            this.dgvSubscriptions.MultiSelect = false;
            this.dgvSubscriptions.Name = "dgvSubscriptions";
            this.dgvSubscriptions.RowHeadersVisible = false;
            this.dgvSubscriptions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscriptions.Size = new System.Drawing.Size(143, 305);
            this.dgvSubscriptions.TabIndex = 25;
            this.dgvSubscriptions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubscriptions_CellContentDoubleClick);
            this.dgvSubscriptions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubscriptions_CellFormatting);
            this.dgvSubscriptions.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubscriptions_ColumnHeaderMouseDoubleClick);
            // 
            // grpSubscriptions
            // 
            this.grpSubscriptions.Controls.Add(this.dgvSubscriptions);
            this.grpSubscriptions.Location = new System.Drawing.Point(8, 6);
            this.grpSubscriptions.Name = "grpSubscriptions";
            this.grpSubscriptions.Size = new System.Drawing.Size(596, 470);
            this.grpSubscriptions.TabIndex = 1;
            this.grpSubscriptions.TabStop = false;
            this.grpSubscriptions.Text = "Subscriptions";
            // 
            // tbcSubscriptions
            // 
            this.tbcSubscriptions.Controls.Add(this.tabShow);
            this.tbcSubscriptions.Controls.Add(this.tabLoad);
            this.tbcSubscriptions.Location = new System.Drawing.Point(0, 0);
            this.tbcSubscriptions.Name = "tbcSubscriptions";
            this.tbcSubscriptions.SelectedIndex = 0;
            this.tbcSubscriptions.Size = new System.Drawing.Size(628, 523);
            this.tbcSubscriptions.TabIndex = 1;
            this.tbcSubscriptions.DoubleClick += new System.EventHandler(this.tbcSubscriptions_DoubleClick);
            // 
            // tabShow
            // 
            this.tabShow.Controls.Add(this.grpSubscriptions);
            this.tabShow.Location = new System.Drawing.Point(4, 22);
            this.tabShow.Name = "tabShow";
            this.tabShow.Padding = new System.Windows.Forms.Padding(3);
            this.tabShow.Size = new System.Drawing.Size(620, 497);
            this.tabShow.TabIndex = 1;
            this.tabShow.Text = "Show Subscriptions";
            this.tabShow.UseVisualStyleBackColor = true;
            this.tabShow.Enter += new System.EventHandler(this.tabShow_Enter);
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
            this.tabLoad.Size = new System.Drawing.Size(620, 497);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Load Subscriptions";
            this.tabLoad.UseVisualStyleBackColor = true;
            this.tabLoad.Enter += new System.EventHandler(this.tabLoad_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 28;
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabSettings);
            this.tbcSettings.Location = new System.Drawing.Point(0, 0);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(628, 523);
            this.tbcSettings.TabIndex = 30;
            this.tbcSettings.Visible = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox6);
            this.tabSettings.Controls.Add(this.cmdSaveSettings);
            this.tabSettings.Controls.Add(this.groupBox5);
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(620, 497);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPatViewerPort);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtPatViewer);
            this.groupBox6.Location = new System.Drawing.Point(281, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(267, 114);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Patient Viewer";
            // 
            // txtPatViewerPort
            // 
            this.txtPatViewerPort.Location = new System.Drawing.Point(72, 54);
            this.txtPatViewerPort.Name = "txtPatViewerPort";
            this.txtPatViewerPort.Size = new System.Drawing.Size(57, 20);
            this.txtPatViewerPort.TabIndex = 15;
            this.txtPatViewerPort.TextChanged += new System.EventHandler(this.txtPatViewerPort_TextChanged);
            this.txtPatViewerPort.Leave += new System.EventHandler(this.txtPatViewerPort_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Server:";
            // 
            // txtPatViewer
            // 
            this.txtPatViewer.Location = new System.Drawing.Point(72, 25);
            this.txtPatViewer.Name = "txtPatViewer";
            this.txtPatViewer.Size = new System.Drawing.Size(145, 20);
            this.txtPatViewer.TabIndex = 3;
            this.txtPatViewer.Leave += new System.EventHandler(this.txtPatViewer_Leave);
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveSettings.Location = new System.Drawing.Point(412, 278);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(136, 23);
            this.cmdSaveSettings.TabIndex = 20;
            this.cmdSaveSettings.Text = "EXIT";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtLength);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(281, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(267, 60);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Termination";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(112, 25);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(57, 20);
            this.txtLength.TabIndex = 15;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Subscription length:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMirth);
            this.groupBox4.Controls.Add(this.txtUnsubscribePort);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSubscribePort);
            this.groupBox4.Location = new System.Drawing.Point(8, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 114);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mirth Connect";
            // 
            // txtMirth
            // 
            this.txtMirth.Location = new System.Drawing.Point(112, 25);
            this.txtMirth.Name = "txtMirth";
            this.txtMirth.Size = new System.Drawing.Size(141, 20);
            this.txtMirth.TabIndex = 9;
            this.txtMirth.Leave += new System.EventHandler(this.txtMirth_Leave);
            // 
            // txtUnsubscribePort
            // 
            this.txtUnsubscribePort.Location = new System.Drawing.Point(112, 77);
            this.txtUnsubscribePort.Name = "txtUnsubscribePort";
            this.txtUnsubscribePort.Size = new System.Drawing.Size(57, 20);
            this.txtUnsubscribePort.TabIndex = 13;
            this.txtUnsubscribePort.TextChanged += new System.EventHandler(this.txtUnsubscribePort_TextChanged);
            this.txtUnsubscribePort.Leave += new System.EventHandler(this.txtUnsubscribePort_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Server:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Subscribe Port:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Unsubscribe Port:";
            // 
            // txtSubscribePort
            // 
            this.txtSubscribePort.Location = new System.Drawing.Point(112, 51);
            this.txtSubscribePort.Name = "txtSubscribePort";
            this.txtSubscribePort.Size = new System.Drawing.Size(57, 20);
            this.txtSubscribePort.TabIndex = 11;
            this.txtSubscribePort.TextChanged += new System.EventHandler(this.txtSubscribePort_TextChanged);
            this.txtSubscribePort.Leave += new System.EventHandler(this.txtSubscribePort_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDbServer);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtDatabase);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtUser);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDbPassword);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 136);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subscriptions Database";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Server:";
            // 
            // txtDbServer
            // 
            this.txtDbServer.Location = new System.Drawing.Point(108, 25);
            this.txtDbServer.Name = "txtDbServer";
            this.txtDbServer.Size = new System.Drawing.Size(145, 20);
            this.txtDbServer.TabIndex = 1;
            this.txtDbServer.Leave += new System.EventHandler(this.txtDbServer_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Database:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(108, 51);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(145, 20);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.Leave += new System.EventHandler(this.txtDatabase_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(108, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Password:";
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(108, 103);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.PasswordChar = '*';
            this.txtDbPassword.Size = new System.Drawing.Size(145, 20);
            this.txtDbPassword.TabIndex = 7;
            this.txtDbPassword.Leave += new System.EventHandler(this.txtDbPassword_Leave);
            // 
            // frmSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(625, 556);
            this.Controls.Add(this.tbcSettings);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptions)).EndInit();
            this.grpSubscriptions.ResumeLayout(false);
            this.tbcSubscriptions.ResumeLayout(false);
            this.tabShow.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.tbcSettings.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabShow;
        private System.Windows.Forms.Label lblTermDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tlpSubscriptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMirth;
        private System.Windows.Forms.TextBox txtUnsubscribePort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSubscribePort;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cmdSaveSettings;
        public System.Windows.Forms.TabControl tbcSettings;
        public System.Windows.Forms.TabControl tbcSubscriptions;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPatViewerPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatViewer;
    }
}

