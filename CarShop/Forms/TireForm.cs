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
    public partial class TireForm : Form, IComands
    {
        public TireForm()
        {
            InitializeComponent();
        }

        //Reset Button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void Tires_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
            }
            if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
            }
            if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Focus();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
            }
            if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
            }
            if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
            }
            if (checkBox7.Checked == false)
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
            }
            if (checkBox8.Checked == false)
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {       

            double pricewintermercedes = 120.99; 
            double pricewinterbmw = 110.59; 
            double pricewintertoyota = 99.69; 
            double pricewinterdacia = 88.65;
            double pricesummermercedes = 112.49; 
            double pricesummerbmw = 115.12; 
            double pricesummertoyota = 95.16; 
            double pricesummerdacia = 87.87;
            

            double wintertiresMercedes = Convert.ToDouble(textBox1.Text);
            double wintertiresBMW = Convert.ToDouble(textBox2.Text);
            double wintertiresToyota = Convert.ToDouble(textBox3.Text);
            double wintertiresDacia = Convert.ToDouble(textBox4.Text);
            double summertiresMercedes = Convert.ToDouble(textBox5.Text);
            double summertiresBMW = Convert.ToDouble(textBox6.Text);
            double summertiresToyota = Convert.ToDouble(textBox7.Text);
            double summertiresDacia = Convert.ToDouble(textBox8.Text);                                                                
                       
            textBox9.Text = String.Format("{0:C}", ((pricewintermercedes * wintertiresMercedes) + (pricewinterbmw * wintertiresBMW) + (pricewintertoyota * wintertiresToyota) + (pricewinterdacia * wintertiresDacia)
                + (pricesummermercedes * summertiresMercedes) + (pricesummerbmw * summertiresBMW) + (pricesummertoyota * summertiresToyota) + pricesummerdacia * summertiresDacia), "лв");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();

            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Car Shop Swindom " + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Winter Mercedes \t\t\t\t" + textBox1.Text + Environment.NewLine);
            rtfReceipt.AppendText("Winter BMW \t\t\t\t" + textBox2.Text + Environment.NewLine);
            rtfReceipt.AppendText("Winter Toyota \t\t\t\t" + textBox3.Text + Environment.NewLine);
            rtfReceipt.AppendText("Winter Dacia \t\t\t\t" + textBox4.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Summer Mercedes \t\t\t\t" + textBox5.Text + Environment.NewLine);
            rtfReceipt.AppendText("Summer BMW \t\t\t\t" + textBox6.Text + Environment.NewLine);
            rtfReceipt.AppendText("Summer Toyota \t\t\t\t" + textBox7.Text + Environment.NewLine);
            rtfReceipt.AppendText("Summer Dacia \t\t\t\t" + textBox8.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------" + Environment.NewLine);            
            rtfReceipt.AppendText("Total Cost \t" + textBox9.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblData.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((IComands)this).Back();
        }

        void IComands.Back()
        {
            MainForm b = new MainForm();
            b.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Receipt Car Tires";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }     
        
    }
}
