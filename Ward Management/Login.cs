using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ward_Management
{
    public partial class Login : Form
    {
        public string username, password;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new StreamReader("login.txt");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                if (username == _username.Text && password == _password.Text)
                {
                    MessageBox.Show("Welcome to APU Ward Management System.", "Login Successful!");
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!", "Login Failed!");
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
