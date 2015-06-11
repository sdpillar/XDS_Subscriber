using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace XDS_Subscriber
{   
    public partial class frmSubscriptions : Form
    {
        SqlConnection cnn = null;
        private BindingSource bindingSourceSubscriptions = new BindingSource();
        bool patientSubscriptionProcess = false;

        public frmSubscriptions()
        {
            InitializeComponent();
        }

        private void frmSubscriptions_Load(object sender, EventArgs e)
        {
            OnStartup();
            lblTerm.Text = "Months to termination: " + Properties.Settings.Default.TermLength.ToString();
            lblTermDateTime.Text = "Termination Date: " + DateTime.Now.AddMonths(Properties.Settings.Default.TermLength).ToString("dddd, MMMM d, yyyy HH:mm:ss");
            tlpSubscriptions.SetToolTip(txtEndpoint, "Specify the notification endpoint...");
            tlpSubscriptions.SetToolTip(cmdPatients, "Load patients from csv or txt files...");
            tlpSubscriptions.SetToolTip(lblTerm, "Change the subscription term in settings...");
        }

        private void OnStartup()
        {
            openConnection();
            string types = Properties.Settings.Default.CancerTypes;
            string [] cancerTypes = types.Split('/');
            foreach(string type in cancerTypes)
            {
                cmbType.Items.Add(type);
            }
            cmbType.Text = cancerTypes[0];
            txtEndpoint.Text = "localhost:8092";
            SetupSubscriptionsControl();
            LoadSubscriptions();
        }

        private void openConnection()
        {
            try
            {
                string server = Properties.Settings.Default.Server;
                string database = Properties.Settings.Default.Database;
                string user = Properties.Settings.Default.User;
                string password = Properties.Settings.Default.Password;
                string connectionString = "Server=" + server + ";Database=" + database + ";User Id=" + user + ";Password=" + password;
                cnn = new SqlConnection(connectionString);
                cnn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to retrieve existing subscriptions\nCheck database settings", "Error");
            }
        }

        private void SetupSubscriptionsControl()
        {
            dgvSubscriptions.AutoGenerateColumns = true;
            dgvSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LoadSubscriptions()
        {
            bindingSourceSubscriptions.DataSource = GetData("Select patientId as PatientId, SubscriptionDate as [Start Date], TerminationTime as [End Date], CancerType as [Cancer Type], ConsumerReferenceAddress as [Notify To] From dbo.MySubscriptions", cnn);
            dgvSubscriptions.DataSource = bindingSourceSubscriptions;
            int subscriptionCount = bindingSourceSubscriptions.Count;
            grpSubscriptions.Text = "Subscriptions (" + subscriptionCount + ")";

            dgvSubscriptions.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvSubscriptions.Update();
            dgvSubscriptions.Refresh();
        }

        private DataTable GetData(string sqlCommand, SqlConnection conn)
        {
            SqlCommand command = new SqlCommand(sqlCommand, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void cmdPatients_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            lstPatients.Items.Clear();
            prbLoad.Value = 0;
            UploadPatients();
            patientSubscriptionProcess = false;
            lstPatients.ListViewItemSorter = new ListViewItemCheckboxComparer();
            lstPatients.Sort();
        }

        private void UploadPatients()
        {
            try
            {
                DialogResult result = dlgLoadPatients.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = dlgLoadPatients.FileName;
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
                            }
                        }
                        else if (extension == ".txt")
                        {
                            string lines = "";
                            while ((lines = sr.ReadLine()) != null)
                            {
                                lstPatients.Items.Add(lines);
                            }
                        }
                    }
                    //checks whether or not listed patients already have subscriptions
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool PatientSubscribe(string patientSub, string terminateDateTime, string recipient, string cancerType)
        {
            using (WebClient client = new WebClient())
            {
                string mirthInstance = Properties.Settings.Default.MirthInstance;
                string patientSubscribePort = Properties.Settings.Default.SubscribePort.ToString();
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
                    return true;
                }
                else if (result == "Error")
                {
                    return false;
                }
                return false;
            }
        }

        private string getTermTime()
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

        private void cmdSubscribe_Click(object sender, EventArgs e)
        {
            //for each patient in list...
            Cursor.Current = Cursors.WaitCursor;
            label2.Text = "";
            string notifyEndpoint = this.txtEndpoint.Text;
            if (notifyEndpoint == "")
            {
                MessageBox.Show("Endpoint required...");
                txtEndpoint.Focus();
            }
            else
            {
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
            Cursor.Current = Cursors.Default;
        }

        private void CloseForm()
        {
            cnn.Close();
            this.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.S))
            {
                frmSettings frmSettings = new frmSettings();
                frmSettings.StartPosition = FormStartPosition.Manual;
                frmSettings.StartPosition = FormStartPosition.CenterScreen;
                frmSettings.Owner = this;
                frmSettings.ShowDialog();
                return true;
            }
            else if (keyData == (Keys.F4))
            {
                this.cmdSubscribe.Enabled = true;
                //cnn.Close();
                lblTerm.Text = "Months to termination: " + Properties.Settings.Default.TermLength.ToString();
                lblTermDateTime.Text = "Termination Date: " + DateTime.Now.AddMonths(Properties.Settings.Default.TermLength).ToString("dddd, MMMM d, yyyy HH:mm:ss");
                label2.Text = "Settings up to date...";
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //check whether or not the subscription for stated patient already exists
        private bool checkSubscriptions(string patientId)
        {
            try
            {
                string dbPatientId = "";
                bool subExists = false;
                SqlCommand command;
                string sqlSelect = "select patientId from dbo.MySubscriptions";
                SqlDataReader dataReader;
                command = new SqlCommand(sqlSelect, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    dbPatientId = dataReader.GetString(0);
                    int posPatientId = dbPatientId.IndexOf(patientId);
                    if (posPatientId > -1)
                    {
                        subExists = true;
                        break;
                    }
                }
                dataReader.Close();
                if (subExists == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
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
                if (e.ColumnIndex == 0)
                {
                    e.Value = formatPatientId((string)e.Value);
                }
                int DataGridViewWidth = 0;
                foreach (DataGridViewColumn column in dgvSubscriptions.Columns)
                {
                    DataGridViewWidth = DataGridViewWidth + column.Width;
                }
                dgvSubscriptions.Width = DataGridViewWidth + 61;
                grpSubscriptions.Width = dgvSubscriptions.Width + 17;

                foreach (DataGridViewColumn col in dgvSubscriptions.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch(Exception ex)
            {
                //don't do anything...
            }
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            label5.Text = "To search for patient, double-click the PatientId column header";
            LoadSubscriptions();
            if (dgvSubscriptions.RowCount == 0)
            {
                dgvSubscriptions.Width = 410;
            }
        }

        private void tabShow_Enter(object sender, EventArgs e)
        {
            cmdUpdate_Click(null,null);
        }

        private void tabLoad_Enter(object sender, EventArgs e)
        {
            label5.Text = "";
            if (patientSubscriptionProcess == true)
            {
                lstPatients.Items.Clear();
                prbLoad.Value = 0;
                //label1.Text = "";
            }
        }

        private void dgvSubscriptions_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if(e.ColumnIndex == 0 && dgvSubscriptions.RowCount > 0)
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
            string textToSend = DateTime.Now.ToString();
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(host, port);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
                return true;
            }
            catch (Exception ex)
            {
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
    }
}
