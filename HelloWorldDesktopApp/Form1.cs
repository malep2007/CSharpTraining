using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldDesktopApp
{
    public partial class Form1 : Form
    {
        public string username = "emalinga";
        public string password = "training";

        public Form1()
        {
            InitializeComponent();
            usernameTextBox.Text = "Enter username here";
            passwordTextBox.PasswordChar = '\0';
            passwordTextBox.Text = "Enter Password here";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((usernameTextBox.Text == username) && (passwordTextBox.Text == password))
            {
                ItemListForm itemList = new ItemListForm(); //create instance of itemListForm
                itemList.Show();

            }
            else
            {
                MessageBox.Show("Login Unsuccessful!");
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Focused == true)
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
