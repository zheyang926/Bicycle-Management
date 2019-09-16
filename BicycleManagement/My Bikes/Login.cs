using System;
using System.Collections.Generic;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Serialization;
using Mybikes.Bus;

namespace Mybikes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static String LoginFilePath = @"../login.txt";

        private void buttonLogin_Click(object sender, EventArgs e)

        {
            bool found = false;
            int x = 0;
            List<Loginpage> loginlist = new List<Loginpage>();
            IFileHandler interface_login;
            interface_login = new FileHandler();
            loginlist = interface_login.ReadFromLoginfile();
            foreach (Loginpage item in loginlist)
            {
                if (textBoxUsername.Text == item.Username && textBoxPasswd.Text == item.Password)
                {
                    //x = 1;
                    found = true;
                }
                //else
                //{
                //    x = 0; foun
                //}

            }
            if (found )
            {
                MessageBox.Show("Please enter <<My Bikes>>！", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username Or PAssword..!!");

            }


        }
    }
}


    

