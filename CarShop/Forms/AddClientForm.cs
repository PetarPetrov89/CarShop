using CarShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShop
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientsDataSet);

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientsDataSet.Clients);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            ShopForm main = new ShopForm();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientsForm clients = new ClientsForm();
            clients.Show();
            this.Hide();
        }
    }
}
