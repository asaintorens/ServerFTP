using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerFTP.ClasseMetier
{
    public class ClientFTP
    {
        public TcpClient tcpClient;

        public string adresseIP { get; set; }
       public ClientFTP(TcpClient monClient)
        {
            this.tcpClient = monClient;
            this.adresseIP = monClient.Client.RemoteEndPoint.ToString();
            
        }


    }
}
