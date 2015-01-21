using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
namespace ServerFTP.ClasseMetier
{
  public  class FTPServer
    {
        private TcpListener _listener;
        private FormMain formMain;

        public FTPServer(FormMain formMain)
        {
            this.formMain = formMain;
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, 39222);
            _listener.Start();
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
            this.formMain.consoleManager.AppendText( "Server Started", formMain.consoleManager.green);
        }

        public void Stop()
        {
            if (_listener != null)
            {
                _listener.Stop();
                this.formMain.consoleManager.AppendText("Server Stopped", formMain.consoleManager.green);
            }
        }

        private void HandleAcceptTcpClient(IAsyncResult result)
        {
            try
            {
                TcpClient client = _listener.EndAcceptTcpClient(result);
                _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
                this.formMain.consoleManager.AppendText(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString() + "Connected", formMain.consoleManager.green);

                ClientConnection connection = new ClientConnection(client,formMain.consoleManager);

                ThreadPool.QueueUserWorkItem(connection.HandleClient, client);
            }
            catch (Exception e)
            {

                this.formMain.consoleManager.AppendText(e.Message, formMain.consoleManager.green);
            }
     
             
            // DO SOMETHING.
        }
    }
}
