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
namespace ServerFTP
{
    public partial class FormGestionClient : Form
    {
        public FormGestionClient()
        {
            InitializeComponent();
            var source = new BindingSource();
            source.DataSource = UserStore._users;        
            this.dataGridView1.DataSource = source;
            this.dataGridView1.Refresh();
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.Columns[0].ReadOnly = false;
        }

        private void FormGestionClient_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.ColumnIndex == this.dataGridView1.Columns["homedir"].Index)
            {
                FolderBrowserDialog monExplorer = new FolderBrowserDialog();
                DialogResult result = monExplorer.ShowDialog();
                this.dataGridView1.Rows[e.RowIndex].Cells["homedir"].Value = monExplorer.SelectedPath;

            }      
        }

       public void PopulateListViewClient()
        {
           
        

        }

       private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
       {
           List<User> users = UserStore._users;
           if (this.dataGridView1.Rows[e.RowIndex].Cells["username"].Value != null)
           {
               UserStore.Update(users);
           }
       }

       private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
       {
          
       }

       private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
       {
           List<User> users = UserStore._users;
           UserStore.Update(users);
       }




    
    }
}
