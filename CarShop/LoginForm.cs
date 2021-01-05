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
    
    public partial class LoginForm : Form, IUser
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        List<IUser> login = AddSimpleData();

        string IUser.UserName { get; }

        public string Password { get; }

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

        public static List<IUser> AddSimpleData()
        {

        List<IUser> output = new List<IUser>();
            
            // Add users to the list.
            output.Add(new Users() { UserName = "user1", Password = "1234" });
            output.Add(new Users() { UserName = "user2", Password = "2345" });
            output.Add(new Users() { UserName = "user3", Password = "3456" });
            output.Add(new Users() { UserName = "Toni", Password = "deche" });
            
            return output;
        }
    }
}
