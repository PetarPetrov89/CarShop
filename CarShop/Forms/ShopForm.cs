using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarShop.Models;
using CarShop.Services;

namespace CarShop
{
    public partial class ShopForm : Form, IComandsService
    {

        public ShoppingCar shoppingCars = new ShoppingCar();
        public ShoppingWarrantly shoppingWarrantly = new ShoppingWarrantly();

        public BindingSource bindingSourceForShoppingCars = new BindingSource();
        public BindingSource bindingSourceForCars = new BindingSource();
        public BindingSource bindingSourceForWarrantly = new BindingSource();
        public BindingSource bindingSourceForShoppingWarrantly = new BindingSource();
        decimal CashBox = 0;
        public ShopForm()
        {
            InitializeComponent();
            UpdateUI();
            SetGridColumns();
            SetDataSource();
            SetDataBindings();
        }
        //This method take the information.
        private void SetDataSource()
        {
            bindingSourceForCars.DataSource = Car.GetCars();
            DataGridView1.DataSource = bindingSourceForCars;

            bindingSourceForWarrantly.DataSource = Warranty.GetWarantly();
            dataWarantly.DataSource = bindingSourceForWarrantly;

            bindingSourceForShoppingCars.DataSource = shoppingCars.Cars;
            dataReceipt.DataSource = bindingSourceForShoppingCars;

            bindingSourceForShoppingWarrantly.DataSource = shoppingWarrantly.Warrantly;
            dataGridView2.DataSource = bindingSourceForShoppingWarrantly;

        }
        private void UpdateUI()
        {
            DataGridView1.AutoGenerateColumns = false;
            dataWarantly.AutoGenerateColumns = false;
            dataReceipt.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
        }
        //This code create the table.
        private void SetGridColumns()
        {

            DataGridViewColumn col = new DataGridViewColumn();

            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Марка";
            col.DataPropertyName = "Brand";
            col.ReadOnly = true;
            DataGridView1.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Модел";
            col.DataPropertyName = "Model";
            col.ReadOnly = true;
            DataGridView1.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Цена";
            col.DataPropertyName = "Price";
            col.ReadOnly = false;
            DataGridView1.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Количество";
            col.DataPropertyName = "Qty";
            col.ReadOnly = false;
            DataGridView1.Columns.Add(col);
            
            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Цена";
            col.DataPropertyName = "Price";
            col.ReadOnly = false;
            dataWarantly.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Обща цена";
            col.DataPropertyName = "Sum";
            col.ReadOnly = false;
            DataGridView1.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Години";
            col.DataPropertyName = "Years";
            col.ReadOnly = false;
            dataWarantly.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Количество";
            col.DataPropertyName = "Qty";
            col.ReadOnly = false;
            dataWarantly.Columns.Add(col);
            
            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Марка";
            col.DataPropertyName = "Brand";
            col.ReadOnly = true;
            dataReceipt.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Модел";
            col.DataPropertyName = "Model";
            col.ReadOnly = true;
            dataReceipt.Columns.Add(col);            

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Цена";
            col.DataPropertyName = "Price";
            col.ReadOnly = false;
            dataReceipt.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Количество";
            col.DataPropertyName = "Qty";
            col.ReadOnly = false;
            dataReceipt.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Обща цена";
            col.DataPropertyName = "Sum";
            col.ReadOnly = false;
            dataReceipt.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Цена";
            col.DataPropertyName = "Price";
            col.ReadOnly = false;
            dataGridView2.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Години";
            col.DataPropertyName = "Years";
            col.ReadOnly = false;
            dataGridView2.Columns.Add(col);

            col = new DataGridViewColumn();
            col.CellTemplate = new DataGridViewTextBoxCell();
            col.HeaderText = "Количество";
            col.DataPropertyName = "Qty";
            col.ReadOnly = false;
            dataGridView2.Columns.Add(col);
        }
        //This code sum values from tables.
        private void SetDataBindings()
        {
            ClearDataBindings(this);

            textBox2.Text = string.Format("{0:C}", shoppingCars.SumOfAllCars);
            
            textBox3.Text = string.Format("{0:C}", shoppingWarrantly.SumOfAllWarrantly);
        }

        private void ClearDataBindings(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.DataBindings.Clear();

                ClearDataBindings(ctrl);
            }
        }      

        private void AddCarsToShopping(Car cars)
        {
            Car carsToAdd = new Car()
            {
                Brand = cars.Brand,
                Model= cars. Model,
                Price = cars.Price,
                Qty = cars.Qty

            };

            shoppingCars.Cars.Add(carsToAdd);
            bindingSourceForShoppingCars.ResetBindings(false);

            cars.Qty = 0;
            bindingSourceForCars.ResetBindings(false);
        }

        private void ClearShoppingCars()
        {
            shoppingCars.Cars.Clear();
            bindingSourceForShoppingCars.ResetBindings(false);
            textBox2.Text = "0";
        }  
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var view = sender as DataGridView;

            Car cars = (Car)view.CurrentRow.DataBoundItem;

            if (cars.Qty > 0)
            {
                AddCarsToShopping(cars);

            }
            else
            {
                MessageBox.Show("Моля въведете количество на желания продукт");
            }
        }
            private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDataBindings();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearShoppingCars();
        }

        public void Back()
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
        //Add the option to select the wanted item via checkbox.
        private void ShopForm_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Select";
            chkbox.Width = 25;
            chkbox.Name = "DGVchkBox";
            chkbox.DefaultCellStyle.BackColor = Color.Red;
            dataWarantly.Columns.Insert(0, chkbox);

            chk.HeaderText = "Select";
            chk.Width = 25;
            chk.Name = "DGchkBox";
            chk.DefaultCellStyle.BackColor = Color.Blue;
            DataGridView1.Columns.Insert(0, chk);
        }
        //Add the warrantly in cart.
        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Price");
            dt.Columns.Add("Years");
            dt.Columns.Add("Qty");

            foreach (DataGridViewRow drv in dataWarantly.Rows)
            {
                bool chkboxselect =Convert.ToBoolean(drv.Cells["DGVchkBox"].Value);
                if (chkboxselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value);
                    drv.DefaultCellStyle.BackColor = Color.Gray;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dataGridView2.DataSource = dt;
            }

        }
        //Add cars to cart.
        private void button6_Click(object sender, EventArgs e)
        {
            DataTable cars = new DataTable();

            cars.Columns.Add("Brand");
            cars.Columns.Add("Model");
            cars.Columns.Add("Price");
            cars.Columns.Add("Qty");
            cars.Columns.Add("Sum");

            foreach (DataGridViewRow drv in DataGridView1.Rows)
            {
                bool chkboxselect = Convert.ToBoolean(drv.Cells["DGchkBox"].Value);
                if (chkboxselect)
                {
                    cars.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value, drv.Cells[5].Value);
                    drv.DefaultCellStyle.BackColor = Color.Green;
                    drv.DefaultCellStyle.ForeColor = Color.Aqua;
                }
                dataReceipt.DataSource = cars;
            }
        }
        //Calculate the amounts of all selected cars.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataReceipt.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataReceipt.Rows[i].Cells[4].Value);
            }
            textBox2.Text = sum.ToString();
        }
        //Calculate the amounts of all selected warrantly.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int sumw = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sumw += Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
            }
            textBox3.Text = sumw.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetDataBindings();
        }
        //Total amount.
        private void label4_Click(object sender, EventArgs e)
        {
            double x1, y1, z;
            double.TryParse(textBox2.Text, out x1);
            double.TryParse(textBox3.Text, out y1);
            z = x1 + y1;
            textBox4.Text = z.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public OpenFileDialog OpenFile(OpenFileDialog openFile)
        {
            throw new NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TireForm tr = new TireForm();
            tr.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddClientForm enter = new AddClientForm();
            enter.Show();
            this.Hide();
        }
    }
}
