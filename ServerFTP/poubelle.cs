using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerFTP
{
   public class poubelle
    {
       public void test ()
       {
           Panel panel = new Panel();
           Control monControle = new Control();
           
           panel.Controls.Add(monControle);
       }
    }

    public class AffichageClient : Control
    {
        private Button ButtonCloseConnection;
        private Label LabelIpClient;
        private Label LabelClient;
        public AffichageClient(string ip,string username)
        {
            this.Height = 40;
            this.ButtonCloseConnection = new Button();
            this.ButtonCloseConnection.Text = "Close";
            this.ButtonCloseConnection.Width = 50;
            this.ButtonCloseConnection.Height = 25;
            this.ButtonCloseConnection.Show();
            this.LabelClient = new Label();
            this.LabelClient.Location = new System.Drawing.Point(220, 5);
            this.LabelClient.Text = username;
            this.LabelIpClient = new Label();
            this.LabelIpClient.Location = new System.Drawing.Point(5, 5);
            this.LabelIpClient.Text = ip;
            this.Controls.Add(ButtonCloseConnection);
            this.Controls.Add(LabelIpClient);
            this.Controls.Add(LabelClient);

        }
        public void setPosition(int y)
        {
            this.ButtonCloseConnection.Location = new System.Drawing.Point(this.Parent.Width-this.ButtonCloseConnection.Width, y);
            this.LabelClient.Location = new System.Drawing.Point(220, y);
            this.LabelIpClient.Location = new System.Drawing.Point(5, y);
            
            /*
            System.Drawing.Point local = new System.Drawing.Point(this.ButtonCloseConnection.Location.X, this.ButtonCloseConnection.Location.Y);
            this.ButtonCloseConnection.Location = new System.Drawing.Point(x - ButtonCloseConnection.Width, y);
            this.ButtonCloseConnection.Refresh();
            */
        }

      

    }

    
}
