using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Threading;

namespace XDS_Subscriber
{
    public partial class frmSubscriptions : Form
    {

        SqlConnection registryConn = null;
        SqlConnection byotronicsConn = null;
        //SqlConnection userConn = null;
        UserDatabase myDatabase = new UserDatabase();
        private BindingSource bindingSourceSubscriptions = new BindingSource();
        bool patientSubscriptionProcess = false;
        string currentUser = "";
        int currentHashValue;
        SubscriptionLog subLog = new SubscriptionLog(@"C:\HSS_XDS");
        public List<string> byotronics = new List<string>();
        Thread oThread = null;
        SqlDataReader byotronicsReader;

        public void DecryptPatientId()
        {
            try
            {
                while (true)
                {
                    
                    Console.WriteLine("DecryptPatientId is running in its own thread.");
                    List<string> byotronics = new List<string>();

                    string patientId = "";

                    using (SqlCommand selectCommand = new SqlCommand())
                    {
                        Console.WriteLine("Point 1");
                        //SqlDataReader byotronicsReader;
                        
                        selectCommand.Connection = byotronicsConn;
                        Console.WriteLine("Point 1.2");
                        selectCommand.CommandText = "select patientId from dbo.MySubscriptions where ByotronicsFlag = 0";
                        Console.WriteLine("Point 1.3");
                        byotronicsReader = selectCommand.ExecuteReader();
                        Console.WriteLine("Point 2");
                        while (byotronicsReader.Read())
                        {
                            Console.WriteLine(byotronicsReader.GetString(0));
                            byotronics.Add(byotronicsReader.GetString(0));
                        }
                        Console.WriteLine("Point 3");
                        byotronicsReader.Close();
                        Console.WriteLine("Point 4");
                    }
                    //byotronicsReader.Close();
                    Console.WriteLine("Patients selected and in list");
                    using (SqlCommand updateCommand = new SqlCommand())
                    {
                        updateCommand.Connection = byotronicsConn;
                        foreach (string patient in byotronics)
                        {
                            patientId = formatPatientId(patient);
                            using (WebClient client = new WebClient())
                            {
                                //the encrypted patiemt id is sent to Mirth
                                //Mirth matches this with the actual CRIS number
                                //Mirth then queries the CRIS database for the latest accession number and site for that patient
                                //Mirth send this in JSON form to Byotronics
                                Console.WriteLine("Encrypted patient id - " + patientId + " sent to Mirth...");
                                byte[] response = client.UploadValues("http://" + Properties.Settings.Default.MirthInstance + ":8099", new NameValueCollection()
                            {
                                { "patientId", patientId }
                                });
                                string result = System.Text.Encoding.UTF8.GetString(response);
                                Console.WriteLine("Decrypted patient - " + result);

                                updateCommand.CommandText = "Update dbo.MySubscriptions set ByotronicsFlag = 1 where patientId = '" + patient + "'";
                                updateCommand.ExecuteNonQuery();
                                Console.WriteLine("Patient " + patient + " - set flag to 1");
                            }
                        }
                    }
                    //Console.WriteLine("Completed decryption of patientIds...");
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                Console.WriteLine(exceptionMsg);
            }
        }

        public frmSubscriptions()
        {
            InitializeComponent();
            
        }

        private void frmSubscriptions_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Thread Start/Stop/Join Sample");

            tbcSubscriptions.Visible = true;
            //this.Text = "Subscriptions - " + myDatabase.CurrentUser;
            OnStartup();
            int subscriptionCount = bindingSourceSubscriptions.Count;
            if (subscriptionCount == 0)
            {
                tbcSubscriptions.SelectedTab = tabLoad;
            }




            /*subLog.WriteLog("Subscription form loaded...");
            //check database exists
            subLog.WriteLog("User database - " + Properties.Settings.Default.UserDb);
            userConn = myDatabase.openConnection(Properties.Settings.Default.UserDb);
            if (userConn != null)
            {
                if(myDatabase.CheckTableExists(userConn, "Users") == false)
                {
                    // log Users table doesn't exist
                    if (myDatabase.CreateUsersTable(userConn) == false)
                    {
                        //log Users table not created
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

                    tbcLogin.Visible = false;
                    tbcSubscriptions.Visible = true;
                    myDatabase.CurrentUser = txtUsername.Text;
                    this.Text = "Subscriptions - " + myDatabase.CurrentUser;
                    OnStartup();


                }
            }
            else
            {
                MessageBox.Show("Not able to conect to Users database");
            }*/
        }

        /*private void cmdLogin_Click(object sender, EventArgs e)
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
            else
            {
                bool verifyLogin = myDatabase.CheckUserLogin(userConn, username, password);
                if (verifyLogin == true)
                {
                    bool passwordChanged = myDatabase.CheckUserPasswordChanged(userConn, username);
                    if (passwordChanged == true)
                    {
                        tbcLogin.Visible = false;
                        tbcSubscriptions.Visible = true;
                        myDatabase.CurrentUser = txtUsername.Text;
                        this.Text = "Subscriptions - " + myDatabase.CurrentUser;
                        OnStartup();
                    }
                    else
                    {
                        txtUsername.Text = username;
                        txtUsername.Enabled = false;
                        txtPassword.Text = "";
                        lblPassword.Text = "PASSWORD:";
                        txtConfirm.Visible = true;
                        txtConfirm.Text = "";
                        lblConfirm.Text = "CONFIRM:";
                        lblConfirm.Visible = true;
                        cmdUpdatePassword.Visible = true;
                        cmdLogin.Visible = false;
                        this.AcceptButton = this.cmdUpdatePassword;
                        txtPassword.Focus();
                    }
                }
                else
                {
                    subLog.WriteLog("User login failed...");
                    MessageBox.Show("User login failed");
                }
            }
        }*/


        /*private void cmdCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string surname = txtPassword.Text;
            string forename = txtConfirm.Text;
            bool userCreated = myDatabase.CreateNewUser(userConn, username, surname, forename);
            if (userCreated == true)
            {
                MessageBox.Show(username + " created");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirm.Text = "";
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Error in setting up user");
                txtUsername.Focus();
            }
        }*/

        /*private void cmdUpdatePassword_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password1 = txtPassword.Text;
            string password2 = txtConfirm.Text;
            if (password1 != password2)
            {
                MessageBox.Show("Please ensure passwords match");
                txtPassword.Focus();
            }
            else if(password1 == "Password1")
            {
                MessageBox.Show("New password must be different");
            }
            else
            {
                if (myDatabase.UpdateUserPassword(userConn, username, password1) == true)
                {
                    cmdUpdatePassword.Visible = false;
                    txtConfirm.Visible = false;
                    lblConfirm.Visible = false;
                    cmdLogin.Visible = true;
                    tbcLogin.Visible = false;
                    tbcSubscriptions.Visible = true;
                    myDatabase.CurrentUser = txtUsername.Text;
                    this.Text = "Subscriptions - " + myDatabase.CurrentUser;
                    OnStartup();
                }
                else
                {
                    MessageBox.Show("A problem occurred...");
                }
            }
        }*/

        public void LoadSettings()
        {
            txtDbServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUser.Text = Properties.Settings.Default.User;
            txtDbPassword.Text = Properties.Settings.Default.Password;
            txtMirth.Text = Properties.Settings.Default.MirthInstance;
            txtSubscribePort.Text = Properties.Settings.Default.SubscribePort.ToString();
            txtUnsubscribePort.Text = Properties.Settings.Default.UnsubscribePort.ToString();
            txtLength.Text = Properties.Settings.Default.TermLength.ToString();
            txtPatViewer.Text = Properties.Settings.Default.FishcakeServer;
            txtPatViewerPort.Text = Properties.Settings.Default.FishcakePort.ToString();
            currentHashValue = CalculateHash();
            cmdSaveSettings.Text = "EXIT";
        }

        private void OnStartup()
        {
            try
            {
                subLog.WriteLog("Running OnStartup routine...");
                subLog.WriteLog("Registry database - " + Properties.Settings.Default.Database);
                registryConn = myDatabase.openConnection(Properties.Settings.Default.Database);
                byotronicsConn = myDatabase.openConnection(Properties.Settings.Default.Database);

                

                string types = Properties.Settings.Default.CancerTypes;
                string[] cancerTypes = types.Split('/');
                foreach (string type in cancerTypes)
                {
                    cmbType.Items.Add(type);
                }
                cmbType.Text = cancerTypes[0];
                txtEndpoint.Text = "localhost:8092";
                lblTerm.Text = "Months to termination: " + Properties.Settings.Default.TermLength.ToString();
                lblTermDateTime.Text = "Termination Date: " + DateTime.Now.AddMonths(Properties.Settings.Default.TermLength).ToString("dddd, MMMM d, yyyy HH:mm:ss");
                tlpSubscriptions.SetToolTip(txtEndpoint, "Specify the notification endpoint...");
                tlpSubscriptions.SetToolTip(cmdPatients, "Load patients from csv or txt files...");
                tlpSubscriptions.SetToolTip(lblTerm, "Change the subscription term in settings...");
                SetupSubscriptionsControl();
                LoadSubscriptions();

                oThread = new Thread(new ThreadStart(DecryptPatientId));
                oThread.Name = "Byotronics";
                oThread.IsBackground = true;
                oThread.Start();

                subLog.WriteLog("Startup routine completed...");
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("OnStartup exception - " + exceptionMsg);
            }
        }

        private void SetupSubscriptionsControl()
        {
            dgvSubscriptions.AutoGenerateColumns = true;
            dgvSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadSubscriptions()
        {
            try
            {
                subLog.WriteLog("Loading subscriptions...");
                bindingSourceSubscriptions.DataSource = GetData("Select ByotronicsFlag as [B], patientId as PatientId, SubscriptionDate as [Start Date], TerminationTime as [End Date], CancerType as [Subscription Type], ConsumerReferenceAddress as [Notify To] From dbo.MySubscriptions", registryConn);
                dgvSubscriptions.DataSource = bindingSourceSubscriptions;
                int subscriptionCount = bindingSourceSubscriptions.Count;
                grpSubscriptions.Text = "Subscriptions (" + subscriptionCount + ")";

                dgvSubscriptions.Columns[0].ReadOnly = true;
                dgvSubscriptions.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                int dataGridViewHeight = (subscriptionCount + 1) * 22;
                if (dataGridViewHeight < 440)
                {
                    dgvSubscriptions.Height = dataGridViewHeight;
                }
                else
                {
                    dgvSubscriptions.Height = 440;
                }

                //dgvSubscriptions.Height = subscriptionCount * 22;

                /*DataGridViewCheckBoxColumn byotronicsColumn = new DataGridViewCheckBoxColumn();
                byotronicsColumn.Name = "B";
                byotronicsColumn.HeaderText = "B";
                byotronicsColumn.Width = 50;
                byotronicsColumn.ReadOnly = true;
                dgvSubscriptions.Columns.Add(byotronicsColumn);*/

                //dgvSubscriptions.Update();
                //dgvSubscriptions.Refresh();
                subLog.WriteLog("Subscriptions loaded...");
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("LoadSubscriptions exception - " + exceptionMsg);
            }
        }

        private DataTable GetData(string queryString, SqlConnection conn)
        {
            try
            {
                subLog.WriteLog("Getting data...");
                subLog.WriteLog("queryString - " + queryString);
                SqlCommand command = new SqlCommand(queryString, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                subLog.WriteLog("Returning data...");
                return table;
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("GetData exception - " + exceptionMsg);
                return null;
            }
        }

        private void cmdPatients_Click(object sender, EventArgs e)
        {
            try
            {
                subLog.WriteLog("cmdPatients_Click...");
                label2.Text = "";
                lstPatients.Items.Clear();
                subLog.WriteLog("Patients list cleared...");
                prbLoad.Value = 0;
                UploadPatients();
                patientSubscriptionProcess = false;
                lstPatients.ListViewItemSorter = new ListViewItemCheckboxComparer();
                lstPatients.Sort();
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("cmdPatients_Click exception - " + exceptionMsg);
            }
        }

        private void UploadPatients()
        {
            try
            {
                subLog.WriteLog("Uploading patients...");
                DialogResult result = dlgLoadPatients.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = dlgLoadPatients.FileName;
                    subLog.WriteLog("Loading patients from file - " + filename);
                    string extension = Path.GetExtension(filename);
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        if(extension == ".csv")
                        {
                            String alllines = sr.ReadToEnd();
                            string[] lines = alllines.Split(',');
                            foreach(string line in lines)
                            {
                                lstPatients.Items.Add(line);
                                subLog.WriteLog("Patient added to list - " + line);
                            }
                        }
                        else if (extension == ".txt")
                        {
                            string lines = "";
                            while ((lines = sr.ReadLine()) != null)
                            {
                                lstPatients.Items.Add(lines);
                                subLog.WriteLog("Patient added to list - " + lines);
                            }
                        }
                    }
                    //checks whether or not listed patients already have subscriptions
                    subLog.WriteLog("Checking if patients already subscribed...");
                    bool checkedSub = false;
                    foreach(ListViewItem patientItem in lstPatients.Items)
                    {
                        bool subExists = checkSubscriptions(patientItem.Text);
                        if (subExists == true)
                        {
                            patientItem.Checked = true;
                            checkedSub = true;
                        }
                    }
                    if(checkedSub == true)
                    {
                        label2.Text = "Subscriptions already exist for checked patients...";
                    }
                }
                subLog.WriteLog("Patients loaded into list...");
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("UploadPatients exception - " + exceptionMsg);
                MessageBox.Show(ex.Message);
            }
        }

        public bool PatientSubscribe(string patientSub, string terminateDateTime, string recipient, string cancerType)
        {
            try
            {
                subLog.WriteLog("Subscription request for " + patientSub);
                string mirthInstance = Properties.Settings.Default.MirthInstance;
                string patientSubscribePort = Properties.Settings.Default.SubscribePort.ToString();
                subLog.WriteLog("Sending to " + mirthInstance + ":" + patientSubscribePort);
                using (WebClient client = new WebClient())
                {
                    byte[] response = client.UploadValues("http://" + mirthInstance + ":" + patientSubscribePort, new NameValueCollection()
                {
                    { "patientId", patientSub },
                    { "terminateTime", terminateDateTime},
                    { "recipient", recipient},
                    { "cancerType", cancerType}
                });

                    string result = System.Text.Encoding.UTF8.GetString(response);
                    if (result == "Success")
                    {
                        subLog.WriteLog("Subscription request successful...");
                        return true;
                    }
                    else if (result == "Error")
                    {
                        subLog.WriteLog("Subscription request unsuccessful...");
                        return false;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("PatientSubscribe exception - " + exceptionMsg);
                return false;
            }
        }

        private string getTermTime()
        {
            try
            {
                DateTime subTime = DateTime.Parse(lblTermDateTime.Text.Substring(18));
                DateTime currentTime = DateTime.Now;

                if (subTime < currentTime)
                {
                    return "";
                }
                else
                {
                    string year = subTime.Year.ToString();
                    string month = subTime.Month.ToString();
                    if (month.Length == 1)
                    {
                        month = month.PadLeft(2, '0');
                    }
                    string day = subTime.Day.ToString();
                    if (day.Length == 1)
                    {
                        day = day.PadLeft(2, '0');
                    }
                    string hour = subTime.Hour.ToString();
                    if (hour.Length == 1)
                    {
                        hour = hour.PadLeft(2, '0');
                    }
                    string minute = subTime.Minute.ToString();
                    if (minute.Length == 1)
                    {
                        minute = minute.PadLeft(2, '0');
                    }
                    string second = subTime.Second.ToString();
                    if (second.Length == 1)
                    {
                        second = minute.PadLeft(2, '0');
                    }
                    string milliSeconds = subTime.Millisecond.ToString();
                    //2015-04-07T09:32:02.7176149+01:00
                    string termTime = year + "-" + month + "-" + day + "T" + hour + ":" + minute + ":" + second + "." + milliSeconds + "+01:00";
                    return termTime;
                }
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("getTermTime exception - " + exceptionMsg);
                return "";
            }
        }

        private void cmdSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                subLog.WriteLog("cmdSubscribe_Click...");
                //for each patient in list...
                Cursor.Current = Cursors.WaitCursor;
                label2.Text = "";
                string notifyEndpoint = this.txtEndpoint.Text;
                if (notifyEndpoint == "")
                {
                    subLog.WriteLog("No notification endpoint supplied...");
                    MessageBox.Show("Endpoint required...");
                    txtEndpoint.Focus();
                }
                else
                {
                    subLog.WriteLog("No of patients to be subscribed - " + lstPatients.Items.Count);
                    if (lstPatients.Items.Count > 0)
                    {
                        prbLoad.Maximum = lstPatients.Items.Count;
                        for (int i = 0; i < lstPatients.Items.Count; i++)
                        {
                            //only carries this out for unchecked, ie where patients don't already have subscriptions
                            if (lstPatients.Items[i].Checked == false)
                            {
                                string patientId = lstPatients.Items[i].Text;
                                string termTime = getTermTime();
                                string cancerType = cmbType.Text;
                                bool patientSubscribed = PatientSubscribe(patientId, termTime, notifyEndpoint, cancerType);
                                if (patientSubscribed == true)
                                {
                                    byotronics.Add(patientId); //add to list for later processing and sending to Byotronics
                                    lstPatients.Items[i].Checked = true;
                                    prbLoad.PerformStep();
                                }
                            }
                            else
                            {
                                prbLoad.PerformStep();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Load patients...");
                    }
                }
                patientSubscriptionProcess = true;
                //ByotronicsTimer.Start();
                Cursor.Current = Cursors.Default;
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("cmdSubscribe_Click exception - " + exceptionMsg);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if(registryConn != null)
            {
                subLog.WriteLog("Closing Registry db connection...");
                registryConn.Close();
            }
            if (byotronicsConn != null)
            {
                subLog.WriteLog("Closing Byotronics db connection...");
                byotronicsConn.Close();
            }
            oThread.Abort();
            /*if(userConn != null)
            {
                subLog.WriteLog("Closing Users db connection...");
                userConn.Close();
            }*/
            subLog.WriteLog("Closing Subscription form...");
            frmLogin loginForm = new frmLogin();
            loginForm.Close();
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //go to login tab
            if (keyData == (Keys.Control | Keys.L))
            {
                try
                {
                    this.Hide();
                    frmLogin loginForm = new frmLogin();
                    loginForm.Show();
                    
                    
                    
                    /*subLog.WriteLog("Login tab opened...");
                    tbcSubscriptions.Visible = false;
                    tbcSettings.Visible = false;
                    tbcLogin.Visible = true;
                    txtUsername.Enabled = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtPassword.PasswordChar = '*';
                    txtConfirm.PasswordChar = '*';
                    txtConfirm.Visible = false;
                    lblPassword.Text = "PASSWORD:";
                    lblConfirm.Text = "";
                    label5.Text = "";
                    cmdCreate.Visible = false;
                    cmdLogin.Visible = true;
                    this.AcceptButton = this.cmdLogin;
                    myDatabase.CurrentUser = "";
                    txtUsername.Focus();*/
                }
                catch(Exception ex)
                {
                    string exceptionMsg = ex.Message;
                    subLog.WriteLog("Login tab shortcut exception - " + exceptionMsg);
                }
            }
            // create new user
            /*else if((keyData == (Keys.Control | Keys.N)) && myDatabase.CurrentUser == "admin") //only allow for Admin user
            {

                try
                {
                    subLog.WriteLog("New User tab opened...");
                    tbcSubscriptions.Visible = false;
                    tbcSettings.Visible = false;
                    tbcLogin.Visible = true;
                    lblPassword.Text = "SURNAME:";
                    lblConfirm.Text = "FORENAME:";
                    txtUsername.Text = "";
                    txtUsername.Enabled = true;
                    txtPassword.Text = "";
                    txtPassword.PasswordChar = '\0';
                    txtConfirm.PasswordChar = '\0';
                    txtConfirm.Text = "";
                    txtConfirm.Visible = true;
                    cmdLogin.Visible = false;
                    cmdUpdatePassword.Visible = false;
                    cmdCreate.Visible = true;
                    this.AcceptButton = this.cmdCreate;
                    lblConfirm.Visible = true;
                    label5.Text = "";
                }
                catch(Exception ex)
                {
                    string exceptionMsg = ex.Message;
                    subLog.WriteLog("New User tab shortcut exception - " + exceptionMsg);
                }
            }*/
            // view/change settings
            /*else if ((keyData == (Keys.Control | Keys.S)) && tbcLogin.Visible == true && txtUsername.Text == "support" && txtPassword.Text == "support")
            {
                try
                {
                    subLog.WriteLog("Settings tab opened...");
                    tbcLogin.Visible = false;
                    tbcSettings.Visible = true;
                    txtDbServer.Text = Properties.Settings.Default.Server;
                    txtDatabase.Text = Properties.Settings.Default.Database;
                    txtUser.Text = Properties.Settings.Default.User;
                    txtDbPassword.Text = Properties.Settings.Default.Password;
                    txtMirth.Text = Properties.Settings.Default.MirthInstance;
                    txtSubscribePort.Text = Properties.Settings.Default.SubscribePort.ToString();
                    txtUnsubscribePort.Text = Properties.Settings.Default.UnsubscribePort.ToString();
                    txtLength.Text = Properties.Settings.Default.TermLength.ToString();
                    currentHashValue = CalculateHash();
                    cmdSaveSettings.Enabled = false;
                    label5.Text = "";
                }
                catch(Exception ex)
                {
                    string exceptionMsg = ex.Message;
                    subLog.WriteLog("Settings tab shortcut exception - " + exceptionMsg);
                }
            }*/
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private int CalculateHash()
        {
            string[] txtStrings = new string[] { txtDbServer.Text, txtDatabase.Text, txtUser.Text, txtDbPassword.Text, txtMirth.Text, txtSubscribePort.Text, txtUnsubscribePort.Text, txtLength.Text, txtPatViewer.Text, txtPatViewerPort.Text };
            string hashString = String.Concat(txtStrings);
            int hash = hashString.GetHashCode();
            return hash;
        }

        //check whether or not the subscription for stated patient already exists
        private bool checkSubscriptions(string patientId)
        {
            try
            {
                subLog.WriteLog("Checking " + patientId + " for existing subscription...");
                string dbPatientId = "";
                bool subExists = false;
                subLog.WriteLog("Point 1.1");
                using (SqlCommand myCommand = new SqlCommand())
                {
                    subLog.WriteLog("Point 2.1");
                    SqlDataReader myReader;
                    myCommand.Connection = registryConn;
                    subLog.WriteLog("Point 3.1");
                    myCommand.CommandText = "select patientId from dbo.MySubscriptions";
                    myReader = myCommand.ExecuteReader();
                    subLog.WriteLog("Point 4.1");
                    while (myReader.Read())
                    {
                        subLog.WriteLog("Point 5.1");
                        dbPatientId = myReader.GetString(0);
                        subLog.WriteLog("Point 6.1");
                        int posPatientId = dbPatientId.IndexOf(patientId);
                        if (posPatientId > -1)
                        {
                            subExists = true;
                            break;
                        }
                    }
                    subLog.WriteLog("Point 7.1");
                    myReader.Close();
                    subLog.WriteLog("Point 8.1");
                }
                
                
                
                //SqlCommand myCommand;
                //string sqlSelect = "select patientId from dbo.MySubscriptions";
                //SqlDataReader dataReader;
                //myCommand = new SqlCommand(sqlSelect, registryConn);
                
                //dataReader = myCommand.ExecuteReader();
                /*while (dataReader.Read())
                {
                    subLog.WriteLog("Point 3");
                    dbPatientId = dataReader.GetString(0);
                    subLog.WriteLog("Point 4");
                    int posPatientId = dbPatientId.IndexOf(patientId);
                    if (posPatientId > -1)
                    {
                        subExists = true;
                        break;
                    }
                }
                subLog.WriteLog("Point 5");
                dataReader.Close();
                subLog.WriteLog("Point 6");*/
                if (subExists == true)
                {
                    subLog.WriteLog("Subscription exists...");
                    return true;
                }
                else
                {
                    subLog.WriteLog("Subscription does not exist...");
                    return false;
                }
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("checkSubscriptions exception - " + exceptionMsg);
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool IsValidPort(string port)
        {
            string pattern = @"^[0-9][0-9][0-9][0-9]$";
            bool valid = false;
            Regex check = new Regex(pattern);
            if (port == "")
            {
                //no address provided so return false
                valid = false;
            }
            else
            {
                //address provided so use the IsMatch Method
                //of the Regular Expression object
                valid = check.IsMatch(port, 0);
            }
            return valid;
        }

        private void txtEndpoint_Leave(object sender, EventArgs e)
        {
            try
            {
                string endpoint = txtEndpoint.Text;
                string[] endpointSplit = endpoint.Split(':');
                string ipAddress = endpointSplit[0];
                string port = endpointSplit[1];
                bool ipAddressCheck = true;

                if (ipAddress != "localhost")
                {
                    IPAddress clientIpAddr;
                    ipAddressCheck = IPAddress.TryParse(ipAddress, out clientIpAddr);

                    if (ipAddressCheck == false)
                    {
                        MessageBox.Show("IP Address entered is not a valid IP Address...");
                    }
                }
                bool portCheck = IsValidPort(port);
                if (portCheck == false)
                {
                    MessageBox.Show("Port entered is not a port...");
                }
                if (ipAddressCheck == true && portCheck == true)
                {
                    testNotifyEndpoint(ipAddress, port);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ip Address and/or Port is invalid");
            }
        }

        private void testNotifyEndpoint(string host, string port)
        {
            bool testNotifyEndpoint = testConnection(host, int.Parse(port));
            if (testNotifyEndpoint == true)
            {
                MessageBox.Show("Connectivity established to " + txtEndpoint.Text);
            }
            else
            {
                MessageBox.Show("Failed to connect to " + txtEndpoint.Text);
            }
        }

        private string formatPatientId(string fullPatientId)
        {
            string patientId = fullPatientId;
            int posPatEnd = fullPatientId.IndexOf("^^^&");
            if (fullPatientId.Substring(0, 4) == "CRIS")
            {
                return fullPatientId.Substring(4, posPatEnd - 4);
            }
            else
            {
                return "";
            }
        }

        private void dgvSubscriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    e.Value = formatPatientId((string)e.Value);
                }

                int DataGridViewWidth = 0;
                foreach (DataGridViewColumn column in dgvSubscriptions.Columns)
                {
                    DataGridViewWidth = DataGridViewWidth + column.Width;

                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    /*if(column.Index == 0)
                    {
                        column.ReadOnly = true;
                    }*/
                }
                dgvSubscriptions.Width = DataGridViewWidth + 20;
                grpSubscriptions.Width = dgvSubscriptions.Width + 15;
                tbcSubscriptions.Width = grpSubscriptions.Width + 27;
                this.Width = tbcSubscriptions.Width + 18;
                /*foreach (DataGridViewColumn col in dgvSubscriptions.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }*/
            }
            catch(Exception ex)
            {
                //don't do anything...
            }
        }

        private void tbcSubscriptions_DoubleClick(object sender, EventArgs e)
        {
            LoadSubscriptions();
            dgvSubscriptions.Update();
            dgvSubscriptions.Refresh();
            if (dgvSubscriptions.RowCount == 0)
            {
                dgvSubscriptions.Width = 410;
            }
        }

        private void tabShow_Enter(object sender, EventArgs e)
        {
            /*LoadSubscriptions();
            if (dgvSubscriptions.RowCount == 0)
            {
                dgvSubscriptions.Width = 410;
            }*/
        }

        private void tabLoad_Enter(object sender, EventArgs e)
        {
            label5.Text = "";
            if (patientSubscriptionProcess == true)
            {
                lstPatients.Items.Clear();
                prbLoad.Value = 0;
            }
        }

        private void dgvSubscriptions_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if(e.ColumnIndex == 1 && dgvSubscriptions.RowCount > 0)
            {
                string input = "Patient Id";
                string patientId = "";
                string result = ShowInputDialog(ref input);
                //unselect any existing row selections
                dgvSubscriptions.ClearSelection();
                int rowCounter = -1;
                bool patientFound = false;
                foreach(DataGridViewRow row in dgvSubscriptions.Rows)
                {
                    patientId = formatPatientId(row.Cells[0].Value.ToString());
                    rowCounter++;
                    if (patientId.Equals(result))
                    {
                        row.Selected = true;
                        //dgvSubscriptions.FirstDisplayedScrollingRowIndex = dgvSubscriptions.SelectedRows[rowCounter].Index;
                        dgvSubscriptions.CurrentCell = dgvSubscriptions.Rows[rowCounter].Cells[0];
                        patientFound = true;
                        break;
                    }
                }

                if (patientFound == false)
                {
                    grpSubscriptions.Text = "Patient " + result + " not found...";
                }
            }
        }

        private void dgvSubscriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                string patientId = dgvSubscriptions[e.ColumnIndex, e.RowIndex].Value.ToString();
                patientId = formatPatientId(patientId);
                MessageBox.Show(patientId);
                //string fishcakeConnString = Properties.Settings.Default.FishcakeServer + ":" + Properties.Settings.Default.FishcakePort + "/patient/" + patientId;
                string fishcakeConnString = Properties.Settings.Default.FishcakeServer + ":" + Properties.Settings.Default.FishcakePort + "/patient/21399";
                System.Diagnostics.Process.Start(fishcakeConnString);

                //System.Diagnostics.Process.Start("http://ukrc_cris:8777/patient/21399");
                //System.Diagnostics.Process.Start("http://ukrc_cris:8777/patient/21240");
            }
        }

        private string ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 60);
            Form searchBox = new Form();

            searchBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            searchBox.ClientSize = size;
            searchBox.Text = "Search for patient";
            searchBox.MaximizeBox = false;
            searchBox.MinimizeBox = false;
            searchBox.ControlBox = false;
            searchBox.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            searchBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(85, 23);
            okButton.Text = "&OK";
            //okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            okButton.Location = new System.Drawing.Point(5, 30);
            searchBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(85, 23);
            cancelButton.Text = "&Cancel";
            //cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            cancelButton.Location = new System.Drawing.Point(size.Width - 90, 30);
            searchBox.Controls.Add(cancelButton);

            searchBox.AcceptButton = okButton;
            searchBox.CancelButton = cancelButton;

            DialogResult result = searchBox.ShowDialog();
            input = textBox.Text;
            return input;
        }

        private bool testConnection(string host, int port)
        {
            subLog.WriteLog("Testing connection - " + host + ":" + port);
            string textToSend = DateTime.Now.ToString();
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(host, port);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
                subLog.WriteLog("Successfully connected...");
                return true;
            }
            catch (Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("testConnection exception - " + exceptionMsg);
                client.Close();
                return false;
            }
        }

        private class ListViewItemCheckboxComparer : IComparer<ListViewItem>, System.Collections.IComparer
        {
            public int Compare(ListViewItem x, ListViewItem y)
            {
                // return the negative of the compare to put 1 (true) at the top;  
                return -(x.Checked ? 1 : 0).CompareTo(y.Checked ? 1 : 0);
            }

            public int Compare(object x, object y)
            {
                return Compare(x as ListViewItem, y as ListViewItem);
            }
        }

        /*private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(myDatabase.CurrentUser == "")
            {
                cmdLogin.Focus();
            }
        }*/

        private void txtSubscribePort_TextChanged(object sender, EventArgs e)
        {
            string portString = txtSubscribePort.Text;
            if (portString.Length > 4)
            {
                txtSubscribePort.Text = portString.Substring(0, 4);
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

        private void HashChanged()
        {
            int currentHash = CalculateHash();
            if (currentHash != currentHashValue)
            {
                currentHashValue = CalculateHash();
                //cmdSaveSettings.Enabled = true;
                cmdSaveSettings.Text = "SAVE /& EXIT";
                subLog.WriteLog("Settings have changed...");
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

        private void txtDbPassword_Leave(object sender, EventArgs e)
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

        private void cmdSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                subLog.WriteLog("Saving settings...");
                Properties.Settings.Default.Server = txtDbServer.Text;
                Properties.Settings.Default.Database = txtDatabase.Text;
                Properties.Settings.Default.User = txtUser.Text;
                Properties.Settings.Default.Password = txtDbPassword.Text;
                Properties.Settings.Default.MirthInstance = txtMirth.Text;
                Properties.Settings.Default.SubscribePort = int.Parse(txtSubscribePort.Text);
                Properties.Settings.Default.UnsubscribePort = int.Parse(txtUnsubscribePort.Text);
                Properties.Settings.Default.TermLength = int.Parse(txtLength.Text);
                Properties.Settings.Default.FishcakeServer = txtPatViewer.Text;
                Properties.Settings.Default.FishcakePort = int.Parse(txtPatViewerPort.Text);
                Properties.Settings.Default.HashCode = CalculateHash();
                Properties.Settings.Default.Save();
                //cmdSave.Enabled = false;
                tbcSettings.Visible = false;

                this.Hide();
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

                //txtUsername.Text = "";
                //txtPassword.Text = "";
                //tbcLogin.Visible = true;
            }
            catch(Exception ex)
            {
                string exceptionMsg = ex.Message;
                subLog.WriteLog("cmdSaveSettings_Click exception - " + exceptionMsg);
            }
        }

        private void txtPatViewer_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtPatViewerPort_Leave(object sender, EventArgs e)
        {
            HashChanged();
        }

        private void txtPatViewerPort_TextChanged(object sender, EventArgs e)
        {
            string portString = txtPatViewerPort.Text;
            if (portString.Length > 4)
            {
                txtPatViewerPort.Text = portString.Substring(0, 4);
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
    }
}
