using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDS_Subscriber
{
    public partial class frmSettings : Form
    {
        bool settingsChanged = false;
        int currentHashValue;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if(cmdSaveSettings.Enabled == true)
            {
                MessageBox.Show("Save settings before exiting!");
            }
            else
            {
                this.Close();
            }
        }

        private int CalcuateHash()
        {
            string[] txtStrings = new string[] {txtDbServer.Text, txtDatabase.Text, txtUser.Text, txtPassword.Text, txtMirth.Text, txtSubscribePort.Text, txtUnsubscribePort.Text, txtLength.Text};
            string hashString = String.Concat(txtStrings);
            int hash = hashString.GetHashCode();
            return hash;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {    
            txtDbServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.Password;
            txtMirth.Text = Properties.Settings.Default.MirthInstance;
            txtSubscribePort.Text = Properties.Settings.Default.SubscribePort.ToString();
            txtUnsubscribePort.Text = Properties.Settings.Default.UnsubscribePort.ToString();
            txtLength.Text = Properties.Settings.Default.TermLength.ToString();
            currentHashValue = CalcuateHash();
            
            this.Location = this.Owner.Location;
            this.Left += this.Owner.ClientSize.Width / 2 - this.Width / 2;
            this.Top += this.Owner.ClientSize.Height / 2 - this.Height / 2;
            cmdSaveSettings.Enabled = false;
        }

        private void txtSubscribePort_TextChanged(object sender, EventArgs e)
        {
            string portString = txtSubscribePort.Text;
            if (portString.Length > 4)
            {
                txtSubscribePort.Text = portString.Substring(0, 4);
                MessageBox.Show("Port number cannot be more than 4 digits");
            }

            for (int i = 0; i < portString.Length; i++ )
            {
                if(!char.IsNumber(portString[i]))
                {
                    MessageBox.Show("Please insert a valid number");
                }
            }
        }

        private void txtUnsubscribePort_TextChanged(object sender, EventArgs e)
        {
            string portString = txtUnsubscribePort.Text;
            if (portString.Length > 4)
            {
                txtUnsubscribePort.Text = portString.Substring(0, 4);
                MessageBox.Show("Port number cannot be more than 4 digits");
            }

            for (int i = 0; i < portString.Length; i++)
            {
                if (!char.IsNumber(portString[i]))
                {
                    MessageBox.Show("Please insert a valid number");
                }
            }
        }

        private void cmdSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtDbServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.MirthInstance = txtMirth.Text;
            Properties.Settings.Default.SubscribePort = int.Parse(txtSubscribePort.Text);
            Properties.Settings.Default.UnsubscribePort = int.Parse(txtUnsubscribePort.Text);
            Properties.Settings.Default.TermLength = int.Parse(txtLength.Text);
            Properties.Settings.Default.HashCode = CalcuateHash();
            Properties.Settings.Default.Save();
            cmdSaveSettings.Enabled = false;
        }

        private void HashChanged()
        {
            int currentHash = CalcuateHash();
            if (currentHash != currentHashValue)
            {
                currentHashValue = CalcuateHash();
                cmdSaveSettings.Enabled = true;
            }
        }

        private void txtSubscribePort_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtUnsubscribePort_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtDbServer_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtDatabase_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtMirth_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            string lengthString = txtLength.Text;

            for (int i = 0; i < lengthString.Length; i++)
            {
                if (!char.IsNumber(lengthString[i]))
                {
                    MessageBox.Show("Please insert a valid number");
                }
            }
        }

        private void txtLength_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }
    }
}
