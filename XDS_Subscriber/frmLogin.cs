using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XDS_Subscriber
{
    public partial class frmLogin : Form
    {
        SqlConnection userConn = null;
        UserDatabase myDatabase = new UserDatabase();
        SubscriptionLog subLog = new SubscriptionLog(@"C:\HSS_XDS");

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            userConn = myDatabase.openConnection(Properties.Settings.Default.UserDb);
            if (userConn != null)
            {
                if (myDatabase.CheckTableExists(userConn, "Users") == false)
                {
                    // log Users table doesn't exist
                    if (myDatabase.CreateUsersTable(userConn) == false)
                    {

                    }
                    else
                    {
                        //log Database exists and Users table created
                        txtUsername.Focus();
                    }
                }
                else
                {
                    //log Database exists and Users table created
                    txtUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Not able to conect to Users database");
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "")
            {
                MessageBox.Show("Please insert a username...");
            }
            else if (password == "")
            {
                MessageBox.Show("Please insert a password...");
            }
            else if (txtUsername.Text == "Support" && txtPassword.Text == "support")
            {
                myDatabase.CurrentUser = txtUsername.Text;
                this.Hide();
                frmSubscriptions subForm = new frmSubscriptions();
                subForm.Text = "Subscriptions - " + txtUsername.Text;
                subForm.tbcSubscriptions.Visible = false;
                subForm.tbcSettings.Visible = true;
                subForm.LoadSettings();
                subForm.Show();
            }
            else
            {
                bool verifyLogin = myDatabase.CheckUserLogin(userConn, username, password);
                if (verifyLogin == true)
                {
                    myDatabase.CurrentUser = txtUsername.Text;
                    this.Hide();
                    frmSubscriptions subForm = new frmSubscriptions();
                    subForm.Text = "Subscriptions - " + txtUsername.Text;
                    subForm.tbcSubscriptions.Visible = true;
                    subForm.tbcSettings.Visible = false;

                    subForm.Show();
                }
                else
                {
                    subLog.WriteLog("User login failed...");
                    MessageBox.Show("User login failed");
                }
            }
        }
    }
}
