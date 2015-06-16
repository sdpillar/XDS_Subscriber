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
            this.cmdByatronics = new System.Windows.Forms.Button();
            this.cmdFishcake = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.tbcSubscriptions = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.tabShow = new System.Windows.Forms.TabPage();
            this.tlpSubscriptions = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbcLogin = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdUpdatePassword = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcSettings = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
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
            this.tabLoad.SuspendLayout();
            this.tabShow.SuspendLayout();
            this.tbcLogin.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tbcSettings.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(504, 293);
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
            this.tbcSubscriptions.Size = new System.Drawing.Size(640, 290);
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
            this.tabLoad.Size = new System.Drawing.Size(632, 264);
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
            this.tabShow.Size = new System.Drawing.Size(632, 264);
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
            // tbcLogin
            // 
            this.tbcLogin.Controls.Add(this.tabLogin);
            this.tbcLogin.Location = new System.Drawing.Point(0, 0);
            this.tbcLogin.Name = "tbcLogin";
            this.tbcLogin.SelectedIndex = 0;
            this.tbcLogin.Size = new System.Drawing.Size(640, 290);
            this.tbcLogin.TabIndex = 29;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabLogin.Controls.Add(this.cmdCreate);
            this.tabLogin.Controls.Add(this.cmdUpdatePassword);
            this.tabLogin.Controls.Add(this.lblConfirm);
            this.tabLogin.Controls.Add(this.txtConfirm);
            this.tabLogin.Controls.Add(this.cmdLogin);
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.label11);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Controls.Add(this.panel2);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(632, 264);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Log In";
            // 
            // cmdCreate
            // 
            this.cmdCreate.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmdCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCreate.Location = new System.Drawing.Point(516, 37);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(75, 58);
            this.cmdCreate.TabIndex = 14;
            this.cmdCreate.Text = "CREATE";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Visible = false;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdUpdatePassword
            // 
            this.cmdUpdatePassword.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmdUpdatePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdUpdatePassword.Location = new System.Drawing.Point(516, 37);
            this.cmdUpdatePassword.Name = "cmdUpdatePassword";
            this.cmdUpdatePassword.Size = new System.Drawing.Size(75, 58);
            this.cmdUpdatePassword.TabIndex = 13;
            this.cmdUpdatePassword.Text = "UPDATE";
            this.cmdUpdatePassword.UseVisualStyleBackColor = true;
            this.cmdUpdatePassword.Visible = false;
            this.cmdUpdatePassword.Click += new System.EventHandler(this.cmdUpdatePassword_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(239, 110);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(59, 13);
            this.lblConfirm.TabIndex = 12;
            this.lblConfirm.Text = "CONFIRM:";
            this.lblConfirm.Visible = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Location = new System.Drawing.Point(329, 110);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(176, 20);
            this.txtConfirm.TabIndex = 11;
            this.txtConfirm.Visible = false;
            // 
            // cmdLogin
            // 
            this.cmdLogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmdLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLogin.Location = new System.Drawing.Point(516, 37);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 58);
            this.cmdLogin.TabIndex = 8;
            this.cmdLogin.Text = "LOGIN";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(239, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "USER NAME:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(329, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(329, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 266);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(44, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "LOGIN";
            // 
            // tbcSettings
            // 
            this.tbcSettings.Controls.Add(this.tabSettings);
            this.tbcSettings.Location = new System.Drawing.Point(0, 0);
            this.tbcSettings.Name = "tbcSettings";
            this.tbcSettings.SelectedIndex = 0;
            this.tbcSettings.Size = new System.Drawing.Size(204, 294);
            this.tbcSettings.TabIndex = 30;
            this.tbcSettings.Visible = false;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.cmdSaveSettings);
            this.tabSettings.Controls.Add(this.groupBox5);
            this.tabSettings.Controls.Add(this.groupBox4);
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(196, 268);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveSettings.Location = new System.Drawing.Point(412, 83);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(136, 23);
            this.cmdSaveSettings.TabIndex = 20;
            this.cmdSaveSettings.Text = "SAVE";
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
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mirth Server:";
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
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Database Server:";
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
            this.AcceptButton = this.cmdLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(642, 317);
            this.Controls.Add(this.tbcSettings);
            this.Controls.Add(this.tbcLogin);
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
            this.tabLoad.ResumeLayout(false);
            this.tabLoad.PerformLayout();
            this.tabShow.ResumeLayout(false);
            this.tbcLogin.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbcSettings.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tbcLogin;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button cmdUpdatePassword;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.TabControl tbcSettings;
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
    }
}

