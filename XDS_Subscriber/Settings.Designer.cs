namespace XDS_Subscriber
{
    partial class frmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubscribePort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMirth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnsubscribePort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Server:";
            // 
            // txtDbServer
            // 
            this.txtDbServer.Location = new System.Drawing.Point(108, 25);
            this.txtDbServer.Name = "txtDbServer";
            this.txtDbServer.Size = new System.Drawing.Size(145, 20);
            this.txtDbServer.TabIndex = 1;
            this.txtDbServer.Leave += new System.EventHandler(this.txtDbServer_Leave);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(108, 51);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(145, 20);
            this.txtDatabase.TabIndex = 3;
            this.txtDatabase.Leave += new System.EventHandler(this.txtDatabase_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(108, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(145, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subscribe Port:";
            // 
            // txtMirth
            // 
            this.txtMirth.Location = new System.Drawing.Point(112, 25);
            this.txtMirth.Name = "txtMirth";
            this.txtMirth.Size = new System.Drawing.Size(141, 20);
            this.txtMirth.TabIndex = 9;
            this.txtMirth.Leave += new System.EventHandler(this.txtMirth_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mirth Server:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unsubscribe Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDbServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscriptions Database";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(198, 337);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMirth);
            this.groupBox2.Controls.Add(this.txtUnsubscribePort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSubscribePort);
            this.groupBox2.Location = new System.Drawing.Point(6, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 114);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mirth Connect";
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Enabled = false;
            this.cmdSaveSettings.Location = new System.Drawing.Point(85, 337);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(104, 23);
            this.cmdSaveSettings.TabIndex = 17;
            this.cmdSaveSettings.Text = "Save Settings";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLength);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(6, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 60);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Terminnation";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subscription length:";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 560);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdSaveSettings);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubscribePort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnsubscribePort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSaveSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label8;
    }
}