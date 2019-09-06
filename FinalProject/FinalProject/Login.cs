using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UsernameTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_LOGIN_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "123456";
            if (UsernameTXT.Text == username && PasswordTXT.Text == password)
            {
                this.Hide();
                Home home = new Home(true);
                home.ShowDialog();
                this.Close();

            }
            else if(UsernameTXT.Text == "user") 
            {
                Home home = new Home(false);
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter correct username/password!!!!");
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
