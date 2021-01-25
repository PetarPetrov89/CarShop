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
using System.IO;
using CarShop.Services;

namespace CarShop
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();   
        
        //Checking user and password.
        private void button1_Click(object sender, EventArgs e)
        {
                  if (users.Contains(textBox1.Text) && pass.Contains(textBox2.Text) && Array.IndexOf(users.ToArray(), textBox1.Text) == Array.IndexOf(pass.ToArray(), textBox2.Text))
                    {
                        MainForm sf = new MainForm();
                        sf.Show();
                        this.Hide();
                    }            
                    else
                    {
                        MessageBox.Show("Incorect username or password!");
                    }         


        }
        //Reading from text file.
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("users.txt");
            string line = "";

            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }
            sr.Close();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Back()
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }        
    }
}
