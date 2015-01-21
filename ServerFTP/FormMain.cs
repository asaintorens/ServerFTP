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
namespace ServerFTP
{
    public partial class FormMain : Form
    {
        public FTPServer ftpServer;
        public ManagerConsole consoleManager;
        public FormMain()
        {
            InitializeComponent();
            this.ftpServer = new FTPServer(this);
            this.consoleManager = new ManagerConsole(this);
            this.buttonStop.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AffichageClient unClient = new AffichageClient("10.10.10.10", "toto");
            unClient.Width = this.panelClients.Width;
           
            int numberClients = this.panelClients.Controls.Count;

            unClient.Location = new System.Drawing.Point(0, numberClients*40);

            unClient.Parent = this.panelClients;
            unClient.setPosition(0);
            this.panelClients.Controls.Add(unClient);
            unClient.Show();

        }


    }
}
