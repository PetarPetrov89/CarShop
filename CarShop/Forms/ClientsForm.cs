using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop.Forms
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientsDataSet);

        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            //This line of code loads data into the 'clientsDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientsDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm cf = new AddClientForm();
            cf.Show();
            this.Hide();
        }
    }
}
