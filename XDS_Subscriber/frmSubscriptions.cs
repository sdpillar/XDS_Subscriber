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

        public frmSubscriptions()
        {
            InitializeComponent();
        }

        private void frmSubscriptions_Load(object sender, EventArgs e)
        {
            OnStartup();
            lblTerm.Text = "Months to termination: " + Properties.Settings.Default.TermLength.ToString();
            txtTermDateTime.Text = "Termination Date: " + DateTime.Now.AddMonths(Properties.Settings.Default.TermLength).ToString("dddd, MMMM d, yyyy HH:mm:ss");
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

                dgvSubscriptions.AutoGenerateColumns = true;
                dgvSubscriptions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSubscriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                bindingSourceSubscriptions.DataSource = GetData("Select patientId as PatientId, ConsumerReferenceAddress as Endpoint, CancerType, TerminationTime From dbo.MySubscriptions", cnn);
                dgvSubscriptions.DataSource = bindingSourceSubscriptions;
                int subscriptionCount = bindingSourceSubscriptions.Count;
                grpSubscriptions.Text = "Subscriptions (" + subscriptionCount + ")";
                int DataGridViewWidth = 0;
                foreach(DataGridViewColumn column in dgvSubscriptions.Columns)
                {
                    DataGridViewWidth = DataGridViewWidth + column.Width;
                }
                dgvSubscriptions.Width = DataGridViewWidth + 60;
                grpSubscriptions.Width = dgvSubscriptions.Width + 20;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to retrieve existing subscriptions\nCheck database settings", "Error");
            }
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
            UploadPatients();
        }

        private void UploadPatients()
        {
            try
            {
                DialogResult result = dlgLoadPatients.ShowDialog();
                if (result == DialogResult.OK)
                {
                    lstPatients.Items.Clear();
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
            DateTime subTime = DateTime.Parse(txtTermDateTime.Text.Substring(18));
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
            string notifyEndpoint = this.txtEndpoint.Text;
            if (lstPatients.Items.Count > 0)
            {
                for (int i = 0; i < lstPatients.Items.Count; i++)
                {
                    lstPatients.Items[i].Checked = false;
                }
                if (notifyEndpoint == "")
                {
                    MessageBox.Show("Endpoint required...");
                    txtEndpoint.Focus();
                }
                else
                {
                    int subscriptionCounter = -1;
                    bool subsExist = false;
                    //foreach(string patId in lstPatients.Items)
                    for (int i = 0; i < lstPatients.Items.Count; i++)
                    {
                        subscriptionCounter++;
                        string patient = lstPatients.Items[i].Text;
                        string cancerType = cmbType.Text;
                        bool exists = checkSubscriptions(patient);
                        if (exists == false)
                        {
                            bool patientSubscribed = PatientSubscribe(lstPatients.Items[i].Text, getTermTime(), notifyEndpoint, cancerType);
                            //if true, check item
                            if (patientSubscribed == true)
                            {
                                //lstPatients.SetItemCheckState(i, CheckState.Checked);
                                lstPatients.Items[i].Checked = true;
                            }
                        }
                        else
                        {
                            subsExist = true;
                        }
                    }
                    if (subsExist == true)
                    {
                        label2.Text = "Subscriptions created for checked patients.\nSubscriptions already exist for unchecked patients";
                    }
                    else
                    {
                        label2.Text = "Subscriptions created for checked patients.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Load patients...");
            }
            Cursor.Current = Cursors.Default;
        }

        private void nudMonths_ValueChanged(object sender, EventArgs e)
        {
            int months = Convert.ToInt32(nudMonths.Value);
            DateTime myTermDateTime = DateTime.Now.AddMonths(months);
            txtTermDateTime.Text = "Termination Date: " + myTermDateTime.ToString("dddd, MMMM d, yyyy HH:mm:ss");
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

        private void BuildSubscriptionsDataView()
        {
            
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
                cnn.Close();
                lblTerm.Text = "Months to termination: " + Properties.Settings.Default.TermLength.ToString();
                txtTermDateTime.Text = "Termination Date: " + DateTime.Now.AddMonths(Properties.Settings.Default.TermLength).ToString("dddd, MMMM d, yyyy HH:mm:ss");
                label2.Text = "Settings up to date...";
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

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

                if (ipAddress != "localhost")
                {
                    IPAddress clientIpAddr;
                    bool ipAddressCheck = IPAddress.TryParse(ipAddress, out clientIpAddr);

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
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ip Address and/or Port is invalid");
            }
        }

        private void dgvSubscriptions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                string fullPatientId = (string)e.Value;
                int posPatEnd = fullPatientId.IndexOf("^^^&");
                if (fullPatientId.Substring(0,4) == "CRIS")
                {
                    e.Value = fullPatientId.Substring(4, posPatEnd - 4);
                }
            }
        } 
    }
}
