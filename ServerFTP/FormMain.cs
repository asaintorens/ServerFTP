using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerFTP.ClasseMetier;
using Manager;
using System.Net.Sockets;
using System.Threading;
namespace ServerFTP
{
    public partial class FormMain : Form
    {
        public FTPServer ftpServer;
        public ManagerConsole consoleManager;
        public List<ClientFTP> ListClient;
        public BindingSource DataSourceListeClient;

        public FormMain()
        {

            InitializeComponent();
            this.ftpServer = new FTPServer(this);
            this.consoleManager = new ManagerConsole(this);
            this.buttonStop.Enabled = false;
            this.ListClient = new List<ClientFTP>();

            LoadGridView();
        }

        private void LoadGridView()
        {
            this.DataSourceListeClient = new BindingSource();
           
            this.DataSourceListeClient.DataSource = this.GetData();
            this.dataGridViewClientConnected.DataSource = this.DataSourceListeClient;
            this.dataGridViewClientConnected.Refresh();
            this.dataGridViewClientConnected.AutoGenerateColumns = true;

        }

        private object GetData()
        {
             List<ClientFTP> ListClientInit = new List<ClientFTP>();
             var value = from x in ListClientInit select new { x.adresseIP, x.tcpClient.Available, x.tcpClient.Connected, x.tcpClient.ReceiveBufferSize, x.tcpClient.ReceiveTimeout, x.tcpClient.Client.SendBufferSize };
            try
            {
                 value = from x in this.ListClient select new { x.adresseIP, x.tcpClient.Available, x.tcpClient.Connected, x.tcpClient.ReceiveBufferSize, x.tcpClient.ReceiveTimeout, x.tcpClient.Client.SendBufferSize };
                

            }
            catch (Exception e)
            {

            }
            return value;
            
         }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                this.ftpServer.Start();
                this.buttonStart.Enabled = false;
                this.buttonStop.Enabled = true;
            }
            catch (Exception xe)
            {
                this.consoleManager.AppendText(xe.Message, this.consoleManager.red);
            }
         
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.ftpServer.Stop();
                this.buttonStart.Enabled = true;
                this.buttonStop.Enabled = false;
            }
            catch (Exception xe)
            {
                this.consoleManager.AppendText(xe.Message, this.consoleManager.red);
                
            }
          
        }

        private void buttonGestionClient_Click(object sender, EventArgs e)
        {
            FormGestionClient formGestionClient = new FormGestionClient();
            formGestionClient.Show();
        }



        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void timerRefreshView_Tick(object sender, EventArgs e)
        {
             
             this.DataSourceListeClient.DataSource = this.GetData();
        }


    }
}
